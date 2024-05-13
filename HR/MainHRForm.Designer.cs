namespace WindowsFormsApp1.HR
{
    partial class MainHRForm
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
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbEditUser = new System.Windows.Forms.Label();
            this.pbAvata = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.panelContact = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tbIDContactDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowFull = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbEditGroup = new System.Windows.Forms.ComboBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbRemoveGroup = new System.Windows.Forms.ComboBox();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnBrk = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvata)).BeginInit();
            this.panelContact.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbLogout);
            this.panel1.Controls.Add(this.lbEditUser);
            this.panel1.Controls.Add(this.pbAvata);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.IndianRed;
            this.lbLogout.Location = new System.Drawing.Point(336, 59);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(72, 24);
            this.lbLogout.TabIndex = 3;
            this.lbLogout.Text = "Logout";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbEditUser
            // 
            this.lbEditUser.AutoSize = true;
            this.lbEditUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEditUser.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditUser.ForeColor = System.Drawing.Color.IndianRed;
            this.lbEditUser.Location = new System.Drawing.Point(172, 59);
            this.lbEditUser.Name = "lbEditUser";
            this.lbEditUser.Size = new System.Drawing.Size(132, 24);
            this.lbEditUser.TabIndex = 2;
            this.lbEditUser.Text = "Edit my profile";
            this.lbEditUser.Click += new System.EventHandler(this.lbEditUser_Click);
            // 
            // pbAvata
            // 
            this.pbAvata.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAvata.Location = new System.Drawing.Point(0, 0);
            this.pbAvata.Name = "pbAvata";
            this.pbAvata.Size = new System.Drawing.Size(166, 100);
            this.pbAvata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvata.TabIndex = 1;
            this.pbAvata.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(172, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(209, 25);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Welcome (User name)";
            // 
            // panelContact
            // 
            this.panelContact.Controls.Add(this.panel5);
            this.panelContact.Controls.Add(this.panel4);
            this.panelContact.Controls.Add(this.panel3);
            this.panelContact.Controls.Add(this.btnShowFull);
            this.panelContact.Controls.Add(this.panel2);
            this.panelContact.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContact.Location = new System.Drawing.Point(0, 100);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(681, 555);
            this.panelContact.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(681, 282);
            this.panel5.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(95, 184);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(153, 49);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(95, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Controls.Add(this.tbIDContactDelete);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 126);
            this.panel4.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(505, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(154, 31);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select Contact";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbIDContactDelete
            // 
            this.tbIDContactDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDContactDelete.Location = new System.Drawing.Point(273, 17);
            this.tbIDContactDelete.Name = "tbIDContactDelete";
            this.tbIDContactDelete.ReadOnly = true;
            this.tbIDContactDelete.Size = new System.Drawing.Size(189, 30);
            this.tbIDContactDelete.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Contact ID";
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(0, 80);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemove.Size = new System.Drawing.Size(681, 46);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 408);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 80);
            this.panel3.TabIndex = 2;
            // 
            // btnShowFull
            // 
            this.btnShowFull.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFull.Location = new System.Drawing.Point(0, 488);
            this.btnShowFull.Name = "btnShowFull";
            this.btnShowFull.Size = new System.Drawing.Size(681, 46);
            this.btnShowFull.TabIndex = 1;
            this.btnShowFull.Text = "Show Full List";
            this.btnShowFull.UseVisualStyleBackColor = true;
            this.btnShowFull.Click += new System.EventHandler(this.btnShowFull_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 21);
            this.panel2.TabIndex = 0;
            // 
            // panelGroup
            // 
            this.panelGroup.Controls.Add(this.panel12);
            this.panelGroup.Controls.Add(this.panel11);
            this.panelGroup.Controls.Add(this.panel10);
            this.panelGroup.Controls.Add(this.panel9);
            this.panelGroup.Controls.Add(this.panel8);
            this.panelGroup.Controls.Add(this.panel7);
            this.panelGroup.Controls.Add(this.panel6);
            this.panelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroup.Location = new System.Drawing.Point(705, 100);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(596, 555);
            this.panelGroup.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel12.Controls.Add(this.label7);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(596, 77);
            this.panel12.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 54);
            this.label7.TabIndex = 1;
            this.label7.Text = "Group";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Controls.Add(this.txtGroupID);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.btnAddGroup);
            this.panel11.Controls.Add(this.txtGroupName);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 77);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(596, 126);
            this.panel11.TabIndex = 8;
            // 
            // txtGroupID
            // 
            this.txtGroupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupID.Location = new System.Drawing.Point(262, 13);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(189, 30);
            this.txtGroupID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enter Group ID";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.Location = new System.Drawing.Point(50, 89);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(154, 31);
            this.btnAddGroup.TabIndex = 6;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Location = new System.Drawing.Point(262, 52);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(314, 30);
            this.txtGroupName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter Group Name";
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 203);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(596, 39);
            this.panel10.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Controls.Add(this.cbEditGroup);
            this.panel9.Controls.Add(this.txtNewName);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.btnEditGroup);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 242);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(596, 146);
            this.panel9.TabIndex = 6;
            // 
            // cbEditGroup
            // 
            this.cbEditGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditGroup.FormattingEnabled = true;
            this.cbEditGroup.Location = new System.Drawing.Point(273, 15);
            this.cbEditGroup.Name = "cbEditGroup";
            this.cbEditGroup.Size = new System.Drawing.Size(189, 33);
            this.cbEditGroup.TabIndex = 6;
            // 
            // txtNewName
            // 
            this.txtNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewName.Location = new System.Drawing.Point(273, 75);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(189, 30);
            this.txtNewName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Enter New Name";
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGroup.Location = new System.Drawing.Point(46, 109);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(154, 31);
            this.btnEditGroup.TabIndex = 3;
            this.btnEditGroup.Text = "Edit";
            this.btnEditGroup.UseVisualStyleBackColor = true;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Group";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 388);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(596, 20);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.cbRemoveGroup);
            this.panel7.Controls.Add(this.btnRemoveGroup);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 408);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(596, 126);
            this.panel7.TabIndex = 4;
            // 
            // cbRemoveGroup
            // 
            this.cbRemoveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemoveGroup.FormattingEnabled = true;
            this.cbRemoveGroup.Location = new System.Drawing.Point(262, 18);
            this.cbRemoveGroup.Name = "cbRemoveGroup";
            this.cbRemoveGroup.Size = new System.Drawing.Size(189, 33);
            this.cbRemoveGroup.TabIndex = 7;
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGroup.Location = new System.Drawing.Point(50, 74);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(154, 31);
            this.btnRemoveGroup.TabIndex = 3;
            this.btnRemoveGroup.Text = "Remove";
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Contact ID";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 534);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(596, 21);
            this.panel6.TabIndex = 1;
            // 
            // pnBrk
            // 
            this.pnBrk.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnBrk.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBrk.Location = new System.Drawing.Point(681, 100);
            this.pnBrk.Name = "pnBrk";
            this.pnBrk.Size = new System.Drawing.Size(24, 555);
            this.pnBrk.TabIndex = 2;
            // 
            // MainHRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 655);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.pnBrk);
            this.Controls.Add(this.panelContact);
            this.Controls.Add(this.panel1);
            this.Name = "MainHRForm";
            this.Text = "MainHRForm";
            this.Load += new System.EventHandler(this.MainHRForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvata)).EndInit();
            this.panelContact.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelGroup.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Label lbEditUser;
        private System.Windows.Forms.PictureBox pbAvata;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panelContact;
        private System.Windows.Forms.Button btnShowFull;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox tbIDContactDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbEditGroup;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbRemoveGroup;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnBrk;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
    }
}