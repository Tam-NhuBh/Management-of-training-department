using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1
{
    public partial class UpdateDeleteStudentForm : Form
    {
        STUDENT student = new STUDENT();
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnFindID_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && IsNumber(txtID.Text) == true)
            {
                int id =int.Parse(txtID.Text);
                SqlCommand command = new SqlCommand("Select Id, FirstName, LastName, BirthDate, Gender, Phone, Address, Picture From Student Where id = " + id);
                DataTable table = student.getStudent(command);
                if(table.Rows.Count > 0)
                {
                    txtfname.Text = table.Rows[0]["FirstName"].ToString();
                    txtlname.Text = table.Rows[0]["LastName"].ToString();
                    dtBdate.Value = (DateTime)table.Rows[0]["BirthDate"];
                    if (table.Rows[0]["Gender"].ToString() == "Famale")
                    {
                        checkFemale.Checked = true;
                    }
                    else
                    {
                        checkMale.Checked = true;
                    }
                    txtphone.Text = table.Rows[0]["Phone"].ToString().Replace(" ", "");
                    rtbaddress.Text = table.Rows[0]["address"].ToString();

                    byte[] pic;
                    pic = (byte[])table.Rows[0]["Picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage.Image = Image.FromStream(picture);

                }
                else
                {
                    MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                lableInfor.Text = "Please fill in the ID information";
            }
        }

        bool verif()
        {
            if ((txtfname.Text.Trim() == "") || (txtlname.Text.Trim() == "") || (rtbaddress.Text.Trim() == "") || (txtphone.Text.Trim() == "") || (PictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtID.Text) == true && IsNumber(txtphone.Text) == true)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    if (id > 0)
                    {
                        string fname = txtfname.Text;
                        string lname = txtlname.Text;
                        DateTime bdate = dtBdate.Value;
                        string phone = txtphone.Text;
                        string address = rtbaddress.Text;
                        string gender = "Male";
                        if (checkFemale.Checked)
                        {
                            gender = "Female";
                        }
                        MemoryStream pic = new MemoryStream();
                        int born_year = dtBdate.Value.Year;
                        int this_year = DateTime.Now.Year;
                        if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                        {
                            MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                        {
                            MessageBox.Show(" Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            

                            txtID.Text = "";
                            txtlname.Text = "";
                            txtfname.Text = "";
                            txtphone.Text = "";
                            rtbaddress.Text = "";
                            dtBdate.Value = DateTime.Now;
                            PictureBoxStudentImage.Image = null;

                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Id Student is A positive number", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Id and Phone is number", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in the ID information");
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
        //kiểm tra tên không được là số
        public bool IsCharacter(string pValue)
        {
            foreach (Char a in pValue)
            {
                if (!Char.IsLetter(a) && !(Char.IsWhiteSpace(a)))
                    return false;
            }
            return true;
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" )
            {
                int id = Convert.ToInt32(txtID.Text);
                if (MessageBox.Show("Are you sure!!!", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deteleStudent(id))
                    {
                        MessageBox.Show("Delete Completely", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                        txtfname.Text = "";
                        txtlname.Text = "";
                        txtphone.Text = "";
                        rtbaddress.Text = "";
                        dtBdate.Value = DateTime.Now;
                        PictureBoxStudentImage.Image = null;
                        int txtMaxInt = Convert.ToInt32(txtMax.Text.ToString());
                        txtMax.Text = (txtMaxInt - 1).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Delete not Completely", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                lableInfor.Text = "Please fill in the ID information";
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

        private void btnPrivious_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(txtVT.Text);
            int Max = Convert.ToInt32(txtMax.Text);
            if ((temp) <= 1)
            {
                MessageBox.Show("Not Completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPrivious.Enabled = false;
            }



            if (temp == Max)
            {

                btnNext.Enabled = false;
            }
            if (temp == 1)
            {
                btnPrivious.Enabled = false;

            }
            if (temp <= Max && temp - 1 != 0)
            {
                temp = temp - 1;
                txtVT.Text = (temp).ToString();

                SqlCommand command = new SqlCommand("Select * from Student");
                DataTable table = student.getStudent(command);
                txtID.Text = table.Rows[temp - 1]["Id"].ToString();
                txtfname.Text = table.Rows[temp - 1]["FirstName"].ToString();
                txtlname.Text = table.Rows[temp - 1]["LastName"].ToString();
                dtBdate.Value = (DateTime)table.Rows[temp - 1]["BirthDate"];
                if (table.Rows[temp - 1]["Gender"].ToString() == "Famale")
                {
                    checkFemale.Checked = true;
                }
                else
                {
                    checkMale.Checked = true;
                }
                txtphone.Text = table.Rows[temp - 1]["Phone"].ToString().Replace(" ", "");
                rtbaddress.Text = table.Rows[temp - 1]["address"].ToString();

                byte[] pic;
                pic = (byte[])table.Rows[temp - 1]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);


            }
            if (temp >= 1)
            {
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(txtVT.Text);
            int Max = Convert.ToInt32(txtMax.Text);
            if ((temp + 1) > Max)
            {
                MessageBox.Show("Not Completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext.Enabled = false;
            }
            
            if (temp   < Max)
            {
                btnPrivious.Enabled = true;
            }
            
            //if (temp == Max)
            //{

            //    btnNext.Enabled = false;
            //}
            if (temp == 0)
            {
                btnPrivious.Enabled = false;

            }
            if (temp <Max && temp >0  )
            {
                
                txtVT.Text = (temp+1).ToString();

                SqlCommand command = new SqlCommand("Select * from Student");
                DataTable table = student.getStudent(command);
                txtID.Text = table.Rows[temp]["Id"].ToString();
                txtfname.Text = table.Rows[temp ]["FirstName"].ToString();
                txtlname.Text = table.Rows[temp]["LastName"].ToString();
                dtBdate.Value = (DateTime)table.Rows[temp]["BirthDate"];
                if (table.Rows[temp]["Gender"].ToString() == "Famale")
                {
                    checkFemale.Checked = true;
                }
                else
                {
                    checkMale.Checked = true;
                }
                txtphone.Text = table.Rows[temp]["Phone"].ToString().Replace(" ", "");
                rtbaddress.Text = table.Rows[temp ]["address"].ToString();

                byte[] pic;
                pic = (byte[])table.Rows[temp]["Picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);

                
            }
            

        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(txtVT.Text);
            int Max = Convert.ToInt32(txtMax.Text);
            label_user.Text = GlobalData.GlobalUserID.ToString();
            if (temp == Max)
            {
                
                btnNext.Enabled = false;
            } 
            if(temp == 1)
            {
                btnPrivious.Enabled = false;
                
            }
            
            

        }

       
    }
}
