namespace WindowsFormsApp1
{
    partial class sendCode
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
            this.label_codeevent = new System.Windows.Forms.Label();
            this.label_emailevent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtVerCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_codeevent
            // 
            this.label_codeevent.AutoSize = true;
            this.label_codeevent.BackColor = System.Drawing.Color.Transparent;
            this.label_codeevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_codeevent.ForeColor = System.Drawing.Color.Red;
            this.label_codeevent.Location = new System.Drawing.Point(43, 228);
            this.label_codeevent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_codeevent.Name = "label_codeevent";
            this.label_codeevent.Size = new System.Drawing.Size(43, 18);
            this.label_codeevent.TabIndex = 23;
            this.label_codeevent.Text = "event";
            // 
            // label_emailevent
            // 
            this.label_emailevent.AutoSize = true;
            this.label_emailevent.BackColor = System.Drawing.Color.Transparent;
            this.label_emailevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_emailevent.ForeColor = System.Drawing.Color.Red;
            this.label_emailevent.Location = new System.Drawing.Point(41, 104);
            this.label_emailevent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_emailevent.Name = "label_emailevent";
            this.label_emailevent.Size = new System.Drawing.Size(43, 18);
            this.label_emailevent.TabIndex = 22;
            this.label_emailevent.Text = "event";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(42, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Code";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.ForeColor = System.Drawing.Color.DimGray;
            this.lb1.Location = new System.Drawing.Point(39, 49);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(41, 16);
            this.lb1.TabIndex = 20;
            this.lb1.Text = "Email";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(138, 251);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Vetify Code";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVerCode
            // 
            this.txtVerCode.Location = new System.Drawing.Point(44, 197);
            this.txtVerCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerCode.Name = "txtVerCode";
            this.txtVerCode.Size = new System.Drawing.Size(338, 22);
            this.txtVerCode.TabIndex = 18;
            this.txtVerCode.Click += new System.EventHandler(this.txtVerCode_Click);
            this.txtVerCode.Enter += new System.EventHandler(this.txtVerCode_Enter);
            this.txtVerCode.Leave += new System.EventHandler(this.txtVerCode_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(138, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(43, 73);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(338, 22);
            this.textEmail.TabIndex = 16;
            this.textEmail.Click += new System.EventHandler(this.textEmail_Click);
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // sendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 333);
            this.Controls.Add(this.label_codeevent);
            this.Controls.Add(this.label_emailevent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtVerCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textEmail);
            this.Name = "sendCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sendCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_codeevent;
        private System.Windows.Forms.Label label_emailevent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtVerCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textEmail;
    }
}