using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using WindowsFormsApp1.Model;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class sendCode : Form
    {
        string randomCode;
        public static string to;
        my_db mydb = new my_db();
        public sendCode()
        {
            InitializeComponent();
            txtVerCode.ForeColor = Color.LightGray;
            txtVerCode.Text = "Please enter your code";
            this.txtVerCode.Leave += new System.EventHandler(this.txtVerCode_Leave);
            this.txtVerCode.Enter += new System.EventHandler(this.txtVerCode_Enter);

            textEmail.ForeColor = Color.LightGray;
            textEmail.Text = "example@gmail.com";
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);

            label_codeevent.Visible = false;
            this.txtVerCode.Click += new System.EventHandler(this.txtVerCode_Click);
            label_emailevent.Visible = false;
            this.textEmail.Click += new System.EventHandler(this.textEmail_Click);
        }

        //check email có tồn tại trong database chưa
        public bool CheckEmail(string email)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE Email = @email", mydb.getConnection);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                //this EMAIL already exists
                return false;
                mydb.closeConnection();
            }
            else
            {

                return true;
                mydb.closeConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textEmail.Text == "example@gmail.com")
            {
                label_emailevent.Text = "Please provide Email";
                label_emailevent.Visible = true;
                return;
            }
            if (IsValidEmail(textEmail.Text)== false)
            {
                label_emailevent.Text = "Syntax Error";
                label_emailevent.Visible = true;
                return;
            }
            else if (textEmail.Text != "example@gmail.com")
            {
                if (CheckEmail(textEmail.Text) == false)
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(99999)).ToString();


                    MailMessage message = new MailMessage();
                    to = (textEmail.Text).ToString();
                    from = "20110431@student.hcmute.edu.vn";
                    pass = "26112001";
                    messageBody = "Your reset code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Your code: ";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); //SMTP là giao thức tiêu chuẩn để gửi email
                    smtp.EnableSsl = true;  //là 1 chứng chỉ bảo mật 
                                            //smtp.Port = 25; //cổng nhận gmail
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //thông qua mạng
                    smtp.Credentials = new NetworkCredential(from, pass); //hỗ trợ đăng nhập cho bạn

                    smtp.Send(message);
                    MessageBox.Show("Code send successfully");
                }
                else
                    MessageBox.Show("Email is not exit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtVerCode.Text == "Please enter your code")
            {
                label_codeevent.Text = "Please fill in the gap";
                label_codeevent.Visible = true;
                return;
            }
            if (randomCode == (txtVerCode.Text).ToString())
            {
                to = textEmail.Text;
                ResetPassword rp = new ResetPassword();
                this.Visible = false; //ẩn thôi chứ khum tắt
                rp.ShowDialog(); //show chạy song song khác với showDialog dừng chạy form hiện tại rồi mở form mà mình muốn mở
                this.Visible = true; //mở lại
            }
            else
            {
                MessageBox.Show("Invalid zip code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textEmail_Click(object sender, EventArgs e)
        {
            label_emailevent.Visible = false;

        }
        private void txtVerCode_Click(object sender, EventArgs e)
        {
            label_codeevent.Visible = false;

        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "example@gmail.com")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Black;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "example@gmail.com";
                textEmail.ForeColor = Color.Gray;
            }
        }

        private void txtVerCode_Enter(object sender, EventArgs e)
        {
            if (txtVerCode.Text == "Please enter your code")
            {
                txtVerCode.Text = "";
                txtVerCode.ForeColor = Color.Black;
            }
        }

        private void txtVerCode_Leave(object sender, EventArgs e)
        {
            if (txtVerCode.Text == "")
            {
                txtVerCode.Text = "Please enter your code";
                txtVerCode.ForeColor = Color.Gray;
            }
        }

        // Kiểm tra mail đúng chuẩn example123@gmail.com
        public bool IsValidEmail(string email)
        {
            Regex isValidInput = new Regex(@"^[a-zA-Z]*[0-9]*@gmail*\.com$");
            if (!isValidInput.IsMatch(email))
            {
                return false;

            }
            return true;
        }
    }
}
