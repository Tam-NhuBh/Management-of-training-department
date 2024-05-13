namespace WindowsFormsApp1
{
    partial class ManageStudent
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.btn_search_Click = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_tofind = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_down = new System.Windows.Forms.Button();
            this.TextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.PrintPDF = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(55, -24);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(404, 22);
            this.textBoxID.TabIndex = 58;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(-135, -21);
            this.label_ID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(20, 16);
            this.label_ID.TabIndex = 57;
            this.label_ID.Text = "ID";
            // 
            // btn_search_Click
            // 
            this.btn_search_Click.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_search_Click.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_search_Click.Location = new System.Drawing.Point(1119, 13);
            this.btn_search_Click.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_search_Click.Name = "btn_search_Click";
            this.btn_search_Click.Size = new System.Drawing.Size(129, 38);
            this.btn_search_Click.TabIndex = 56;
            this.btn_search_Click.Text = "Search";
            this.btn_search_Click.UseVisualStyleBackColor = false;
            this.btn_search_Click.Click += new System.EventHandler(this.btn_search_Click_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(705, 21);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(404, 22);
            this.textBox_search.TabIndex = 55;
            // 
            // label_tofind
            // 
            this.label_tofind.AutoSize = true;
            this.label_tofind.Location = new System.Drawing.Point(535, -21);
            this.label_tofind.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_tofind.Name = "label_tofind";
            this.label_tofind.Size = new System.Drawing.Size(126, 16);
            this.label_tofind.TabIndex = 54;
            this.label_tofind.Text = "Enter a value to find:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(607, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(934, 535);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_down.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_down.Location = new System.Drawing.Point(408, 571);
            this.btn_down.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(150, 55);
            this.btn_down.TabIndex = 52;
            this.btn_down.Text = "Download Image";
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(150, 271);
            this.TextBoxAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(404, 133);
            this.TextBoxAddress.TabIndex = 51;
            this.TextBoxAddress.Text = "";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUploadImage.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnUploadImage.Location = new System.Drawing.Point(150, 571);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(150, 55);
            this.btnUploadImage.TabIndex = 50;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 115);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(404, 22);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.RadioButtonFemale);
            this.panel1.Controls.Add(this.RadioButtonMale);
            this.panel1.Location = new System.Drawing.Point(150, 164);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 55);
            this.panel1.TabIndex = 46;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Location = new System.Drawing.Point(208, 18);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(74, 20);
            this.RadioButtonFemale.TabIndex = 6;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Location = new System.Drawing.Point(26, 18);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(58, 20);
            this.RadioButtonMale.TabIndex = 5;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(150, 227);
            this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(404, 22);
            this.TextBoxPhone.TabIndex = 49;
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Location = new System.Drawing.Point(148, 75);
            this.TextBoxLname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(404, 22);
            this.TextBoxLname.TabIndex = 45;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Location = new System.Drawing.Point(148, 32);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(404, 22);
            this.TextBoxFname.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-135, 412);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Picture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-135, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-135, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-135, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-135, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-135, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-135, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "First Name";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_total.Location = new System.Drawing.Point(1336, 617);
            this.label_total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(191, 25);
            this.label_total.TabIndex = 59;
            this.label_total.Text = "Total Student: 100";
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(150, 412);
            this.PictureBoxStudentImage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(408, 151);
            this.PictureBoxStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxStudentImage.TabIndex = 48;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_remove.Location = new System.Drawing.Point(6, 491);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(86, 38);
            this.btn_remove.TabIndex = 63;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_edit.Location = new System.Drawing.Point(4, 614);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(88, 37);
            this.btn_edit.TabIndex = 62;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnReset.Location = new System.Drawing.Point(971, 614);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 38);
            this.btnReset.TabIndex = 61;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 67;
            this.label9.Text = "Birth Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "First Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 69;
            this.label12.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 71;
            this.label13.Text = "Picture";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 16);
            this.label14.TabIndex = 70;
            this.label14.Text = "Address";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAddStudent.Location = new System.Drawing.Point(6, 558);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(88, 37);
            this.btnAddStudent.TabIndex = 60;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 16);
            this.label15.TabIndex = 72;
            this.label15.Text = "ID";
            // 
            // PrintPDF
            // 
            this.PrintPDF.Location = new System.Drawing.Point(1077, 614);
            this.PrintPDF.Name = "PrintPDF";
            this.PrintPDF.Size = new System.Drawing.Size(94, 36);
            this.PrintPDF.TabIndex = 74;
            this.PrintPDF.Text = "Print";
            this.PrintPDF.UseVisualStyleBackColor = true;
            this.PrintPDF.Click += new System.EventHandler(this.PrintPDF_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(148, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 22);
            this.txtID.TabIndex = 73;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1572, 701);
            this.Controls.Add(this.PrintPDF);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.btn_search_Click);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_tofind);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button btn_search_Click;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_tofind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.RichTextBox TextBoxAddress;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.PictureBox PictureBoxStudentImage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxLname;
        private System.Windows.Forms.TextBox TextBoxFname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button PrintPDF;
        private System.Windows.Forms.TextBox txtID;
    }
}