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
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1
{
    public partial class ResetPassword : Form
    {
       my_db db = new my_db();
        string EmailName = sendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRessetPass.Text == "" || txtResetPassVer.Text == "")
            {
                MessageBox.Show("Please fill in the gap!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtRessetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("UPDATE login SET [password] = '" + txtResetPassVer.Text+ " ' Where Email = '" + EmailName +"'",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reset successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                this.Visible = true;
                loginForm.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("The new password do not match so enter same password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
