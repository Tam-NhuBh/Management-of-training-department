using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using System.IO;

namespace WindowsFormsApp1.HR
{
    public partial class MainHRForm : Form
    {
        HRClass hrClass = new HRClass();
        public MainHRForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewContact addcontact = new AddNewContact();
            addcontact.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditContact editcontact = new EditContact();
            editcontact.ShowDialog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ChooseContactofHR chooseContactofHR = new ChooseContactofHR();
            chooseContactofHR.ShowDialog();
            
            if(chooseContactofHR.idCtact != null)
            {
                tbIDContactDelete.Text = chooseContactofHR.idCtact.ToString();
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(tbIDContactDelete.Text.Trim() != "")
            {
                int idContact =Convert.ToInt32(tbIDContactDelete.Text);
                if (hrClass.DeleteContact(idContact) )// , listcourse
                {
                    MessageBox.Show("Contact Deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Deleted Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainHRForm_Load(object sender, EventArgs e)
        {
            getImageAvata();
            lbUser.Text = "Welcome User ID: " + GlobalData.GlobalUserID;
            fillComboGroup(cbEditGroup);
            fillComboGroup(cbRemoveGroup);
        }
        private void fillComboGroup( ComboBox cbGroup, int index = 0)
        {
            cbGroup.DisplayMember = "name";
            cbGroup.ValueMember = "id";
            string idHR = GlobalData.GlobalUserID.ToString();
            cbGroup.DataSource = hrClass.getAllGroup(idHR);
            if (cbGroup.SelectedItem != null || cbGroup.SelectedIndex != -1)
            {
                cbGroup.SelectedIndex = index;
            }
            
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (txtNewName.Text.Trim() != "")
            {
                int idGroup = Convert.ToInt32(cbEditGroup.SelectedValue);
                string newName = txtNewName.Text;
                
                if (hrClass.EditGroup(idGroup, newName))// , listcourse
                {
                    fillComboGroup(cbEditGroup);
                    fillComboGroup(cbRemoveGroup);
                    MessageBox.Show("New Group Edited", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            if(cbRemoveGroup.SelectedIndex > -1)
            {
                if (cbRemoveGroup.SelectedValue.ToString() != "")
                {
                    int idGroup = Convert.ToInt32(cbRemoveGroup.SelectedValue);
                    if (hrClass.DeleteGroup(idGroup))// , listcourse
                    {
                        fillComboGroup(cbEditGroup);
                        fillComboGroup(cbRemoveGroup);
                        MessageBox.Show("Delete Group ", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtGroupID.Text.Trim() != "" && txtGroupName.Text.Trim() != "")
            {
                
                if (Symbol(txtGroupID.Text) ==true)
                {
                    int idGroup = Convert.ToInt32(txtGroupID.Text);
                    string nameGroup = txtGroupName.Text;
                    if (hrClass.checkExitbyIDGroup(idGroup))
                    {
                        if (hrClass.CheckExitNamebyIDHR(nameGroup))
                        {
                            if (hrClass.AddGroup(idGroup, nameGroup))// , listcourse
                            {
                                fillComboGroup(cbEditGroup);
                                fillComboGroup(cbRemoveGroup);
                                MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Group name is duplicated in your Group ", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id group is exited", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Id group is a number", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool Symbol(string pValue)
        {
            foreach (Char a in pValue)
            {
                if (Char.IsSymbol(a) || Char.IsWhiteSpace(a) || Char.IsLetter(a))
                {
                    return false;
                }
                 
            }
            return true;
        }

        private void btnShowFull_Click(object sender, EventArgs e)
        {
            FullContact fullContact = new FullContact();
            fullContact.ShowDialog();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {

            GlobalData.SetGlobalUserID(0);
            this.Close();
        }

        private void lbEditUser_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();
            this.Hide();
            editAccount.ShowDialog();
            getImageAvata();
            this.Visible = true;
        }
        private void getImageAvata()
        {
            DataTable dt = hrClass.GetDataOfUser(GlobalData.GlobalUserID);
            byte[] pic;
            pic = (byte[])dt.Rows[0][5];
            MemoryStream picture = new MemoryStream(pic);
            try
            {
                pbAvata.Image = Image.FromStream(picture);
            }
            catch (Exception ex)
            {
                pbAvata.Image = null;
            }
        }
    }
}
