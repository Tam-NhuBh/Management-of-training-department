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
    public partial class EditContact : Form
    {
        HRClass hrClass = new HRClass();
        public EditContact()
        {
            InitializeComponent();
        }

        private void btnSelectContact_Click(object sender, EventArgs e)
        {
            ChooseContactofHR chooseContactofHR = new ChooseContactofHR();
            chooseContactofHR.ShowDialog();
            if(chooseContactofHR.idCtact != null) // Null khac voi ""
            {
                tbID.Text = chooseContactofHR.idCtact.ToString();
                if (tbID.Text.Trim() != "")
                {
                    DataTable dtContact = new DataTable();
                    int txbID = Convert.ToInt32(tbID.Text);
                    dtContact = hrClass.GetContactbyId(txbID);
                    tbFName.Text = dtContact.Rows[0]["fname"].ToString();
                    tbLName.Text = dtContact.Rows[0]["lname"].ToString();

                    tbPhone.Text = dtContact.Rows[0]["phone"].ToString();
                    tbEmail.Text = dtContact.Rows[0]["email"].ToString();
                    rtbAddress.Text = dtContact.Rows[0]["address"].ToString();
                    tbOldGroup.Text = dtContact.Rows[0]["NameGroup"].ToString();

                    byte[] pic;
                    pic = (byte[])dtContact.Rows[0]["pic"];
                    MemoryStream picture = new MemoryStream(pic);
                    pbImage.Image = Image.FromStream(picture);

                    DataTable dt = hrClass.getAllCoursebyTeach(txbID);
                    ShowCourseToList(dt, listCouseTeach);

                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("You have not selected any contact yet!!!", "Select Contact");

            }

            
        }
        private void ShowCourseToList(DataTable dataTable, ListBox lstBandau)
        {

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                lstBandau.Items.Add(dataTable.Rows[i]["Id"]);
            }
        }
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (verif() == true)
            {
                if (IsSymbol(tbID.Text) == true && IsSymbol(tbPhone.Text) == true)
                {
                    int idContact = Convert.ToInt32(tbID.Text);
                    string fname = tbFName.Text;
                    string lname = tbLName.Text;
                    string phone = tbPhone.Text;
                    string email = tbEmail.Text;
                    string address = rtbAddress.Text;

                    MemoryStream pic = new MemoryStream();
                    pbImage.Image.Save(pic, pbImage.Image.RawFormat);
                    int idHR = GlobalData.GlobalUserID;
                    int idGroup = Convert.ToInt32(cbGroup.SelectedValue);
                    if (hrClass.UpdateContact(idContact, fname, lname, idGroup, phone, email, address, pic, idHR)) // , listcourse
                    {
                        MessageBox.Show("New Updated", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                else
                {
                    MessageBox.Show("ID Contact or Phone must not contain strange characters, white sapce or symbols!", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void fillComboGroup(int index = 0)
        {
            cbGroup.DisplayMember = "name";
            cbGroup.ValueMember = "id";
            cbGroup.DataSource = hrClass.getAllGroup();
            if (this.cbGroup.SelectedItem != null || this.cbGroup.SelectedIndex != -1)
            {
                cbGroup.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("There is no group in the data ", "Group");
            }


        }

        private void EditContact_Load(object sender, EventArgs e)
        {
            fillComboGroup();
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

        private void btnChooseClass_Click(object sender, EventArgs e)
        {
            if (verif() == true)
            {
                 // Code chưa tốt
                ManagerHRContact managerHRContact = new ManagerHRContact();
                DataTable dt = hrClass.getAllCoursebyTeach(Convert.ToInt32( tbID.Text));
                ShowCourseToList(dt, managerHRContact.listBoxCurrentCourse);
                managerHRContact.lvIdContact.Text = tbID.Text;
                managerHRContact.ShowDialog();
                listCouseTeach.Items.Clear();
                dt = hrClass.getAllCoursebyTeach(Convert.ToInt32(tbID.Text));
                ShowCourseToList(dt, listCouseTeach);
            }
            else
            {
                MessageBox.Show("Empty Id Fields", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
