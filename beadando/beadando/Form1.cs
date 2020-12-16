using beadando.Abstraction;
using beadando.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace beadando
{
    public partial class Form1 : Form
    {
        List<CovidRecord> Records = new List<CovidRecord>();
        List<CovidRecord> FilteredRecords = new List<CovidRecord>();
        public Control exportCsvButton { get; private set; }
        public Form1()
        {
            FilterButton filterButton = new FilterButton();
            this.Controls.Add(filterButton);
            filterButton.Click += FilterButton_Click;
            InitializeComponent();

            // XML element létrehozása és az XML fájl betöltése
            string fileName = "opendata.ecdc.europa.eu.xml";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

            string URL = "https://opendata.ecdc.europa.eu/covid19/casedistribution/xml";

            //XML BEOLVASÁS
            var xml = new XmlDocument();
            xml.Load(path);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var record = new CovidRecord();
                Records.Add(record);

                var firstChildElement = (XmlElement)element.ChildNodes[1];
                var secondChildElement = (XmlElement)element.ChildNodes[2];
                var thirdChildElement = (XmlElement)element.ChildNodes[3];
                var fourthChildElement = (XmlElement)element.ChildNodes[4];
                var fifthChildElement = (XmlElement)element.ChildNodes[5];
                var sixthChildElement = (XmlElement)element.ChildNodes[6];
                var ninthChildElement = (XmlElement)element.ChildNodes[9];
                var tenthChildElement = (XmlElement)element.ChildNodes[10];
                var eleventhChildElement = (XmlElement)element.ChildNodes[11];

                record.Day = int.Parse(firstChildElement.InnerText);
                record.Month = int.Parse(secondChildElement.InnerText);
                record.Year = int.Parse(thirdChildElement.InnerText);
                record.Cases = int.Parse(fourthChildElement.InnerText);
                record.Deaths = int.Parse(fifthChildElement.InnerText);
                record.Country = sixthChildElement.InnerText;

                long popData = 0;
                long.TryParse(ninthChildElement.InnerText, out popData);
                record.popData = popData;

                record.Continent = tenthChildElement.InnerText;

                decimal last14DaysPer1000 = 0;
                decimal.TryParse(eleventhChildElement.InnerText.Replace(".", ","), out last14DaysPer1000);
                record.last14DaysPer100000 = last14DaysPer1000;
            }

            //COMBOBOXOK ADATOKKAL VALÓ FELTÖLTÉSE
            var yearsList = (from r in Records group r by new { r.Year } into yearGroup select yearGroup.Key.Year).ToList();
            cbYear.DataSource = SelectionSort(yearsList);

            var monthsList = (from r in Records group r by new { r.Month } into monthGroup select monthGroup.Key.Month).ToList();
            cbMonth.DataSource = SelectionSort(monthsList);

            var daysList = (from r in Records group r by new { r.Day } into dayGroup select dayGroup.Key.Day).ToList();
            cbDay.DataSource = SelectionSort(daysList);

            cbContinent.DataSource = (from r in Records group r by new { r.Continent } into continentGroup select continentGroup.Key.Continent).ToList();

            //SZŰRŐK KEZDETI DEAKTIVÁLÁSA
            cbYear.Enabled = false;
            cbMonth.Enabled = false;
            cbDay.Enabled = false;
            cbContinent.Enabled = false;
            lbCountry.Enabled = false;
        }

        private List<int> SelectionSort(List<int> input)
        {
            for (var i = 0; i < input.Count; i++)
            {
                var min = i;
                for (var j = i + 1; j < input.Count; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
            }
            return input;
        }

        private void ListCountries()
        {
            if (chbContinent.Checked)
            {
                lbCountry.DataSource = (from r in Records
                                        where r.Continent == (string)cbContinent.SelectedItem
                                        group r by new { r.Country } into countryGroup
                                        select countryGroup.Key.Country).ToList();
            }
            else
            {
                lbCountry.DataSource = (from r in Records group r by new { r.Country } into countryGroup select countryGroup.Key.Country).ToList();
            }
        }

        private void cbContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListCountries();
        }

        private void chbContinent_CheckedChanged(object sender, EventArgs e)
        {
            ListCountries();
            cbContinent.Enabled = !cbContinent.Enabled;
        }

        private void chbYear_CheckedChanged(object sender, EventArgs e)
        {
            cbYear.Enabled = !cbYear.Enabled;
        }

        private void chbMonth_CheckedChanged(object sender, EventArgs e)
        {
            cbMonth.Enabled = !cbMonth.Enabled;
        }

        private void chbDay_CheckedChanged(object sender, EventArgs e)
        {
            cbDay.Enabled = !cbDay.Enabled;
        }

        private void chbCountry_CheckedChanged(object sender, EventArgs e)
        {
            lbCountry.Enabled = !lbCountry.Enabled;
        }

        

        private void FilterButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(exportCsvButton);
            var recordsToGet = (from r in Records select r);

            if (chbYear.Checked)
            {
                recordsToGet = from r in recordsToGet
                               where r.Year == (int)cbYear.SelectedItem
                               select r;
            }
            if (chbMonth.Checked)
            {
                recordsToGet = from r in recordsToGet
                               where r.Month == (int)cbMonth.SelectedItem
                               select r;
            }
            if (chbDay.Checked)
            {
                recordsToGet = from r in recordsToGet
                               where r.Day == (int)cbDay.SelectedItem
                               select r;
            }
            if (chbContinent.Checked)
            {
                recordsToGet = from r in recordsToGet
                               where r.Continent == (string)cbContinent.SelectedItem
                               select r;
            }
            if (chbCountry.Checked)
            {
                recordsToGet = from r in recordsToGet
                               where r.Country == (string)lbCountry.SelectedItem
                               select r;
            }
            FilteredRecords = recordsToGet.ToList();
            dataGridView1.DataSource = FilteredRecords;
            exportCsvButton = new ExportCsvButton(recordsToGet.ToList());
            Controls.Add(exportCsvButton);
        }
        
        //private void btnSort_Click(object sender, EventArgs e)
        //{
        //    var recordsToGet = (from r in Records select r);

        //    if (chbYear.Checked)
        //    {
        //        recordsToGet = from r in recordsToGet
        //                       where r.Year == (int)cbYear.SelectedItem
        //                       select r;
        //    }
        //    if (chbMonth.Checked)
        //    {
        //        recordsToGet = from r in recordsToGet
        //                       where r.Month == (int)cbMonth.SelectedItem
        //                       select r;
        //    }
        //    if (chbDay.Checked)
        //    {
        //        recordsToGet = from r in recordsToGet
        //                       where r.Day == (int)cbDay.SelectedItem
        //                       select r;
        //    }
        //    if (chbContinent.Checked)
        //    {
        //        recordsToGet = from r in recordsToGet
        //                       where r.Continent == (string)cbContinent.SelectedItem
        //                       select r;
        //    }
        //    if (chbCountry.Checked)
        //    {
        //        recordsToGet = from r in recordsToGet
        //                       where r.Country == (string)lbCountry.SelectedItem
        //                       select r;
        //    }
        //    FilteredRecords = recordsToGet.ToList();
        //    dataGridView1.DataSource = FilteredRecords;
        //    ExportCsvButton exportCsvButton = new ExportCsvButton(FilteredRecords);
        //    this.Controls.Add(exportCsvButton);
        //}
        
        //private void btnExportCsv_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog sfd = new SaveFileDialog();

        //    sfd.InitialDirectory = Application.StartupPath;
        //    sfd.Filter = "Comma Seperated Values (*.csv) |*.csv";
        //    sfd.DefaultExt = "csv";
        //    sfd.AddExtension = true;

        //    if (sfd.ShowDialog() != DialogResult.OK) return;
        //    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
        //    {
        //        foreach (var r in FilteredRecords)
        //        {
        //            sw.Write(r.Year);
        //            sw.Write(";");
        //            sw.Write(r.Month);
        //            sw.Write(";");
        //            sw.Write(r.Day);
        //            sw.Write(";");
        //            sw.Write(r.Cases);
        //            sw.Write(";");
        //            sw.Write(r.Deaths);
        //            sw.Write(";");
        //            sw.Write(r.Country);
        //            sw.Write(";");
        //            sw.Write(r.popData);
        //            sw.Write(";");
        //            sw.Write(r.Continent);
        //            sw.Write(";");
        //            sw.Write(r.last14DaysPer100000);
        //            sw.WriteLine();
        //        }
        //    }
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex + 1;
        }

        private void btnAutoScroll_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void chbAutoScroll_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
