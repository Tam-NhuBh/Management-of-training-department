namespace WindowsFormsApp1.Score
{
    partial class FormPrintScore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.printScoreStu = new System.Windows.Forms.Button();
            this.printStudentInCourse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.printScoreStu);
            this.panel1.Controls.Add(this.printStudentInCourse);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 663);
            this.panel1.TabIndex = 0;
            // 
            // printScoreStu
            // 
            this.printScoreStu.Dock = System.Windows.Forms.DockStyle.Top;
            this.printScoreStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printScoreStu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.printScoreStu.Location = new System.Drawing.Point(0, 233);
            this.printScoreStu.Name = "printScoreStu";
            this.printScoreStu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.printScoreStu.Size = new System.Drawing.Size(208, 73);
            this.printScoreStu.TabIndex = 2;
            this.printScoreStu.Text = "Student";
            this.printScoreStu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printScoreStu.UseVisualStyleBackColor = true;
            this.printScoreStu.Click += new System.EventHandler(this.printScoreStu_Click);
            // 
            // printStudentInCourse
            // 
            this.printStudentInCourse.BackColor = System.Drawing.SystemColors.MenuText;
            this.printStudentInCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.printStudentInCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printStudentInCourse.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printStudentInCourse.Location = new System.Drawing.Point(0, 160);
            this.printStudentInCourse.Name = "printStudentInCourse";
            this.printStudentInCourse.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.printStudentInCourse.Size = new System.Drawing.Size(208, 73);
            this.printStudentInCourse.TabIndex = 1;
            this.printStudentInCourse.Text = "Course";
            this.printStudentInCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printStudentInCourse.UseVisualStyleBackColor = false;
            this.printStudentInCourse.Click += new System.EventHandler(this.printStudentInCourse_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 160);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.pngtree_account_human_man_person_abstract_circle_background_flat_colo_png_image_1646295;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(208, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(999, 663);
            this.panelChildForm.TabIndex = 1;
            // 
            // FormPrintScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 663);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1225, 710);
            this.Name = "FormPrintScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrintScore";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button printScoreStu;
        private System.Windows.Forms.Button printStudentInCourse;
        private System.Windows.Forms.Panel panelChildForm;
    }
}