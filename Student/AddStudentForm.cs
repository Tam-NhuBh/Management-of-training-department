using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Student;

namespace WindowsFormsApp1
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtID.Text) == true && IsNumber(TextBoxPhone.Text) == true)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    if(id>0)
                    {
                        int born_year = dateTimePicker1.Value.Year;
                        int this_year = DateTime.Now.Year;
                        if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                        {
                            MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            STUDENT student = new STUDENT();

                            string fname = TextBoxFname.Text;
                            string lname = TextBoxLname.Text;
                            DateTime bdate = dateTimePicker1.Value;
                            string phone = TextBoxPhone.Text;
                            string address = TextBoxAddress.Text;
                            string gender = "Male";
                            string[] listcourse = ListCourse.Text.Split(',');
                            if (RadioButtonFemale.Checked)
                            {
                                gender = "Female";
                            }
                            if (student.CheckexistbyId(id) == true)
                            {
                                MemoryStream pic = new MemoryStream();
                                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                                if (student.insertStudent(id, fname, lname, bdate, gender, phone, address, pic, listcourse)) // 
                                {
                                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Student is exist", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool verif()
        {
            if((TextBoxFname.Text.Trim()== "") || (TextBoxLname.Text.Trim()== "")||(TextBoxAddress.Text.Trim()=="")||( TextBoxPhone.Text.Trim()=="")||(PictureBoxStudentImage.Image == null))
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
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        
        //Test xu li ngoai le khi cac o phia tren chua nhap dung du lieu
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtID.Text) == true && IsNumber(TextBoxPhone.Text) == true)
                {
                    ErollCourseForm eCourse = new ErollCourseForm();
                    this.Visible = false;
                    eCourse.txtID.Text = txtID.Text;
                    eCourse.txtName.Text = Convert.ToString(TextBoxFname.Text + " " + TextBoxLname.Text);
                    eCourse.ShowDialog();
                    ListCourse.Text = eCourse.listCourse;
                    ibSoluongCourse.Text = eCourse.soluongmon.ToString();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Id and Phone is number", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        
    }
}
