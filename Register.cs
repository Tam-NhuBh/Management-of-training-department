using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            my_db db = new my_db();
            if (verif())
            {
                if (IsSymbol(tbID.Text))
                {
                    // Kiểm tra ID, USer name và Email.....
                    if (!db.checkResById(tbID.Text))
                    {
                        if (!db.checkUserName(txtUsername.Text))
                        {
                            if (!db.checkEmail(txtEmail.Text))
                            {
                                MemoryStream pic = new MemoryStream();
                                pBoxAvata.Image.Save(pic, pBoxAvata.Image.RawFormat);

                                int typeUser = checkTypeUser();

                                SqlCommand command = new SqlCommand("INSERT INTO login (Id,Username, Password,F_name, L_name,Type_User, Image, Email)" + "VALUES (@id, @Un, @Pw,@fname, @lname,@type,@pic, @Email)", db.getConnection);
                                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(tbID.Text);
                                command.Parameters.Add("@Un", SqlDbType.NChar).Value = txtUsername.Text;

                                command.Parameters.Add("@Pw", SqlDbType.NChar).Value = txtPassword.Text;

                                command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = tbFname.Text;
                                command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = tbLName.Text;
                                command.Parameters.Add("@type", SqlDbType.Int).Value = typeUser;
                                command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray(); 
                                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                                db.openConnection();
                                if ((command.ExecuteNonQuery() == 1))
                                {
                                    db.closeConnection();
                                    MessageBox.Show("SUCCESSFULLY!");
                                }
                                else
                                {
                                    db.closeConnection();
                                    MessageBox.Show("error!");

                                }
                            }
                            else
                            {
                                MessageBox.Show("Email already exist", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        else
                        {
                            MessageBox.Show("User Name already exist", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("ID User already exist", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("ID User  must not contain strange characters","Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else 
            {
                MessageBox.Show("Empty Fields", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private int checkTypeUser()
        {
            if (rtBtStudent.Checked)
                return 1;
            else
                return 2;
        }
        bool verif()
        {
            if ((tbID.Text.Trim() == "") ||
                (tbFname.Text.Trim() == "") ||
                (tbLName.Text.Trim() == "") ||
                (txtUsername.Text.Trim() == "") ||
                (txtEmail.Text.Trim() == "") ||
                (txtPassword.Text.Trim() == "") ||
                (pBoxAvata.Image == null))
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
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pBoxAvata.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
