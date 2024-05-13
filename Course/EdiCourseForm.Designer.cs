namespace WindowsFormsApp1
{
    partial class EdiCourseForm
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
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.rTxtDecription = new System.Windows.Forms.RichTextBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbDecri = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbNameCourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDownkihoc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkihoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Location = new System.Drawing.Point(280, 516);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(181, 44);
            this.btnEditCourse.TabIndex = 16;
            this.btnEditCourse.Text = "Edit";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // rTxtDecription
            // 
            this.rTxtDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtDecription.Location = new System.Drawing.Point(315, 335);
            this.rTxtDecription.Name = "rTxtDecription";
            this.rTxtDecription.Size = new System.Drawing.Size(336, 96);
            this.rTxtDecription.TabIndex = 15;
            this.rTxtDecription.Text = "";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHours.Location = new System.Drawing.Point(318, 265);
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(70, 34);
            this.numericUpDownHours.TabIndex = 14;
            this.numericUpDownHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(318, 205);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 34);
            this.txtName.TabIndex = 13;
            // 
            // lbDecri
            // 
            this.lbDecri.AutoSize = true;
            this.lbDecri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDecri.Location = new System.Drawing.Point(27, 335);
            this.lbDecri.Name = "lbDecri";
            this.lbDecri.Size = new System.Drawing.Size(135, 29);
            this.lbDecri.TabIndex = 11;
            this.lbDecri.Text = "Description";
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHours.Location = new System.Drawing.Point(31, 264);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(170, 29);
            this.lbHours.TabIndex = 10;
            this.lbHours.Text = "Hours Number";
            // 
            // lbNameCourse
            // 
            this.lbNameCourse.AutoSize = true;
            this.lbNameCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCourse.Location = new System.Drawing.Point(31, 207);
            this.lbNameCourse.Name = "lbNameCourse";
            this.lbNameCourse.Size = new System.Drawing.Size(162, 29);
            this.lbNameCourse.TabIndex = 9;
            this.lbNameCourse.Text = "Name Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Course";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(315, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(337, 37);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDownkihoc
            // 
            this.numericUpDownkihoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownkihoc.Location = new System.Drawing.Point(316, 127);
            this.numericUpDownkihoc.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownkihoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownkihoc.Name = "numericUpDownkihoc";
            this.numericUpDownkihoc.Size = new System.Drawing.Size(120, 34);
            this.numericUpDownkihoc.TabIndex = 21;
            this.numericUpDownkihoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Semester";
            // 
            // EdiCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.numericUpDownkihoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.rTxtDecription);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbDecri);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.lbNameCourse);
            this.Name = "EdiCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdiCourseForm";
            this.Load += new System.EventHandler(this.EdiCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkihoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Label lbDecri;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbNameCourse;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RichTextBox rTxtDecription;
        internal System.Windows.Forms.NumericUpDown numericUpDownHours;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.NumericUpDown numericUpDownkihoc;
    }
}