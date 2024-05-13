namespace WindowsFormsApp1
{
    partial class UpdateDeleteStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtBdate = new System.Windows.Forms.DateTimePicker();
            this.checkMale = new System.Windows.Forms.RadioButton();
            this.checkFemale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbaddress = new System.Windows.Forms.RichTextBox();
            this.btnPrivious = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.btnFindID = new System.Windows.Forms.Button();
            this.lableInfor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_user = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.Label();
            this.txtVT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(167, 161);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(87, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(167, 219);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(172, 22);
            this.txtfname.TabIndex = 2;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(167, 424);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(172, 22);
            this.txtphone.TabIndex = 5;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(167, 282);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(172, 22);
            this.txtlname.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Picture";
            // 
            // dtBdate
            // 
            this.dtBdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBdate.Location = new System.Drawing.Point(167, 346);
            this.dtBdate.Name = "dtBdate";
            this.dtBdate.Size = new System.Drawing.Size(172, 22);
            this.dtBdate.TabIndex = 4;
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(116, 23);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(58, 20);
            this.checkMale.TabIndex = 6;
            this.checkMale.TabStop = true;
            this.checkMale.Text = "Male";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(116, 49);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(74, 20);
            this.checkFemale.TabIndex = 7;
            this.checkFemale.TabStop = true;
            this.checkFemale.Text = "Female";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkFemale);
            this.panel1.Controls.Add(this.checkMale);
            this.panel1.Location = new System.Drawing.Point(543, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 100);
            this.panel1.TabIndex = 11;
            // 
            // rtbaddress
            // 
            this.rtbaddress.Location = new System.Drawing.Point(543, 196);
            this.rtbaddress.Name = "rtbaddress";
            this.rtbaddress.Size = new System.Drawing.Size(514, 96);
            this.rtbaddress.TabIndex = 8;
            this.rtbaddress.Text = "";
            // 
            // btnPrivious
            // 
            this.btnPrivious.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPrivious.Location = new System.Drawing.Point(401, 566);
            this.btnPrivious.Name = "btnPrivious";
            this.btnPrivious.Size = new System.Drawing.Size(105, 37);
            this.btnPrivious.TabIndex = 14;
            this.btnPrivious.Text = "Privious";
            this.btnPrivious.UseVisualStyleBackColor = false;
            this.btnPrivious.Click += new System.EventHandler(this.btnPrivious_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEdt.Location = new System.Drawing.Point(150, 566);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(105, 37);
            this.btnEdt.TabIndex = 12;
            this.btnEdt.Text = "Edit";
            this.btnEdt.UseVisualStyleBackColor = false;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Location = new System.Drawing.Point(261, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 37);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnNext.Location = new System.Drawing.Point(39, 566);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 37);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(543, 298);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(514, 319);
            this.PictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxStudentImage.TabIndex = 13;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUploadImage.Location = new System.Drawing.Point(708, 623);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(207, 49);
            this.btnUploadImage.TabIndex = 9;
            this.btnUploadImage.Text = "Update Inmage";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // btnFindID
            // 
            this.btnFindID.Location = new System.Drawing.Point(264, 161);
            this.btnFindID.Name = "btnFindID";
            this.btnFindID.Size = new System.Drawing.Size(75, 23);
            this.btnFindID.TabIndex = 14;
            this.btnFindID.Text = "Find ID";
            this.btnFindID.UseVisualStyleBackColor = true;
            this.btnFindID.Click += new System.EventHandler(this.btnFindID_Click);
            // 
            // lableInfor
            // 
            this.lableInfor.AutoSize = true;
            this.lableInfor.Location = new System.Drawing.Point(57, 104);
            this.lableInfor.Name = "lableInfor";
            this.lableInfor.Size = new System.Drawing.Size(251, 16);
            this.lableInfor.TabIndex = 17;
            this.lableInfor.Text = "You can make edits or deletes through ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label_user);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 69);
            this.panel2.TabIndex = 20;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(192, 23);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(62, 29);
            this.label_user.TabIndex = 2;
            this.label_user.Text = "UTE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(33, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Welcome :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Vị trí";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "/";
            // 
            // txtMax
            // 
            this.txtMax.AutoSize = true;
            this.txtMax.Location = new System.Drawing.Point(181, 81);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(14, 16);
            this.txtMax.TabIndex = 22;
            this.txtMax.Text = "0";
            // 
            // txtVT
            // 
            this.txtVT.AutoSize = true;
            this.txtVT.Location = new System.Drawing.Point(140, 81);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(14, 16);
            this.txtVT.TabIndex = 23;
            this.txtVT.Text = "0";
            // 
            // UpdateDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 676);
            this.Controls.Add(this.txtVT);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lableInfor);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.btnFindID);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdt);
            this.Controls.Add(this.btnPrivious);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.rtbaddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtBdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDeleteStudentForm";
            this.Load += new System.EventHandler(this.UpdateDeleteStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPrivious;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUploadImage;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.DateTimePicker dtBdate;
        internal System.Windows.Forms.TextBox txtphone;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.RichTextBox rtbaddress;
        internal System.Windows.Forms.PictureBox PictureBoxStudentImage;
        private System.Windows.Forms.Button btnFindID;
        internal System.Windows.Forms.RadioButton checkMale;
        internal System.Windows.Forms.RadioButton checkFemale;
        private System.Windows.Forms.Label lableInfor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label txtMax;
        internal System.Windows.Forms.Label txtVT;
    }
}