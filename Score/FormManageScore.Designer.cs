namespace WindowsFormsApp1.Score
{
    partial class FormManageScore
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
            this.button_findscore = new System.Windows.Forms.Button();
            this.textBox_findscore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_select = new System.Windows.Forms.ComboBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_score = new System.Windows.Forms.Label();
            this.button_showsco = new System.Windows.Forms.Button();
            this.button_showstu = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_average = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.richTextBox_des = new System.Windows.Forms.RichTextBox();
            this.label_descrip = new System.Windows.Forms.Label();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTypeGetCourse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_findscore
            // 
            this.button_findscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_findscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_findscore.Location = new System.Drawing.Point(1159, 19);
            this.button_findscore.Name = "button_findscore";
            this.button_findscore.Size = new System.Drawing.Size(181, 41);
            this.button_findscore.TabIndex = 53;
            this.button_findscore.Text = "Find";
            this.button_findscore.UseVisualStyleBackColor = false;
            this.button_findscore.Click += new System.EventHandler(this.button_findscore_Click);
            // 
            // textBox_findscore
            // 
            this.textBox_findscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_findscore.Location = new System.Drawing.Point(625, 26);
            this.textBox_findscore.Name = "textBox_findscore";
            this.textBox_findscore.Size = new System.Drawing.Size(511, 27);
            this.textBox_findscore.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(513, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Find Score:";
            // 
            // comboBox_select
            // 
            this.comboBox_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_select.FormattingEnabled = true;
            this.comboBox_select.Location = new System.Drawing.Point(192, 107);
            this.comboBox_select.Name = "comboBox_select";
            this.comboBox_select.Size = new System.Drawing.Size(204, 33);
            this.comboBox_select.TabIndex = 50;
            this.comboBox_select.SelectedIndexChanged += new System.EventHandler(this.comboBox_select_SelectedIndexChanged);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_reset.Location = new System.Drawing.Point(928, 535);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(97, 29);
            this.button_reset.TabIndex = 49;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_edit.Location = new System.Drawing.Point(94, 488);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(128, 41);
            this.button_edit.TabIndex = 48;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_cancel.Location = new System.Drawing.Point(235, 488);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 41);
            this.button_cancel.TabIndex = 47;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_score.Location = new System.Drawing.Point(8, 210);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(58, 20);
            this.label_score.TabIndex = 46;
            this.label_score.Text = "Score";
            // 
            // button_showsco
            // 
            this.button_showsco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_showsco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_showsco.Location = new System.Drawing.Point(1129, 535);
            this.button_showsco.Name = "button_showsco";
            this.button_showsco.Size = new System.Drawing.Size(211, 29);
            this.button_showsco.TabIndex = 45;
            this.button_showsco.Text = "Show Scores";
            this.button_showsco.UseVisualStyleBackColor = true;
            this.button_showsco.Click += new System.EventHandler(this.button_showsco_Click);
            // 
            // button_showstu
            // 
            this.button_showstu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_showstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_showstu.Location = new System.Drawing.Point(503, 535);
            this.button_showstu.Name = "button_showstu";
            this.button_showstu.Size = new System.Drawing.Size(214, 29);
            this.button_showstu.TabIndex = 44;
            this.button_showstu.Text = "Show Students";
            this.button_showstu.UseVisualStyleBackColor = true;
            this.button_showstu.Click += new System.EventHandler(this.button_showstu_Click);
            // 
            // button_remove
            // 
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_remove.Location = new System.Drawing.Point(94, 441);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(128, 41);
            this.button_remove.TabIndex = 43;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_average
            // 
            this.button_average.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_average.Location = new System.Drawing.Point(94, 535);
            this.button_average.Name = "button_average";
            this.button_average.Size = new System.Drawing.Size(265, 41);
            this.button_average.TabIndex = 42;
            this.button_average.Text = "Average Score By Course";
            this.button_average.UseVisualStyleBackColor = true;
            this.button_average.Click += new System.EventHandler(this.button_average_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(503, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 443);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_add.Location = new System.Drawing.Point(235, 441);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(124, 41);
            this.button_add.TabIndex = 40;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // richTextBox_des
            // 
            this.richTextBox_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.richTextBox_des.Location = new System.Drawing.Point(192, 266);
            this.richTextBox_des.Name = "richTextBox_des";
            this.richTextBox_des.Size = new System.Drawing.Size(284, 149);
            this.richTextBox_des.TabIndex = 39;
            this.richTextBox_des.Text = "";
            // 
            // label_descrip
            // 
            this.label_descrip.AutoSize = true;
            this.label_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_descrip.Location = new System.Drawing.Point(8, 269);
            this.label_descrip.Name = "label_descrip";
            this.label_descrip.Size = new System.Drawing.Size(106, 20);
            this.label_descrip.TabIndex = 38;
            this.label_descrip.Text = "Description";
            // 
            // textBox_score
            // 
            this.textBox_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_score.Location = new System.Drawing.Point(192, 207);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(284, 27);
            this.textBox_score.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Select Course";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_id.Location = new System.Drawing.Point(192, 151);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(284, 27);
            this.textBox_id.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Student ID";
            // 
            // cbSemester
            // 
            this.cbSemester.Enabled = false;
            this.cbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(192, 65);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(89, 28);
            this.cbSemester.TabIndex = 54;
            this.cbSemester.SelectedIndexChanged += new System.EventHandler(this.cbSemester_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(8, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Select Semester";
            // 
            // lbTypeGetCourse
            // 
            this.lbTypeGetCourse.AutoSize = true;
            this.lbTypeGetCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTypeGetCourse.Location = new System.Drawing.Point(298, 68);
            this.lbTypeGetCourse.Name = "lbTypeGetCourse";
            this.lbTypeGetCourse.Size = new System.Drawing.Size(156, 20);
            this.lbTypeGetCourse.TabIndex = 57;
            this.lbTypeGetCourse.Text = "Select All Course";
            // 
            // FormManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 611);
            this.Controls.Add(this.lbTypeGetCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.button_findscore);
            this.Controls.Add(this.textBox_findscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_select);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.button_showsco);
            this.Controls.Add(this.button_showstu);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_average);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.richTextBox_des);
            this.Controls.Add(this.label_descrip);
            this.Controls.Add(this.textBox_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Name = "FormManageScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManageScore";
            this.Load += new System.EventHandler(this.FormManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_findscore;
        private System.Windows.Forms.TextBox textBox_findscore;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox comboBox_select;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button_showsco;
        private System.Windows.Forms.Button button_showstu;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_average;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.RichTextBox richTextBox_des;
        private System.Windows.Forms.Label label_descrip;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTypeGetCourse;
    }
}