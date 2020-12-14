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

            //XElement covidXml = XElement.Load("https://opendata.ecdc.europa.eu/covid19/casedistribution/xml");
            //XElement covidXml = XElement.Load(path);

            //REKORD LISTA FELTÖLTÉSE
            //List<CovidRecord> covidRecords = covidXml.Elements("record").Select(x =>
            //new CovidRecord
            //{
            //    Year = int.Parse(x.Element("year").Value),
            //    Month = int.Parse(x.Element("month").Value),
            //    Day = int.Parse(x.Element("day").Value),
            //    Cases = int.Parse(x.Element("cases").Value),
            //    Deaths = int.Parse(x.Element("deaths").Value),
            //    Country = x.Element("countriesAndTerritories").Value,
            //    popData = int.Parse(x.Element("popData2019").Value),
            //    Continent = x.Element("continentExp").Value,
            //    //last14DaysPer100000 = double.Parse(x.Element("Cumulative_number_for_14_days_of_COVID-19_cases_per_100000").Value)
            //}).ToList();

            //XML BEOLVASÁS TANÓRA ALAPJÁN
            var xml = new XmlDocument();
            xml.LoadXml(path);

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
                record.popData = int.Parse(ninthChildElement.InnerText);
                record.Continent = tenthChildElement.InnerText;
                record.last14DaysPer100000 = double.Parse(eleventhChildElement.InnerText);
            }

            dataGridView1.DataSource = covidRecords;
            //SZŰRÉS MAGYAR REKORDOKRA
            //IEnumerable <XElement> hungary = from item in covidXml.Descendants("record")
            //                                where (string)item.Element("countriesAndTerritories") == "Hungary"
            //                                select item;
            //dataGridView1.DataSource = hungary.ToList();






            //var xml = new XmlDocument();
            //xml.LoadXml(path);

            //// Végigmegünk a dokumentum fő elemének gyermekein
            //foreach (XmlElement element in xml.DocumentElement)
            //{
            //    // Létrehozzuk az adatsort és rögtön hozzáadjuk a listához
            //    // Mivel ez egy referencia típusú változó, megtehetjük, hogy előbb adjuk a listához és csak később töltjük fel a tulajdonságait
            //    var rate = new RateData();
            //    Rates.Add(rate);

            //    // Dátum
            //    rate.Date = DateTime.Parse(element.GetAttribute("date"));

            //    // Valuta
            //    var childElement = (XmlElement)element.ChildNodes[0];
            //    rate.Currency = childElement.GetAttribute("curr");

            //    // Érték
            //    var unit = decimal.Parse(childElement.GetAttribute("unit"));
            //    var value = decimal.Parse(childElement.InnerText);
            //    if (unit != 0)
            //        rate.Value = value / unit;
            //}
        }
    }
}
