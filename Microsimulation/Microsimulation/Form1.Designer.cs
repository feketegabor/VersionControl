namespace Microsimulation
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
            this.lbClosingYear = new System.Windows.Forms.Label();
            this.lbPopulation = new System.Windows.Forms.Label();
            this.tbPopulationFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudClosingYear = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudClosingYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClosingYear
            // 
            this.lbClosingYear.AutoSize = true;
            this.lbClosingYear.Location = new System.Drawing.Point(12, 18);
            this.lbClosingYear.Name = "lbClosingYear";
            this.lbClosingYear.Size = new System.Drawing.Size(35, 13);
            this.lbClosingYear.TabIndex = 0;
            this.lbClosingYear.Text = "label1";
            // 
            // lbPopulation
            // 
            this.lbPopulation.AutoSize = true;
            this.lbPopulation.Location = new System.Drawing.Point(228, 18);
            this.lbPopulation.Name = "lbPopulation";
            this.lbPopulation.Size = new System.Drawing.Size(35, 13);
            this.lbPopulation.TabIndex = 1;
            this.lbPopulation.Text = "label2";
            // 
            // tbPopulationFilePath
            // 
            this.tbPopulationFilePath.Location = new System.Drawing.Point(269, 14);
            this.tbPopulationFilePath.Name = "tbPopulationFilePath";
            this.tbPopulationFilePath.Size = new System.Drawing.Size(262, 20);
            this.tbPopulationFilePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(537, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(125, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "button1";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(668, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "button2";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudClosingYear
            // 
            this.nudClosingYear.Location = new System.Drawing.Point(53, 15);
            this.nudClosingYear.Name = "nudClosingYear";
            this.nudClosingYear.Size = new System.Drawing.Size(72, 20);
            this.nudClosingYear.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 396);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nudClosingYear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPopulationFilePath);
            this.Controls.Add(this.lbPopulation);
            this.Controls.Add(this.lbClosingYear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudClosingYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClosingYear;
        private System.Windows.Forms.Label lbPopulation;
        private System.Windows.Forms.TextBox tbPopulationFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudClosingYear;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

