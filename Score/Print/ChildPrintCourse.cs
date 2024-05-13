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
using WindowsFormsApp1.Print;

namespace WindowsFormsApp1.Score.Print
{
    public partial class ChildPrintCourse : Form
    {
        public ChildPrintCourse()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        SCORE score = new SCORE();
        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inCourese = Convert.ToInt32(comboBoxCourse.SelectedValue); ;
            fillDataGridviewScoreCourse( inCourese);
        }

        private void ChildPrintCourse_Load(object sender, EventArgs e)
        {
            comboBoxCourse.SelectedItem = null;
            comboBoxCourse.DisplayMember = "Label";
            comboBoxCourse.ValueMember = "Id";
            comboBoxCourse.DataSource = course.getAllCourse();
            int inCourese = Convert.ToInt32(comboBoxCourse.SelectedValue); ;
            fillDataGridviewScoreCourse(inCourese);
        }
        public void fillCombo(int index = 0, string cmd = "SELECT * FROM Course")
        {

            comboBoxCourse.DisplayMember = "Label";
            comboBoxCourse.ValueMember = "Id";
            comboBoxCourse.DataSource = course.getAllCourse(cmd);

            comboBoxCourse.SelectedIndex = index;
        }
        public void fillDataGridviewScoreCourse(int inCourese)
        {

            dataGridViewPrint.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridViewPrint.RowTemplate.Height = 80;
            dataGridViewPrint.DataSource = score.ScoreInCourse(inCourese);
            //cột 7 là ảnh đổ từ database
            picol = (DataGridViewImageColumn)dataGridViewPrint.Columns[5];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewPrint.AllowUserToAddRows = false;
            //dataGridView1.DefaultCellStyle.Format = "yyyy-dd-MM";
            dataGridViewPrint.Columns[0].HeaderText = "Mã Học Sinh";

            dataGridViewPrint.Columns[1].HeaderText = "Tên";
            dataGridViewPrint.Columns[2].HeaderText = "Họ và Tên Lót";
            dataGridViewPrint.Columns[3].HeaderText = "Điểm";
            dataGridViewPrint.Columns[4].HeaderText = "Mô Tả";
            dataGridViewPrint.Columns[5].HeaderText = "Hình Ảnh";

        }
        //public void fillDataGridview(SqlCommand cmd)
        //{

        //    dataGridViewPrint.ReadOnly = true;
        //    DataGridViewImageColumn picol = new DataGridViewImageColumn();
        //    dataGridViewPrint.RowTemplate.Height = 80;
        //    dataGridViewPrint.DataSource = student.getStudent(cmd);
        //    //cột 7 là ảnh đổ từ database
        //    picol = (DataGridViewImageColumn)dataGridViewPrint.Columns[7];
        //    picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        //    dataGridViewPrint.AllowUserToAddRows = false;
        //    //dataGridView1.DefaultCellStyle.Format = "yyyy-dd-MM";
        //    dataGridViewPrint.Columns[0].HeaderText = "Mã Học Sinh";

        //    dataGridViewPrint.Columns[1].HeaderText = "Tên";
        //    dataGridViewPrint.Columns[2].HeaderText = "Họ và Tên Lót";
        //    dataGridViewPrint.Columns[3].HeaderText = "Ngày Sinh";
        //    dataGridViewPrint.Columns[4].HeaderText = "Giới Tính";
        //    dataGridViewPrint.Columns[5].HeaderText = "Số Điện Thoại";
        //    dataGridViewPrint.Columns[6].HeaderText = "Địa Chỉ";
        //    dataGridViewPrint.Columns[7].HeaderText = "Hình Ảnh";
        //    dataGridViewPrint.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";

            
        //}

        private void printWord_Click(object sender, EventArgs e)
        {
            try
            {
                PrintWord printWord = new PrintWord();
                printWord.ExportWord(dataGridViewPrint);
                MessageBox.Show("File export successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed!\n" + ex.Message);

            }
            
        }

        private void printPDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrint.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PrintPDF printPDF = new PrintPDF();
                            printPDF.exportScoreCoursePDF(sfd.FileName, dataGridViewPrint);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
