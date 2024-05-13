namespace WindowsFormsApp1.Score.Print
{
    partial class ChildPrintStudent
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
            this.panelButtonPrint = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintPDF = new System.Windows.Forms.Button();
            this.printWord = new System.Windows.Forms.Button();
            this.dataGridViewPrint = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.panelButtonPrint.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtonPrint
            // 
            this.panelButtonPrint.Controls.Add(this.panel2);
            this.panelButtonPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonPrint.Location = new System.Drawing.Point(0, 508);
            this.panelButtonPrint.Name = "panelButtonPrint";
            this.panelButtonPrint.Size = new System.Drawing.Size(361, 155);
            this.panelButtonPrint.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrintPDF);
            this.panel2.Controls.Add(this.printWord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 46);
            this.panel2.TabIndex = 2;
            // 
            // btnPrintPDF
            // 
            this.btnPrintPDF.BackColor = System.Drawing.SystemColors.Info;
            this.btnPrintPDF.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrintPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPDF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnPrintPDF.Location = new System.Drawing.Point(194, 0);
            this.btnPrintPDF.Name = "btnPrintPDF";
            this.btnPrintPDF.Size = new System.Drawing.Size(167, 46);
            this.btnPrintPDF.TabIndex = 1;
            this.btnPrintPDF.Text = "Print PDF";
            this.btnPrintPDF.UseVisualStyleBackColor = false;
            this.btnPrintPDF.Click += new System.EventHandler(this.btnPrintPDF_Click);
            // 
            // printWord
            // 
            this.printWord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printWord.Dock = System.Windows.Forms.DockStyle.Left;
            this.printWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printWord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printWord.Location = new System.Drawing.Point(0, 0);
            this.printWord.Name = "printWord";
            this.printWord.Size = new System.Drawing.Size(196, 46);
            this.printWord.TabIndex = 0;
            this.printWord.Text = "Print Word";
            this.printWord.UseVisualStyleBackColor = false;
            this.printWord.Click += new System.EventHandler(this.printWord_Click);
            // 
            // dataGridViewPrint
            // 
            this.dataGridViewPrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewPrint.Location = new System.Drawing.Point(361, 0);
            this.dataGridViewPrint.Name = "dataGridViewPrint";
            this.dataGridViewPrint.RowHeadersWidth = 51;
            this.dataGridViewPrint.RowTemplate.Height = 24;
            this.dataGridViewPrint.Size = new System.Drawing.Size(638, 663);
            this.dataGridViewPrint.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxStudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 508);
            this.panel1.TabIndex = 6;
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(0, 0);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(361, 28);
            this.comboBoxStudent.TabIndex = 0;
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // ChildPrintStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelButtonPrint);
            this.Controls.Add(this.dataGridViewPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildPrintStudent";
            this.Text = "ChildPrintStudent";
            this.Load += new System.EventHandler(this.ChildPrintStudent_Load);
            this.panelButtonPrint.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtonPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrintPDF;
        private System.Windows.Forms.Button printWord;
        private System.Windows.Forms.DataGridView dataGridViewPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxStudent;
    }
}