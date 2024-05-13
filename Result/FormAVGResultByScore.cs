using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Print;

namespace WindowsFormsApp1.Result
{
    public partial class FormAVGResultByScore : Form
    {
        public FormAVGResultByScore()
        {
            InitializeComponent();
        }
        private int pass = 0;
        private int fail = 0;
        private List<int> listSemeter = new List<int>();
        my_db mydb = new my_db();
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fillDataGridviewStudent()
        {
            dataGridView1.DataSource = score.getStudentsScore();
        
        }

        public void fillDataGridview(int id)
        {
            DataTable tableScore = score.show(id);
            
            float sum = 0;

            for(int j= 0; j<tableScore.Rows.Count; j++) {
                float score = float.Parse(tableScore.Rows[j]["Score"].ToString());
                sum += score;
                if (score > 5.0) {
                    pass++;
                    tableScore.Rows[j]["Result"] = "Pass";
                }
                else
                {
                    fail++;
                    tableScore.Rows[j]["Result"] = "Fail";
                }
                int semester = Convert.ToInt32(tableScore.Rows[j]["Semester"].ToString());
                if (checkExitSemester(listSemeter, semester))
                {
                    listSemeter.Add(semester);
                }
            }
            
            float avgScore = (float)sum/(tableScore.Rows.Count);
            lbAVG.Text = Math.Round(avgScore,2).ToString();




            dataGridView1.DataSource = tableScore;
        }
        private bool checkExitSemester(List<int> list, int semester)
        {
            foreach (int i in list)
            {
                if (i == semester)
                {
                    return false;
                }
            }
            return true;
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_studentid.Text != "")
                {
                    button_print.Enabled = true;
                    int idStu = Convert.ToInt32(textBox_studentid.Text);
                    fillDataGridview(idStu);
                    // Tat cac lable
                }
                else
                {
                    MessageBox.Show("Please fill in the gap!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textBox_studentid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBox_fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBox_lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


            //byte[] pic;
            //pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            //MemoryStream picture = new MemoryStream(pic);
            //PictureBoxStudentImage.Image = Image.FromStream(picture);
            //DataGridViewImageColumn imagecolumn = (DataGridViewImageColumn)dataGridView1.Columns[7];

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            if(textBox_studentid.Text != ""&& TextBox_fname.Text !="" && TextBox_lname.Text != "")
            {
                try
                {
                    PrintWord printWord = new PrintWord();
                    string fullname = TextBox_fname.Text + " " + TextBox_lname.Text;
                    string idStudent = textBox_studentid.Text;
                    printWord.ExportScoreAStudentWord(dataGridView1, fullname, idStudent, lbAVG.Text, pass, fail, listSemeter);
                    MessageBox.Show("File export successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export failed!\n" + ex.Message);

                }
            }
            else
                MessageBox.Show("Fill Textbox Id, Last Name, First Name");

        }

        private void FormAVGResultByScore_Load(object sender, EventArgs e)
        {
            fillDataGridviewStudent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fillDataGridviewStudent();
            lbAVG.Text = "0";
            textBox_studentid.Text = "";
            TextBox_fname.Text = "";
            TextBox_lname.Text = "";
            button_print.Enabled = false;
        }
    }
}
