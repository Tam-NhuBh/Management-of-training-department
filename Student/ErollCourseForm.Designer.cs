namespace WindowsFormsApp1.Student
{
    partial class ErollCourseForm
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
            this.lbIdSV = new System.Windows.Forms.Label();
            this.NameCourse = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.lstBandau = new System.Windows.Forms.ListBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btTatcaphaisangtrai = new System.Windows.Forms.Button();
            this.btPhaisangtrai = new System.Windows.Forms.Button();
            this.btTatcatraisangphai = new System.Windows.Forms.Button();
            this.btTraisangphai = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhanHoi = new System.Windows.Forms.Label();
            this.lbNameCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIdSV
            // 
            this.lbIdSV.AutoSize = true;
            this.lbIdSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIdSV.Location = new System.Drawing.Point(34, 30);
            this.lbIdSV.Name = "lbIdSV";
            this.lbIdSV.Size = new System.Drawing.Size(24, 18);
            this.lbIdSV.TabIndex = 1;
            this.lbIdSV.Text = "ID";
            // 
            // NameCourse
            // 
            this.NameCourse.AutoSize = true;
            this.NameCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameCourse.Location = new System.Drawing.Point(34, 78);
            this.NameCourse.Name = "NameCourse";
            this.NameCourse.Size = new System.Drawing.Size(114, 18);
            this.NameCourse.TabIndex = 2;
            this.NameCourse.Text = "Name Student";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(168, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(261, 22);
            this.txtID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 72);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(261, 22);
            this.txtName.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(455, 407);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 31);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 16;
            this.lstKetqua.Location = new System.Drawing.Point(411, 149);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(221, 244);
            this.lstKetqua.TabIndex = 19;
            this.lstKetqua.SelectedIndexChanged += new System.EventHandler(this.lstKetqua_SelectedIndexChanged);
            // 
            // lstBandau
            // 
            this.lstBandau.FormattingEnabled = true;
            this.lstBandau.ItemHeight = 16;
            this.lstBandau.Location = new System.Drawing.Point(53, 149);
            this.lstBandau.Name = "lstBandau";
            this.lstBandau.Size = new System.Drawing.Size(221, 244);
            this.lstBandau.TabIndex = 18;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(94, 407);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(136, 31);
            this.btClose.TabIndex = 16;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btTatcaphaisangtrai
            // 
            this.btTatcaphaisangtrai.Location = new System.Drawing.Point(292, 276);
            this.btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
            this.btTatcaphaisangtrai.Size = new System.Drawing.Size(75, 23);
            this.btTatcaphaisangtrai.TabIndex = 15;
            this.btTatcaphaisangtrai.Text = "Clear";
            this.btTatcaphaisangtrai.UseVisualStyleBackColor = true;
            this.btTatcaphaisangtrai.Click += new System.EventHandler(this.btTatcaphaisangtrai_Click);
            // 
            // btPhaisangtrai
            // 
            this.btPhaisangtrai.Location = new System.Drawing.Point(292, 235);
            this.btPhaisangtrai.Name = "btPhaisangtrai";
            this.btPhaisangtrai.Size = new System.Drawing.Size(75, 23);
            this.btPhaisangtrai.TabIndex = 14;
            this.btPhaisangtrai.Text = "Delete";
            this.btPhaisangtrai.UseVisualStyleBackColor = true;
            this.btPhaisangtrai.Click += new System.EventHandler(this.btPhaisangtrai_Click);
            // 
            // btTatcatraisangphai
            // 
            this.btTatcatraisangphai.Location = new System.Drawing.Point(293, 206);
            this.btTatcatraisangphai.Name = "btTatcatraisangphai";
            this.btTatcatraisangphai.Size = new System.Drawing.Size(75, 23);
            this.btTatcatraisangphai.TabIndex = 13;
            this.btTatcatraisangphai.Text = ">>";
            this.btTatcatraisangphai.UseVisualStyleBackColor = true;
            this.btTatcatraisangphai.Click += new System.EventHandler(this.btTatcatraisangphai_Click);
            // 
            // btTraisangphai
            // 
            this.btTraisangphai.Location = new System.Drawing.Point(293, 166);
            this.btTraisangphai.Name = "btTraisangphai";
            this.btTraisangphai.Size = new System.Drawing.Size(75, 23);
            this.btTraisangphai.TabIndex = 12;
            this.btTraisangphai.Text = ">";
            this.btTraisangphai.UseVisualStyleBackColor = true;
            this.btTraisangphai.Click += new System.EventHandler(this.btTraisangphai_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(168, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(34, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Semester";
            // 
            // lbPhanHoi
            // 
            this.lbPhanHoi.AutoSize = true;
            this.lbPhanHoi.ForeColor = System.Drawing.Color.IndianRed;
            this.lbPhanHoi.Location = new System.Drawing.Point(315, 113);
            this.lbPhanHoi.Name = "lbPhanHoi";
            this.lbPhanHoi.Size = new System.Drawing.Size(76, 16);
            this.lbPhanHoi.TabIndex = 22;
            this.lbPhanHoi.Text = "Chọn kì học";
            // 
            // lbNameCourse
            // 
            this.lbNameCourse.AutoSize = true;
            this.lbNameCourse.Location = new System.Drawing.Point(408, 130);
            this.lbNameCourse.Name = "lbNameCourse";
            this.lbNameCourse.Size = new System.Drawing.Size(90, 16);
            this.lbNameCourse.TabIndex = 39;
            this.lbNameCourse.Text = "Name Course";
            // 
            // ErollCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 442);
            this.Controls.Add(this.lbNameCourse);
            this.Controls.Add(this.lbPhanHoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.lstBandau);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btTatcaphaisangtrai);
            this.Controls.Add(this.btPhaisangtrai);
            this.Controls.Add(this.btTatcatraisangphai);
            this.Controls.Add(this.btTraisangphai);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.NameCourse);
            this.Controls.Add(this.lbIdSV);
            this.Name = "ErollCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErollCourseForm";
            this.Load += new System.EventHandler(this.ErollCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbIdSV;
        internal System.Windows.Forms.Label NameCourse;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.ListBox lstBandau;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btTatcaphaisangtrai;
        private System.Windows.Forms.Button btPhaisangtrai;
        private System.Windows.Forms.Button btTatcatraisangphai;
        private System.Windows.Forms.Button btTraisangphai;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPhanHoi;
        private System.Windows.Forms.Label lbNameCourse;
    }
}