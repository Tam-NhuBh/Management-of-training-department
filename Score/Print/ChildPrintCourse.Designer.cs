namespace WindowsFormsApp1.Score.Print
{
    partial class ChildPrintCourse
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
            this.dataGridViewPrint = new System.Windows.Forms.DataGridView();
            this.panelButtonPrint = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printPDF = new System.Windows.Forms.Button();
            this.printWord = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).BeginInit();
            this.panelButtonPrint.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrint
            // 
            this.dataGridViewPrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewPrint.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPrint.Name = "dataGridViewPrint";
            this.dataGridViewPrint.RowHeadersWidth = 51;
            this.dataGridViewPrint.RowTemplate.Height = 24;
            this.dataGridViewPrint.Size = new System.Drawing.Size(999, 508);
            this.dataGridViewPrint.TabIndex = 0;
            // 
            // panelButtonPrint
            // 
            this.panelButtonPrint.Controls.Add(this.panel2);
            this.panelButtonPrint.Controls.Add(this.panel1);
            this.panelButtonPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtonPrint.Location = new System.Drawing.Point(0, 508);
            this.panelButtonPrint.Name = "panelButtonPrint";
            this.panelButtonPrint.Size = new System.Drawing.Size(999, 155);
            this.panelButtonPrint.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.printPDF);
            this.panel2.Controls.Add(this.printWord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(480, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 46);
            this.panel2.TabIndex = 2;
            // 
            // printPDF
            // 
            this.printPDF.BackColor = System.Drawing.SystemColors.Info;
            this.printPDF.Dock = System.Windows.Forms.DockStyle.Right;
            this.printPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPDF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.printPDF.Location = new System.Drawing.Point(356, 0);
            this.printPDF.Name = "printPDF";
            this.printPDF.Size = new System.Drawing.Size(163, 46);
            this.printPDF.TabIndex = 1;
            this.printPDF.Text = "Print PDF";
            this.printPDF.UseVisualStyleBackColor = false;
            this.printPDF.Click += new System.EventHandler(this.printPDF_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxCourse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 155);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(0, 0);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(480, 46);
            this.comboBoxCourse.TabIndex = 0;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourse_SelectedIndexChanged);
            // 
            // ChildPrintCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 663);
            this.Controls.Add(this.panelButtonPrint);
            this.Controls.Add(this.dataGridViewPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildPrintCourse";
            this.Text = "ChildPrintClass";
            this.Load += new System.EventHandler(this.ChildPrintCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrint)).EndInit();
            this.panelButtonPrint.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPrint;
        private System.Windows.Forms.Panel panelButtonPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button printPDF;
        private System.Windows.Forms.Button printWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
    }
}