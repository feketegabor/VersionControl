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
        public Form1()
        {
            InitializeComponent();

            // XML element létrehozása és az XML fájl betöltése
            string fileName = "opendata.ecdc.europa.eu.xml";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

            string URL = "https://opendata.ecdc.europa.eu/covid19/casedistribution/xml";

            //XML BEOLVASÁS TANÓRA ALAPJÁN
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
            cbYear.DataSource = (from r in Records group r by new { r.Year } into yearGroup select yearGroup.Key.Year).ToList();
            cbMonth.DataSource = (from r in Records group r by new { r.Month } into monthGroup select monthGroup.Key.Month).ToList();
            cbDay.DataSource = (from r in Records group r by new { r.Day } into dayGroup select dayGroup.Key.Day).ToList();
            cbContinent.DataSource = (from r in Records group r by new { r.Continent } into continentGroup select continentGroup.Key.Continent).ToList();
            
            dataGridView1.DataSource = Records;

            //COMBOBOXOK KEZDETI DEAKTIVÁLÁSA
            cbContinent.Enabled = false;
        }

        private void ListCountries()
        {
            if (chbContinent.Checked)
            {
                lbCountry.DataSource = (from r in Records
                                        where r.Continent == (string)cbContinent.SelectedValue
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

        }

        private void chbMonth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbDay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbCountry_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
