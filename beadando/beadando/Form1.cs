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
        public Form1()
        {
            InitializeComponent();

            // XML document létrehozása és az aktuális XML szöveg betöltése
            string fileName = "opendata.ecdc.europa.eu.xml";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

            XElement covidXml = XElement.Load(path);

            IEnumerable<XElement> hungary = from item in covidXml.Descendants("record")
                                            where (string)item.Element("countriesAndTerritories") == "Hungary"
                                            select item;
            dataGridView1.DataSource = hungary.ToList();
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
