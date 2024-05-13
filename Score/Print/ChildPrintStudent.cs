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
    public partial class ChildPrintStudent : Form
    {
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        SCORE score = new SCORE();
        public ChildPrintStudent()
        {
            InitializeComponent();
        }

        private void ChildPrintStudent_Load(object sender, EventArgs e)
        {
            comboBoxStudent.SelectedItem = null;
            comboBoxStudent.DisplayMember = "IdStudent";
            comboBoxStudent.ValueMember = "IdStudent";
            comboBoxStudent.DataSource = student.getStudent(new SqlCommand("SELECT IdStudent FROM Score GROUP BY IdStudent"));
            int idStudent = Convert.ToInt32(comboBoxStudent.SelectedValue);
            fillDataGridviewScoreCourse(idStudent);
        }
        public void fillDataGridviewScoreCourse(int idStudent)
        {

            dataGridViewPrint.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridViewPrint.RowTemplate.Height = 80;
            dataGridViewPrint.DataSource = score.ScoreOfStudent(idStudent);

            
            dataGridViewPrint.AllowUserToAddRows = false;
            //dataGridView1.DefaultCellStyle.Format = "yyyy-dd-MM";
            dataGridViewPrint.Columns[0].HeaderText = "Mã Học Sinh";

            dataGridViewPrint.Columns[1].HeaderText = "Tên";
            dataGridViewPrint.Columns[2].HeaderText = "Họ và Tên Lót";
            dataGridViewPrint.Columns[3].HeaderText = " Mã Lớp";
            dataGridViewPrint.Columns[4].HeaderText = "Tên Lớp";
            dataGridViewPrint.Columns[5].HeaderText = "Điểm";
            dataGridViewPrint.Columns[6].HeaderText = "Mô Tả";


        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idStudent = Convert.ToInt32(comboBoxStudent.SelectedValue);
            fillDataGridviewScoreCourse(idStudent);
        }

        private void printWord_Click(object sender, EventArgs e)
        {
            try
            {
                PrintWord printWord = new PrintWord();
                printWord.ExportScoreStudentWord(dataGridViewPrint);
                MessageBox.Show("File export successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed!\n" + ex.Message);

            }
        }

        private void btnPrintPDF_Click(object sender, EventArgs e)
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
                            printPDF.exportScoreStudentPDF(sfd.FileName, dataGridViewPrint);
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
