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

namespace WindowsFormsApp1
{
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
            fillDataOfUser();
        }

        HRClass hR = new HRClass();
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            int id = GlobalData.GlobalUserID;
            string user = textBox_username.Text;
            string pass = textBox_pass.Text;
            string fname = tbFName.Text;
            string lname = tbLName.Text;
            int type = Convert.ToInt32(numericUpDown_type.Value);
            string email = tbEmail.Text;

            
                MemoryStream pic = new MemoryStream();
                
                

                if (verif() == true)
                {
                    pbImage.Image.Save(pic, pbImage.Image.RawFormat);
                    if (hR.UpdateAccount(id, user, pass, fname, lname, type, pic, email))
                    {
                        MessageBox.Show("Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        bool verif()
        {
            if ((textBox_username.Text.Trim() == "") || (textBox_pass.Text.Trim() == "") || (tbFName.Text.Trim() == "") || (tbLName.Text.Trim() == "")  || (tbEmail.Text.Trim() == "") || (pbImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //kiểm tra sđt
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c) || !Char.IsSymbol(c) || !Char.IsWhiteSpace(c))
                    return false;
            }
            return true;
        }
        //kiểm tra kí tự
        public bool IsCharacter(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsLetter(c) || !Char.IsSymbol(c))
                    return false;
            }
            return true;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            //duyệt ảnh trong mt của bạn
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(opf.FileName);
            }
        }
        private void fillDataOfUser()
        {
            int idHr = GlobalData.GlobalUserID;
            DataTable dt = hR.GetDataOfUser(idHr);
            textBox_username.Text = dt.Rows[0][0].ToString().Replace(" ", "");
            textBox_pass.Text = dt.Rows[0][1].ToString().Replace(" ", ""); 
            tbFName.Text = dt.Rows[0][2].ToString();
            tbLName.Text = dt.Rows[0][3].ToString();
            tbEmail.Text = dt.Rows[0][6].ToString().Replace(" ", ""); 
            numericUpDown_type.Value = Convert.ToDecimal( dt.Rows[0][4].ToString());

            byte[] pic;
            pic = (byte[])dt.Rows[0][5];
            MemoryStream picture = new MemoryStream(pic);
            try
            {
                pbImage.Image = Image.FromStream(picture);
            }
            catch (Exception ex)
            {
                pbImage.Image = null;
            }
            //pbImage.Image = Image.FromStream(picture);

        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            fillDataOfUser();
        }
    }
}
