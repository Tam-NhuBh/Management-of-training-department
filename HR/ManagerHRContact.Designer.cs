namespace WindowsFormsApp1.HR
{
    partial class ManagerHRContact
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
            this.DVGCourseNTeacher = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvIdContact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCurrentCourse = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbEvent = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbNewCourse = new System.Windows.Forms.TextBox();
            this.tbOldCourse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOldCourse = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbDeleteCourse = new System.Windows.Forms.TextBox();
            this.lbCourseDelete = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVGCourseNTeacher)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DVGCourseNTeacher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 300);
            this.panel1.TabIndex = 0;
            // 
            // DVGCourseNTeacher
            // 
            this.DVGCourseNTeacher.AllowUserToAddRows = false;
            this.DVGCourseNTeacher.AllowUserToDeleteRows = false;
            this.DVGCourseNTeacher.AllowUserToResizeColumns = false;
            this.DVGCourseNTeacher.AllowUserToResizeRows = false;
            this.DVGCourseNTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVGCourseNTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGCourseNTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DVGCourseNTeacher.Location = new System.Drawing.Point(0, 0);
            this.DVGCourseNTeacher.Name = "DVGCourseNTeacher";
            this.DVGCourseNTeacher.RowHeadersWidth = 51;
            this.DVGCourseNTeacher.RowTemplate.Height = 24;
            this.DVGCourseNTeacher.Size = new System.Drawing.Size(1081, 300);
            this.DVGCourseNTeacher.TabIndex = 0;
            this.DVGCourseNTeacher.Click += new System.EventHandler(this.DVGCourseNTeacher_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lvIdContact);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBoxCurrentCourse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 385);
            this.panel2.TabIndex = 1;
            // 
            // lvIdContact
            // 
            this.lvIdContact.AutoSize = true;
            this.lvIdContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIdContact.Location = new System.Drawing.Point(172, 80);
            this.lvIdContact.Name = "lvIdContact";
            this.lvIdContact.Size = new System.Drawing.Size(94, 32);
            this.lvIdContact.TabIndex = 7;
            this.lvIdContact.Text = "20220";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Contact:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Course";
            // 
            // listBoxCurrentCourse
            // 
            this.listBoxCurrentCourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBoxCurrentCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxCurrentCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCurrentCourse.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBoxCurrentCourse.FormattingEnabled = true;
            this.listBoxCurrentCourse.ItemHeight = 31;
            this.listBoxCurrentCourse.Location = new System.Drawing.Point(0, 164);
            this.listBoxCurrentCourse.Name = "listBoxCurrentCourse";
            this.listBoxCurrentCourse.Size = new System.Drawing.Size(560, 221);
            this.listBoxCurrentCourse.TabIndex = 0;
            this.listBoxCurrentCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCurrentCourse_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(560, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 385);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.lbEvent);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(521, 88);
            this.panel6.TabIndex = 2;
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvent.Location = new System.Drawing.Point(156, 30);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(249, 32);
            this.lbEvent.TabIndex = 0;
            this.lbEvent.Text = "Mode of Operation";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.txbNewCourse);
            this.panel5.Controls.Add(this.tbOldCourse);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lbOldCourse);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(521, 186);
            this.panel5.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(195, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 43);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbNewCourse
            // 
            this.txbNewCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewCourse.Location = new System.Drawing.Point(195, 73);
            this.txbNewCourse.Name = "txbNewCourse";
            this.txbNewCourse.Size = new System.Drawing.Size(254, 34);
            this.txbNewCourse.TabIndex = 3;
            // 
            // tbOldCourse
            // 
            this.tbOldCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldCourse.Location = new System.Drawing.Point(195, 10);
            this.tbOldCourse.Name = "tbOldCourse";
            this.tbOldCourse.Size = new System.Drawing.Size(254, 34);
            this.tbOldCourse.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Course";
            // 
            // lbOldCourse
            // 
            this.lbOldCourse.AutoSize = true;
            this.lbOldCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldCourse.Location = new System.Drawing.Point(39, 10);
            this.lbOldCourse.Name = "lbOldCourse";
            this.lbOldCourse.Size = new System.Drawing.Size(136, 29);
            this.lbOldCourse.TabIndex = 0;
            this.lbOldCourse.Text = "Old Course";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.tbDeleteCourse);
            this.panel4.Controls.Add(this.lbCourseDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(521, 108);
            this.panel4.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(195, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 41);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbDeleteCourse
            // 
            this.tbDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeleteCourse.Location = new System.Drawing.Point(195, 6);
            this.tbDeleteCourse.Name = "tbDeleteCourse";
            this.tbDeleteCourse.Size = new System.Drawing.Size(250, 38);
            this.tbDeleteCourse.TabIndex = 3;
            // 
            // lbCourseDelete
            // 
            this.lbCourseDelete.AutoSize = true;
            this.lbCourseDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourseDelete.Location = new System.Drawing.Point(38, 12);
            this.lbCourseDelete.Name = "lbCourseDelete";
            this.lbCourseDelete.Size = new System.Drawing.Size(105, 32);
            this.lbCourseDelete.TabIndex = 0;
            this.lbCourseDelete.Text = "Course";
            // 
            // ManagerHRContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 685);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerHRContact";
            this.Text = "Manager Contact";
            this.Load += new System.EventHandler(this.ManagerHRContact_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DVGCourseNTeacher)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DVGCourseNTeacher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbEvent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbNewCourse;
        private System.Windows.Forms.TextBox tbOldCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOldCourse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbDeleteCourse;
        private System.Windows.Forms.Label lbCourseDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ListBox listBoxCurrentCourse;
        internal System.Windows.Forms.Label lvIdContact;
    }
}