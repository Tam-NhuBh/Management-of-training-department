using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using WindowsFormsApp1.Model;
namespace WindowsFormsApp1
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        DGVPrinter printer = new DGVPrinter();
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            //điền dữ liệu từ dl students vào datagridview
            fillDataGridview(new SqlCommand("SELECT * FROM Student"));
        }
        //phương thức thực hiện điền dl vào datagridview
        public void fillDataGridview(SqlCommand cmd)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudent(cmd);
            //cột 7 là ảnh đổ từ database
            picol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.DefaultCellStyle.Format = "yyyy-dd-MM";
            dataGridView1.Columns[0].HeaderText = "Mã Học Sinh";

            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].HeaderText = "Họ và Tên Lót";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Giới Tính";
            dataGridView1.Columns[5].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[6].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[7].HeaderText = "Hình Ảnh";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";
            //hiển thị tổng sinh viên hiển thị trên datagridview
            label_total.Text = "Total students: " + dataGridView1.Rows.Count;
        }
        //hiển thị sv trên datagridview khi double click vào nó
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                RadioButtonFemale.Checked = true;
            }
            else
            {
                RadioButtonMale.Checked = true;
            }
            TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Replace(" ", "");
            TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxStudentImage.Image = Image.FromStream(picture);
            DataGridViewImageColumn imagecolumn = (DataGridViewImageColumn)dataGridView1.Columns[7];

        }
        //xóa hết các trường
        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            TextBoxLname.Text = "";
            TextBoxPhone.Text = "";
            TextBoxFname.Text = "";
            TextBoxAddress.Text = "";
            RadioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            PictureBoxStudentImage.Image = null;
        }


        private void btn_search_Click_Click(object sender, EventArgs e)
        {
            //ham concat trong sql noi 2 hay nhieu chuoi thanh 1 chuoi lon
            string query = "select * from Student WHERE concat(FirstName,LastName,Address) LIKE'%" + textBox_search.Text + "%'";
            SqlCommand cmd = new SqlCommand(query);
            fillDataGridview(cmd);
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            //duyệt ảnh trong mt của bạn
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            //dat ten
            svf.FileName = "Student_" + textBoxID.Text;
            //ktra xem picturebox co rong ko
            if (PictureBoxStudentImage.Image == null)
                MessageBox.Show("No Image In The PictureBox");
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image.Save(svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtID.Text) == true && IsNumber(TextBoxPhone.Text) == true)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    if (id > 0)
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

                            if (RadioButtonFemale.Checked)
                            {
                                gender = "Female";
                            }
                            if (student.CheckexistbyId(id) == true)
                            {
                                MemoryStream pic = new MemoryStream();
                                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                                if (student.insertStudent(id, fname, lname, bdate, gender, phone, address, pic)) // 
                                {
                                    fillDataGridview(new SqlCommand("SELECT * FROM Student"));
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtID.Text) == true && IsNumber(TextBoxPhone.Text) == true)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    if (id > 0)
                    {
                        string fname = TextBoxFname.Text;
                        string lname = TextBoxLname.Text;
                        DateTime bdate = dateTimePicker1.Value;
                        string phone = TextBoxPhone.Text;
                        string address = TextBoxAddress.Text;
                        string gender = "Male";
                        if (RadioButtonFemale.Checked)
                        {
                            gender = "Female";
                        }
                        MemoryStream pic = new MemoryStream();
                        int born_year = dateTimePicker1.Value.Year;
                        int this_year = DateTime.Now.Year;
                        if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                        {
                            MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                        {
                            MessageBox.Show(" Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillDataGridview(new SqlCommand("SELECT * FROM Student"));

                            txtID.Text = "";
                            TextBoxFname.Text = "";
                            TextBoxLname.Text = "";
                            TextBoxPhone.Text = "";
                            TextBoxAddress.Text = "";
                            dateTimePicker1.Value = DateTime.Now;
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

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtID.Text) == true && IsNumber(TextBoxPhone.Text) == true)
                {
                    int id = Convert.ToInt32(txtID.Text);
                    if (id > 0)
                    {
                        if (MessageBox.Show("Are you sure!!!", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (student.deteleStudent(id))
                            {
                                MessageBox.Show("Delete Completely", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fillDataGridview(new SqlCommand("SELECT * FROM Student"));

                                txtID.Text = "";
                                TextBoxFname.Text = "";
                                TextBoxLname.Text = "";
                                TextBoxPhone.Text = "";
                                TextBoxAddress.Text = "";
                                dateTimePicker1.Value = DateTime.Now;
                                PictureBoxStudentImage.Image = null;

                            }
                            else
                            {
                                MessageBox.Show("Delete not Completely, ID not exist", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show("Please fill in the information");
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            TextBoxLname.Text = "";
            TextBoxPhone.Text = "";
            TextBoxFname.Text = "";
            TextBoxAddress.Text = "";
            RadioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            PictureBoxStudentImage.Image = null;
        }
        bool verif()
        {
            if ((TextBoxFname.Text.Trim() == "") || (TextBoxLname.Text.Trim() == "") || (TextBoxPhone.Text.Trim() == "") || (TextBoxAddress.Text.Trim() == "") || (PictureBoxStudentImage.Image == null))
            {
                return false;

            }
            else
            {
                return true;
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
        //kiểm tra tên không được là số
        

        private void PrintPDF_Click(object sender, EventArgs e)
        {
            try
            {
                
                byte[] pic;
                pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);
                
                printer.Title = "List Student";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                      StringFormatFlags.NoClip;
                printer.TitleColor = Color.OrangeRed;
                printer.SubTitleColor = Color.DodgerBlue;
                printer.PageNumbers = false;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Tam Nhu"; printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView1);
            }
            catch (Exception)
            {

                MessageBox.Show("Can not print! Please try again!","Information");
            }
            
        }
    }
}
