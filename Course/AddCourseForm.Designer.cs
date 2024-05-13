namespace WindowsFormsApp1
{
    partial class AddCourseForm
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
            this.lbIdCourse = new System.Windows.Forms.Label();
            this.lbNameCourse = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbDecri = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.txtId = new System.Windows.Forms.TextBox();
            this.rTxtDecription = new System.Windows.Forms.RichTextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.numericUpDownkihoc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkihoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdCourse
            // 
            this.lbIdCourse.AutoSize = true;
            this.lbIdCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIdCourse.Location = new System.Drawing.Point(56, 44);
            this.lbIdCourse.Name = "lbIdCourse";
            this.lbIdCourse.Size = new System.Drawing.Size(85, 20);
            this.lbIdCourse.TabIndex = 0;
            this.lbIdCourse.Text = "ID Course";
            // 
            // lbNameCourse
            // 
            this.lbNameCourse.AutoSize = true;
            this.lbNameCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameCourse.Location = new System.Drawing.Point(56, 128);
            this.lbNameCourse.Name = "lbNameCourse";
            this.lbNameCourse.Size = new System.Drawing.Size(112, 20);
            this.lbNameCourse.TabIndex = 1;
            this.lbNameCourse.Text = "Name Course";
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHours.Location = new System.Drawing.Point(56, 238);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(119, 20);
            this.lbHours.TabIndex = 2;
            this.lbHours.Text = "Hours Number";
            // 
            // lbDecri
            // 
            this.lbDecri.AutoSize = true;
            this.lbDecri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDecri.Location = new System.Drawing.Point(56, 328);
            this.lbDecri.Name = "lbDecri";
            this.lbDecri.Size = new System.Drawing.Size(95, 20);
            this.lbDecri.TabIndex = 3;
            this.lbDecri.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(224, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 27);
            this.txtName.TabIndex = 4;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDownHours.Location = new System.Drawing.Point(224, 238);
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownHours.TabIndex = 5;
            this.numericUpDownHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtId.Location = new System.Drawing.Point(224, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(336, 27);
            this.txtId.TabIndex = 4;
            // 
            // rTxtDecription
            // 
            this.rTxtDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rTxtDecription.Location = new System.Drawing.Point(224, 307);
            this.rTxtDecription.Name = "rTxtDecription";
            this.rTxtDecription.Size = new System.Drawing.Size(336, 96);
            this.rTxtDecription.TabIndex = 6;
            this.rTxtDecription.Text = "";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddCourse.Location = new System.Drawing.Point(224, 470);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(181, 44);
            this.btnAddCourse.TabIndex = 7;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // numericUpDownkihoc
            // 
            this.numericUpDownkihoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericUpDownkihoc.Location = new System.Drawing.Point(225, 183);
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
            this.numericUpDownkihoc.Size = new System.Drawing.Size(71, 27);
            this.numericUpDownkihoc.TabIndex = 16;
            this.numericUpDownkihoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(57, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Semester";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 554);
            this.Controls.Add(this.numericUpDownkihoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.rTxtDecription);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbDecri);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.lbNameCourse);
            this.Controls.Add(this.lbIdCourse);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkihoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdCourse;
        private System.Windows.Forms.Label lbNameCourse;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbDecri;
        private System.Windows.Forms.Button btnAddCourse;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.NumericUpDown numericUpDownHours;
        internal System.Windows.Forms.RichTextBox rTxtDecription;
        internal System.Windows.Forms.NumericUpDown numericUpDownkihoc;
        private System.Windows.Forms.Label label2;
    }
}