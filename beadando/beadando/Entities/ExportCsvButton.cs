using beadando.Abstraction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando.Entities
{
    class ExportCsvButton : ButtonDesign
    {
        List<CovidRecord> FilteredRecords = new List<CovidRecord>();
        public ExportCsvButton(List<CovidRecord> FilteredRecords)
        {
            this.FilteredRecords = FilteredRecords;
            Text = "Exportálás CSV-be";
            Width = 148;
            Height = 47;
            Left = 180;
            Top = 330;
            this.Click += ExportCsvButton_Click;
        }

        private void ExportCsvButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv) |*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var r in this.FilteredRecords)
                {
                    sw.Write(r.Year);
                    sw.Write(";");
                    sw.Write(r.Month);
                    sw.Write(";");
                    sw.Write(r.Day);
                    sw.Write(";");
                    sw.Write(r.Cases);
                    sw.Write(";");
                    sw.Write(r.Deaths);
                    sw.Write(";");
                    sw.Write(r.Country);
                    sw.Write(";");
                    sw.Write(r.popData);
                    sw.Write(";");
                    sw.Write(r.Continent);
                    sw.Write(";");
                    sw.Write(r.last14DaysPer100000);
                    sw.WriteLine();
                }
            }
            Parent.Controls.Remove(this);
        }
    }
}
