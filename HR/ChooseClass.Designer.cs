namespace WindowsFormsApp1.HR
{
    partial class ChooseClass
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
            this.lbPhanHoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.lstBandau = new System.Windows.Forms.ListBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btTatcaphaisangtrai = new System.Windows.Forms.Button();
            this.btPhaisangtrai = new System.Windows.Forms.Button();
            this.btTatcatraisangphai = new System.Windows.Forms.Button();
            this.btTraisangphai = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbNameCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPhanHoi
            // 
            this.lbPhanHoi.AutoSize = true;
            this.lbPhanHoi.ForeColor = System.Drawing.Color.IndianRed;
            this.lbPhanHoi.Location = new System.Drawing.Point(99, 25);
            this.lbPhanHoi.Name = "lbPhanHoi";
            this.lbPhanHoi.Size = new System.Drawing.Size(76, 16);
            this.lbPhanHoi.TabIndex = 37;
            this.lbPhanHoi.Text = "Chọn kì học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ki hoc";
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
            this.comboBox1.Location = new System.Drawing.Point(159, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 16;
            this.lstKetqua.Location = new System.Drawing.Point(476, 92);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(221, 244);
            this.lstKetqua.TabIndex = 34;
            this.lstKetqua.SelectedIndexChanged += new System.EventHandler(this.lstKetqua_SelectedIndexChanged);
            // 
            // lstBandau
            // 
            this.lstBandau.FormattingEnabled = true;
            this.lstBandau.ItemHeight = 16;
            this.lstBandau.Location = new System.Drawing.Point(118, 92);
            this.lstBandau.Name = "lstBandau";
            this.lstBandau.Size = new System.Drawing.Size(221, 244);
            this.lstBandau.TabIndex = 33;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(159, 350);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(136, 31);
            this.btClose.TabIndex = 32;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btTatcaphaisangtrai
            // 
            this.btTatcaphaisangtrai.Location = new System.Drawing.Point(357, 219);
            this.btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
            this.btTatcaphaisangtrai.Size = new System.Drawing.Size(75, 23);
            this.btTatcaphaisangtrai.TabIndex = 31;
            this.btTatcaphaisangtrai.Text = "Clear";
            this.btTatcaphaisangtrai.UseVisualStyleBackColor = true;
            this.btTatcaphaisangtrai.Click += new System.EventHandler(this.btTatcaphaisangtrai_Click);
            // 
            // btPhaisangtrai
            // 
            this.btPhaisangtrai.Location = new System.Drawing.Point(357, 178);
            this.btPhaisangtrai.Name = "btPhaisangtrai";
            this.btPhaisangtrai.Size = new System.Drawing.Size(75, 23);
            this.btPhaisangtrai.TabIndex = 30;
            this.btPhaisangtrai.Text = "Delete";
            this.btPhaisangtrai.UseVisualStyleBackColor = true;
            this.btPhaisangtrai.Click += new System.EventHandler(this.btPhaisangtrai_Click);
            // 
            // btTatcatraisangphai
            // 
            this.btTatcatraisangphai.Location = new System.Drawing.Point(358, 149);
            this.btTatcatraisangphai.Name = "btTatcatraisangphai";
            this.btTatcatraisangphai.Size = new System.Drawing.Size(75, 23);
            this.btTatcatraisangphai.TabIndex = 29;
            this.btTatcatraisangphai.Text = ">>";
            this.btTatcatraisangphai.UseVisualStyleBackColor = true;
            this.btTatcatraisangphai.Click += new System.EventHandler(this.btTatcatraisangphai_Click);
            // 
            // btTraisangphai
            // 
            this.btTraisangphai.Location = new System.Drawing.Point(358, 109);
            this.btTraisangphai.Name = "btTraisangphai";
            this.btTraisangphai.Size = new System.Drawing.Size(75, 23);
            this.btTraisangphai.TabIndex = 28;
            this.btTraisangphai.Text = ">";
            this.btTraisangphai.UseVisualStyleBackColor = true;
            this.btTraisangphai.Click += new System.EventHandler(this.btTraisangphai_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(520, 350);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 31);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbNameCourse
            // 
            this.lbNameCourse.AutoSize = true;
            this.lbNameCourse.Location = new System.Drawing.Point(476, 56);
            this.lbNameCourse.Name = "lbNameCourse";
            this.lbNameCourse.Size = new System.Drawing.Size(90, 16);
            this.lbNameCourse.TabIndex = 38;
            this.lbNameCourse.Text = "Name Course";
            // 
            // ChooseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 417);
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
            this.Name = "ChooseClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseClass";
            this.Load += new System.EventHandler(this.ErollCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPhanHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.ListBox lstBandau;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btTatcaphaisangtrai;
        private System.Windows.Forms.Button btPhaisangtrai;
        private System.Windows.Forms.Button btTatcatraisangphai;
        private System.Windows.Forms.Button btTraisangphai;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbNameCourse;
    }
}