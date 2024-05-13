using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Score
{
    public partial class FormAddScore : Form
    {
        public FormAddScore()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            richTextBox_des.Text = "";
            textBox_score.Text = "";

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    if (Isnum(textBox_score.Text))
                    {
                        double scorevalue = Convert.ToDouble(textBox_score.Text);
                        if (scorevalue >= 0 && scorevalue <= 10)
                        {
                            int semester = Convert.ToInt32(cBoxSemeter.SelectedValue);
                            int courseID = Convert.ToInt32(comboBox_select.SelectedValue.ToString());
                            int studentId = Convert.ToInt32(textBox_id.Text);

                            string description = richTextBox_des.Text;


                            if (!score.studentScoreExists(courseID, studentId) == true)
                            {
                                if (score.insertScorse(studentId, courseID, scorevalue, description))
                                {
                                    MessageBox.Show("Score Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    // Sử dụng luôn mã lớp học thay vì khai báo thêm 1 biến name
                                    string courseName = comboBox_select.Text;
                                    DVGCourse.DataSource = score.getStudentsScoreBySemester(semester, courseName);
                                }
                                else
                                {

                                    
                                    MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                        }
                        else
                        {
                            MessageBox.Show("The Score Must Be Between 0 and 10 marks", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Scores must be numbers", "Error Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Score/Description is not NULL", "Edit Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormAddScore_Load(object sender, EventArgs e)
        {

            //Semester
            cBoxSemeter.DisplayMember = "Semester";
            cBoxSemeter.ValueMember = "Semester";
            cBoxSemeter.Enabled = true;
            cBoxSemeter.DataSource = course.getAllSemester();

            // populate the datagridview with students data (id, first name, last name)
            SqlCommand command = new SqlCommand("SELECT Id, FirstName, LastName FROM Student");
            dataGridView1.DataSource = student.getStudent(command);




        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Isnum(string pValue)
        {
            Regex isValidInput = new Regex(@"^[0-9]*\.*[0-9]+$");
            if (!isValidInput.IsMatch(pValue))
            {
                return false;

            }
            return true;
        }
        private bool verif()
        {
            if ((textBox_score.Text.Trim() == "") || (richTextBox_des.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cBoxSemeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(cBoxSemeter.SelectedValue.ToString());

            comboBox_select.SelectedItem = null;
            comboBox_select.DisplayMember = "Label";
            comboBox_select.ValueMember = "Id";
            
            comboBox_select.DataSource = course.getAllCoursebySemester(semester);

        }

        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int semester = Convert.ToInt32(cBoxSemeter.SelectedValue.ToString());
                string courseName = comboBox_select.Text;

                DVGCourse.DataSource = score.getStudentsScoreBySemester(semester, courseName);

            }
            catch (Exception)
            {

                MessageBox.Show("Null ComboBox Course");
            }
        }
    }
}
