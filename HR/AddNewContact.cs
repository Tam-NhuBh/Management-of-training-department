using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.HR
{
    public partial class AddNewContact : Form
    {
        HRClass hrClass= new HRClass();
        public AddNewContact()
        {
            InitializeComponent();
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pbImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (verif() ==true)
            {
                if(IsNumber(tbID.Text) == true && IsNumber( tbPhone.Text) ==true)
                {
                    int idContact = Convert.ToInt32(tbID.Text);
                    if(idContact > 0)
                    {
                        if (hrClass.CheckexistbyIdContact(idContact))
                        {
                            string fname = tbFName.Text;
                            string lname = tbLName.Text;
                            string phone = tbPhone.Text;
                            string email = tbEmail.Text;
                            string address = rtbAddress.Text;
                            string[] listcourse = rTbClass.Text.Split(',');

                            MemoryStream pic = new MemoryStream();
                            pbImage.Image.Save(pic, pbImage.Image.RawFormat);

                            int idHR = GlobalData.GlobalUserID;
                            int idGroup = Convert.ToInt32(cbGroup.SelectedValue);
                            if (hrClass.insertContact(idContact, fname, lname, idGroup, phone, email, address, pic, idHR)) // , listcourse
                            {
                                if (listcourse[0] != "")
                                {
                                    if (hrClass.enrollClass(idContact, listcourse))
                                    {
                                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("New Contact Added, But No course division", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contact  is exist", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The contact code must be a positive number", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("ID Contact or Phone must not contain characters, white sapce or symbols!", "AddContactForm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        bool verif()
        {
            if ((tbID.Text.Trim() == "") || 
                (tbFName.Text.Trim() == "") ||
                (tbLName.Text.Trim() == "") || 
                (rtbAddress.Text.Trim() == "") || 
                (tbPhone.Text.Trim() == "") || 
                (tbEmail.Text.Trim() == "") ||
                (pbImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsSymbol(string pValue)
        {
            foreach (Char a in pValue)
            {
                if (Char.IsSymbol(a) && Char.IsWhiteSpace(a))
                    return false;
            }
            return true;
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ChooseClass chooseClass = new ChooseClass();
            chooseClass.ShowDialog();
            rTbClass.Text = chooseClass.listCourse;
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillComboGroup(int index = 0)
        {


            cbGroup.DisplayMember = "name";
            cbGroup.ValueMember = "id";
            cbGroup.DataSource = hrClass.getAllGroup();
            if(this.cbGroup.SelectedItem != null || this.cbGroup.SelectedIndex != -1)
            {
                cbGroup.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("There is no group in the data ", "Group");
            }
            

        }

        private void AddNewContact_Load(object sender, EventArgs e)
        {
            fillComboGroup();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
