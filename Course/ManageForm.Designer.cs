namespace WindowsFormsApp1
{
    partial class ManageForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rTxtDecription = new System.Windows.Forms.RichTextBox();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbDecri = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbNameCourse = new System.Windows.Forms.Label();
            this.lbIdCourse = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.btn_search_Click = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            this.txtVT = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lableInfor = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrivious = new System.Windows.Forms.Button();
            this.PDF = new System.Windows.Forms.Button();
            this.btntxt = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.numericUpDownkihoc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkihoc)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(337, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Course";
            // 
            // rTxtDecription
            // 
            this.rTxtDecription.Location = new System.Drawing.Point(202, 390);
            this.rTxtDecription.Name = "rTxtDecription";
            this.rTxtDecription.Size = new System.Drawing.Size(336, 96);
            this.rTxtDecription.TabIndex = 26;
            this.rTxtDecription.Text = "";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(202, 323);
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHours.TabIndex = 25;
            this.numericUpDownHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(201, 183);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(336, 22);
            this.txtId.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 237);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 22);
            this.txtName.TabIndex = 24;
            // 
            // lbDecri
            // 
            this.lbDecri.AutoSize = true;
            this.lbDecri.Location = new System.Drawing.Point(34, 411);
            this.lbDecri.Name = "lbDecri";
            this.lbDecri.Size = new System.Drawing.Size(75, 16);
            this.lbDecri.TabIndex = 22;
            this.lbDecri.Text = "Description";
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(34, 323);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(94, 16);
            this.lbHours.TabIndex = 21;
            this.lbHours.Text = "Hours Number";
            // 
            // lbNameCourse
            // 
            this.lbNameCourse.AutoSize = true;
            this.lbNameCourse.Location = new System.Drawing.Point(33, 240);
            this.lbNameCourse.Name = "lbNameCourse";
            this.lbNameCourse.Size = new System.Drawing.Size(90, 16);
            this.lbNameCourse.TabIndex = 20;
            this.lbNameCourse.Text = "Name Course";
            // 
            // lbIdCourse
            // 
            this.lbIdCourse.AutoSize = true;
            this.lbIdCourse.Location = new System.Drawing.Point(33, 186);
            this.lbIdCourse.Name = "lbIdCourse";
            this.lbIdCourse.Size = new System.Drawing.Size(66, 16);
            this.lbIdCourse.TabIndex = 19;
            this.lbIdCourse.Text = "ID Course";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_remove.Location = new System.Drawing.Point(345, 530);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(86, 38);
            this.btn_remove.TabIndex = 71;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_edit.Location = new System.Drawing.Point(247, 531);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(88, 37);
            this.btn_edit.TabIndex = 70;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAddStudent.Location = new System.Drawing.Point(441, 531);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(88, 37);
            this.btnAddStudent.TabIndex = 68;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.IndianRed;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnReset.Location = new System.Drawing.Point(36, 532);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 38);
            this.btnReset.TabIndex = 69;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_total.Location = new System.Drawing.Point(939, 653);
            this.label_total.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(191, 25);
            this.label_total.TabIndex = 67;
            this.label_total.Text = "Total Student: 100";
            // 
            // btn_search_Click
            // 
            this.btn_search_Click.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_search_Click.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_search_Click.Location = new System.Drawing.Point(1267, 10);
            this.btn_search_Click.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_search_Click.Name = "btn_search_Click";
            this.btn_search_Click.Size = new System.Drawing.Size(129, 38);
            this.btn_search_Click.TabIndex = 66;
            this.btn_search_Click.Text = "Search";
            this.btn_search_Click.UseVisualStyleBackColor = false;
            this.btn_search_Click.Click += new System.EventHandler(this.btn_search_Click_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(853, 18);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(404, 22);
            this.textBox_search.TabIndex = 65;
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.AllowUserToAddRows = false;
            this.dataGridViewCourse.AllowUserToDeleteRows = false;
            this.dataGridViewCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourse.ColumnHeadersHeight = 29;
            this.dataGridViewCourse.Location = new System.Drawing.Point(592, 55);
            this.dataGridViewCourse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.RowHeadersWidth = 51;
            this.dataGridViewCourse.RowTemplate.Height = 24;
            this.dataGridViewCourse.Size = new System.Drawing.Size(851, 555);
            this.dataGridViewCourse.TabIndex = 64;
            this.dataGridViewCourse.DoubleClick += new System.EventHandler(this.dataGridViewCourse_DoubleClick);
            // 
            // txtVT
            // 
            this.txtVT.AutoSize = true;
            this.txtVT.Location = new System.Drawing.Point(662, 21);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(14, 16);
            this.txtVT.TabIndex = 78;
            this.txtVT.Text = "0";
            // 
            // txtMax
            // 
            this.txtMax.AutoSize = true;
            this.txtMax.Location = new System.Drawing.Point(703, 21);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(14, 16);
            this.txtMax.TabIndex = 77;
            this.txtMax.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 16);
            this.label9.TabIndex = 76;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 75;
            this.label10.Text = "Vị trí";
            // 
            // lableInfor
            // 
            this.lableInfor.AutoSize = true;
            this.lableInfor.Location = new System.Drawing.Point(84, 32);
            this.lableInfor.Name = "lableInfor";
            this.lableInfor.Size = new System.Drawing.Size(251, 16);
            this.lableInfor.TabIndex = 74;
            this.lableInfor.Text = "You can make edits or deletes through ID";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.Location = new System.Drawing.Point(1291, 616);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 37);
            this.btnNext.TabIndex = 73;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrivious
            // 
            this.btnPrivious.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrivious.Location = new System.Drawing.Point(592, 616);
            this.btnPrivious.Name = "btnPrivious";
            this.btnPrivious.Size = new System.Drawing.Size(105, 37);
            this.btnPrivious.TabIndex = 72;
            this.btnPrivious.Text = "Privious";
            this.btnPrivious.UseVisualStyleBackColor = false;
            this.btnPrivious.Click += new System.EventHandler(this.btnPrivious_Click);
            // 
            // PDF
            // 
            this.PDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDF.Location = new System.Drawing.Point(128, 623);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(107, 30);
            this.PDF.TabIndex = 79;
            this.PDF.Text = "PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // btntxt
            // 
            this.btntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntxt.Location = new System.Drawing.Point(255, 623);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(107, 30);
            this.btntxt.TabIndex = 80;
            this.btntxt.Text = "TXT";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // btnWord
            // 
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.Location = new System.Drawing.Point(378, 623);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(107, 30);
            this.btnWord.TabIndex = 81;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // numericUpDownkihoc
            // 
            this.numericUpDownkihoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownkihoc.Location = new System.Drawing.Point(201, 135);
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
            this.numericUpDownkihoc.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownkihoc.TabIndex = 83;
            this.numericUpDownkihoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Semester";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1515, 705);
            this.Controls.Add(this.numericUpDownkihoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.txtVT);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lableInfor);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrivious);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.btn_search_Click);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtDecription);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbDecri);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.lbNameCourse);
            this.Controls.Add(this.lbIdCourse);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownkihoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTxtDecription;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbDecri;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbNameCourse;
        private System.Windows.Forms.Label lbIdCourse;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button btn_search_Click;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        internal System.Windows.Forms.Label txtVT;
        internal System.Windows.Forms.Label txtMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lableInfor;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrivious;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.NumericUpDown numericUpDownkihoc;
        private System.Windows.Forms.Label label2;
    }
}