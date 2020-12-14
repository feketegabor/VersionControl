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
            xml.Load(URL);

            //foreach (XmlNode node in xml)
            //{
            //    if (node.NodeType == XmlNodeType.XmlDeclaration)
            //    {
            //        xml.RemoveChild(node);
            //    }
            //}

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
                decimal.TryParse(eleventhChildElement.InnerText.Replace(".",","), out last14DaysPer1000);
                record.last14DaysPer100000 = last14DaysPer1000;

                //record.last14DaysPer100000 = eleventhChildElement.InnerText;
            }

            dataGridView1.DataSource = Records;
        }
    }
}
