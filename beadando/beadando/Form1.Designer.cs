namespace beadando
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbContinent = new System.Windows.Forms.ComboBox();
            this.lbCountry = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.chbYear = new System.Windows.Forms.CheckBox();
            this.chbMonth = new System.Windows.Forms.CheckBox();
            this.chbDay = new System.Windows.Forms.CheckBox();
            this.chbContinent = new System.Windows.Forms.CheckBox();
            this.chbCountry = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(12, 44);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(101, 21);
            this.cbYear.TabIndex = 1;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(119, 44);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(100, 21);
            this.cbMonth.TabIndex = 4;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(225, 44);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(98, 21);
            this.cbDay.TabIndex = 5;
            // 
            // cbContinent
            // 
            this.cbContinent.FormattingEnabled = true;
            this.cbContinent.Location = new System.Drawing.Point(12, 104);
            this.cbContinent.Name = "cbContinent";
            this.cbContinent.Size = new System.Drawing.Size(101, 21);
            this.cbContinent.Sorted = true;
            this.cbContinent.TabIndex = 9;
            this.cbContinent.SelectedIndexChanged += new System.EventHandler(this.cbContinent_SelectedIndexChanged);
            // 
            // lbCountry
            // 
            this.lbCountry.FormattingEnabled = true;
            this.lbCountry.Location = new System.Drawing.Point(119, 104);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(204, 199);
            this.lbCountry.Sorted = true;
            this.lbCountry.TabIndex = 10;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(45, 328);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(225, 57);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Szűrés";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(85, 391);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(143, 47);
            this.btnExportCsv.TabIndex = 12;
            this.btnExportCsv.Text = "Exportálás CSV-be";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // chbYear
            // 
            this.chbYear.AutoSize = true;
            this.chbYear.Location = new System.Drawing.Point(12, 21);
            this.chbYear.Name = "chbYear";
            this.chbYear.Size = new System.Drawing.Size(39, 17);
            this.chbYear.TabIndex = 13;
            this.chbYear.Text = "Év";
            this.chbYear.UseVisualStyleBackColor = true;
            this.chbYear.CheckedChanged += new System.EventHandler(this.chbYear_CheckedChanged);
            // 
            // chbMonth
            // 
            this.chbMonth.AutoSize = true;
            this.chbMonth.Location = new System.Drawing.Point(119, 21);
            this.chbMonth.Name = "chbMonth";
            this.chbMonth.Size = new System.Drawing.Size(58, 17);
            this.chbMonth.TabIndex = 14;
            this.chbMonth.Text = "Hónap";
            this.chbMonth.UseVisualStyleBackColor = true;
            this.chbMonth.CheckedChanged += new System.EventHandler(this.chbMonth_CheckedChanged);
            // 
            // chbDay
            // 
            this.chbDay.AutoSize = true;
            this.chbDay.Location = new System.Drawing.Point(225, 21);
            this.chbDay.Name = "chbDay";
            this.chbDay.Size = new System.Drawing.Size(46, 17);
            this.chbDay.TabIndex = 15;
            this.chbDay.Text = "Nap";
            this.chbDay.UseVisualStyleBackColor = true;
            this.chbDay.CheckedChanged += new System.EventHandler(this.chbDay_CheckedChanged);
            // 
            // chbContinent
            // 
            this.chbContinent.AutoSize = true;
            this.chbContinent.Location = new System.Drawing.Point(12, 81);
            this.chbContinent.Name = "chbContinent";
            this.chbContinent.Size = new System.Drawing.Size(73, 17);
            this.chbContinent.TabIndex = 16;
            this.chbContinent.Text = "Kontinens";
            this.chbContinent.UseVisualStyleBackColor = true;
            this.chbContinent.CheckedChanged += new System.EventHandler(this.chbContinent_CheckedChanged);
            // 
            // chbCountry
            // 
            this.chbCountry.AutoSize = true;
            this.chbCountry.Location = new System.Drawing.Point(119, 81);
            this.chbCountry.Name = "chbCountry";
            this.chbCountry.Size = new System.Drawing.Size(59, 17);
            this.chbCountry.TabIndex = 17;
            this.chbCountry.Text = "Ország";
            this.chbCountry.UseVisualStyleBackColor = true;
            this.chbCountry.CheckedChanged += new System.EventHandler(this.chbCountry_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 450);
            this.Controls.Add(this.chbCountry);
            this.Controls.Add(this.chbContinent);
            this.Controls.Add(this.chbDay);
            this.Controls.Add(this.chbMonth);
            this.Controls.Add(this.chbYear);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.cbContinent);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbContinent;
        private System.Windows.Forms.ListBox lbCountry;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.CheckBox chbYear;
        private System.Windows.Forms.CheckBox chbMonth;
        private System.Windows.Forms.CheckBox chbDay;
        private System.Windows.Forms.CheckBox chbContinent;
        private System.Windows.Forms.CheckBox chbCountry;
    }
}

