using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
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
    public partial class studentListForm : Form
    {
        
        STUDENT student = new STUDENT();
        public studentListForm()
        {
            InitializeComponent();
            DisplayData();

        }

        private void studentListForm_Load(object sender, EventArgs e)
        {
            //this.StudentTableAdapter.Fill(this.viduDBDataSet.std);
            DisplayData();
            
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.txtID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.txtfname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.txtlname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.dtBdate.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            updateDeleteStdF.txtVT.Text = (dataGridView1.CurrentRow.Index + 1).ToString();
            updateDeleteStdF.txtMax.Text = (dataGridView1.RowCount ).ToString();
            
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString()== "Female")
            {
                updateDeleteStdF.checkFemale.Checked = true;
            }
            else
            {
                updateDeleteStdF.checkMale.Checked =  true;
            }
            updateDeleteStdF.txtphone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Replace(" ", "");
            updateDeleteStdF.rtbaddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.PictureBoxStudentImage.Image = Image.FromStream(picture);
            this.Visible = false;
            updateDeleteStdF.ShowDialog();
            DisplayData();
            this.Visible = true;

        }
        //Display Data in DataGridView  
        //Display Data in DataGridView  
        public void DisplayData(string connet = "Select* from Student")
        {
            SqlCommand command = new SqlCommand(connet);
            dataGridView1.ReadOnly = true;
            
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudent(command);
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[0].HeaderText = "Mã Học Sinh";

            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].HeaderText = "Họ và Tên Lót";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Giới Tính";
            dataGridView1.Columns[5].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns[6].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[7].HeaderText = "Hình Ảnh";
            //((DateTime)row.Cells[4].Value).ToString("yyyy-dd-MM");
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayData();

        }

       

        
        //Clear Data  
        //private void ClearData()
        //{
        //    txt_Name.Text = "";
        //    txt_State.Text = "";
        //    ID = 0;
        //}
    }
}
