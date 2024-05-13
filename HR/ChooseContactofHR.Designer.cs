namespace WindowsFormsApp1.HR
{
    partial class ChooseContactofHR
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
            this.DVGContactOfHR = new System.Windows.Forms.DataGridView();
            this.btnConfim = new System.Windows.Forms.Button();
            this.idContact = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DVGContactOfHR)).BeginInit();
            this.SuspendLayout();
            // 
            // DVGContactOfHR
            // 
            this.DVGContactOfHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGContactOfHR.Location = new System.Drawing.Point(75, 49);
            this.DVGContactOfHR.Name = "DVGContactOfHR";
            this.DVGContactOfHR.RowHeadersWidth = 51;
            this.DVGContactOfHR.RowTemplate.Height = 24;
            this.DVGContactOfHR.Size = new System.Drawing.Size(960, 410);
            this.DVGContactOfHR.TabIndex = 0;
            this.DVGContactOfHR.DoubleClick += new System.EventHandler(this.DVGContactOfHR_DoubleClick);
            // 
            // btnConfim
            // 
            this.btnConfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfim.Location = new System.Drawing.Point(831, 487);
            this.btnConfim.Name = "btnConfim";
            this.btnConfim.Size = new System.Drawing.Size(204, 58);
            this.btnConfim.TabIndex = 1;
            this.btnConfim.Text = "Confirm";
            this.btnConfim.UseVisualStyleBackColor = true;
            this.btnConfim.Click += new System.EventHandler(this.btnConfim_Click);
            // 
            // idContact
            // 
            this.idContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idContact.Location = new System.Drawing.Point(75, 496);
            this.idContact.Name = "idContact";
            this.idContact.Size = new System.Drawing.Size(237, 38);
            this.idContact.TabIndex = 2;
            // 
            // ChooseContactofHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 597);
            this.Controls.Add(this.idContact);
            this.Controls.Add(this.btnConfim);
            this.Controls.Add(this.DVGContactOfHR);
            this.Name = "ChooseContactofHR";
            this.Text = "ChooseContactofHR";
            this.Load += new System.EventHandler(this.ChooseContactofHR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVGContactOfHR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DVGContactOfHR;
        private System.Windows.Forms.Button btnConfim;
        internal System.Windows.Forms.TextBox idContact;
    }
}