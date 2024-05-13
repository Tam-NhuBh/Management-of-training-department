using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.HR;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            label_userevent.Visible = false;
            this.textBoxUsername.Click += new System.EventHandler(this.textBoxUsername_Click);

            label_passevent.Visible = false;
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                label_userevent.Text = "Please provide Username";
                label_userevent.Visible = true;
                return;
            }
            if (textBoxPassword.Text == "")
            {
                label_passevent.Text = "Please provide Password";
                label_passevent.Visible = true;
                return;
            }
            
            if (login(textBoxUsername.Text, textBoxPassword.Text))
            {
                if(GlobalData.GlobalUserType == 1)
                {
                    MainForm01 MForm = new MainForm01();
                    //this.Hide();
                    this.Visible = false;
                    MForm.ShowDialog();
                    this.Visible = true;
                    //this.Close();
                }
                else if(GlobalData.GlobalUserType == 2)
                {
                    MainHRForm mainHR = new MainHRForm();
                    this.Visible = false;
                    mainHR.ShowDialog();
                    this.Visible = true;
                    //this.Close();
                }
            }
            else
            {
                label_userevent.Text = "Username or Password does not exist!";
                label_userevent.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendCode cs = new sendCode();
            this.Hide();
            cs.ShowDialog();
            this.Visible = true;
        }

        private void register_click(object sender, EventArgs e)
        {
            Register a = new Register();
            this.Visible=false;
            a.ShowDialog();
            this.Visible=true;
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            label_userevent.Visible = false;
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            label_passevent.Visible = false;
        }


        public bool login(string username, string password)
        {
            my_db db = new my_db();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            int type = chooseTypeUser();
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE Username = @User AND Password = @Pass  AND Type_User =@type", db.getConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@type", SqlDbType.Int).Value = type;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                int userID  = Convert.ToInt32(table.Rows[0]["Id"].ToString());
                int typeUser = Convert.ToInt32(table.Rows[0]["Type_User"].ToString());
                GlobalData.SetGlobalUserID(userID);
                GlobalData.SetGlobalUserType(typeUser);

                return true;
            }
            else
            {

                return false;
            }
        }
        private int chooseTypeUser()
        {
            int type = 1;
            if (rBtnHR.Checked)
            {
                type = 2;
            }
            return type;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
