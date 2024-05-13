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
    public partial class FormManageScore : Form
    {
        public FormManageScore()
        {
            InitializeComponent();
        }
        my_db mydb = new my_db();
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        string data;
        

        public int idTeacher { get; private set; } = 0;
        public void setidTeacher(int type)
        {
            idTeacher = type;
        }
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Trim() != "")
            {
                int studentId = Convert.ToInt32(textBox_id.Text);
                int courseId = Convert.ToInt32(comboBox_select.SelectedValue.ToString());
                if (MessageBox.Show("Do You Want To delete This Score?", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (score.deleteScore(courseId, studentId))
                    {
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = score.getStudentsScore();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }



                int semester = Convert.ToInt32(cbSemester.SelectedValue.ToString());
                string courseName = comboBox_select.Text;
                dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseName);
            }
            else
            {
                MessageBox.Show("ID is not NULL", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormManageScore_Load(object sender, EventArgs e)
        {
            // populate the combobox with courses name
            data = "score";
            if (idTeacher == 0)
            {
                cbSemester.DisplayMember = "Semester";
                cbSemester.ValueMember = "Semester";
                cbSemester.Enabled = true;
                cbSemester.DataSource = course.getAllSemester();



                // populate the datagridview with students data (id, first name, last name)
                int semester = Convert.ToInt32(cbSemester.SelectedValue.ToString());
                string courseId = comboBox_select.Text;

                dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseId);
            }
            else
            {
                cbSemester.DisplayMember = "Semester";
                cbSemester.ValueMember = "Semester";
                cbSemester.Enabled = true;
                DataTable dt = course.getAllSemesterbyTeach(idTeacher);

                if (dt.Rows.Count > 0)
                {
                    cbSemester.DataSource = dt;
                    int semester = Convert.ToInt32(cbSemester.SelectedValue.ToString());
                    string courseName = comboBox_select.Text;

                    dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseName);
                }
                else
                {
                    button_showstu.Enabled = false;
                    button_showsco.Enabled = false;
                    button_reset.Enabled = false;
                    button_add.Enabled = false;
                    button_remove.Enabled = false;
                    button_edit.Enabled = false;
                    button_findscore.Enabled = false;
                    MessageBox.Show("The teacher does not teach any subject", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }

            }

        }

        private void button_showstu_Click(object sender, EventArgs e)
        {
            data = "student";
            SqlCommand cmd = new SqlCommand("SELECT ID as IdStudent, FirstName, LastName, Birthdate From Student");
            dataGridView1.DataSource = student.getStudent(cmd);
            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";
        }

        private void button_showsco_Click(object sender, EventArgs e)
        {
            data = "score";
            if (idTeacher == 0)
            {
                dataGridView1.DataSource = score.getStudentsScore();
            }
            else
            {
                int semester = Convert.ToInt32(cbSemester.SelectedValue.ToString());
                string courseName = comboBox_select.Text;

                dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseName);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_score.Text = "";
            richTextBox_des.Text = "";
            getDataFromDatagridview();
        }

        private void getDataFromDatagridview()
        {
            try
            {
                if(dataGridView1.DataSource != null)
                {
                    if (data == "student")
                    {
                        textBox_id.Text = dataGridView1.CurrentRow.Cells["IdStudent"].Value.ToString();
                        //dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy-dd-MM";

                    }
                    else if (data == "score")
                    {

                        textBox_id.Text = dataGridView1.CurrentRow.Cells["IdStudent"].Value.ToString();
                        textBox_score.Text = dataGridView1.CurrentRow.Cells["Score"].Value.ToString();
                        richTextBox_des.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("DVG is NULL", "Information");
            }
            
            
            
        }

        private void button_average_Click(object sender, EventArgs e)
        {
            FormAverage formAverage = new FormAverage();
            if(idTeacher != 0)
            {
                formAverage.setIdTeach(idTeacher);
            }
            this.Visible = false;

            formAverage.ShowDialog();
            this.Visible = true;
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
                            // Ki Hoc
                            int semester = Convert.ToInt32(cbSemester.SelectedValue);
                            int studentId = Convert.ToInt32(textBox_id.Text);
                            int courseId = Convert.ToInt32(comboBox_select.SelectedValue.ToString());

                            string description = richTextBox_des.Text;
                            
                            // check if a score is already asigned to this student in this course and semester
                            if (!score.studentScoreExists(courseId, studentId))
                            {
                                if (score.insertScorse(studentId, courseId, scorevalue, description))
                                {
                                    MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    string courseName = comboBox_select.Text;
                                    dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseName);
                                }
                                else
                                {

                                    // Cap nhap lai diem cua sinh vien trong lop do
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
                            MessageBox.Show("The Score Must Be Between 0 and 10 marks", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Scores must be numbers", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Score/Description is not NULL", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    if (Isnum(textBox_score.Text))
                    {
                        double scorevalue = Convert.ToDouble(textBox_score.Text);
                        if(scorevalue >= 0 && scorevalue <= 10)
                        {
                            int semester = Convert.ToInt32(cbSemester.SelectedValue);
                            int courseID = Convert.ToInt32(comboBox_select.SelectedValue.ToString());
                            int studentId = Convert.ToInt32(textBox_id.Text);

                            string description = richTextBox_des.Text;
                            

                            if (score.studentScoreExists(courseID, studentId) == true)
                            {
                                if (score.editScorse(courseID, studentId, scorevalue, description))
                                {
                                    MessageBox.Show("Score Updated", "Edit Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    string courseName = comboBox_select.Text;
                                    dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseName);
                                }
                                else
                                {
                                    MessageBox.Show("Score Not Updated", "Edit Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
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
            catch (Exception)
            {

                MessageBox.Show("No Score Selected", "Edit Score", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBox_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                    int semester = Convert.ToInt32(cbSemester.SelectedValue.ToString());
                    string courseId = comboBox_select.Text;

                    dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseId);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Null ComboBox Course");
            }
        }
        
        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_score.Text = "";
            richTextBox_des.Text = "";

            int semester = Convert.ToInt32(cbSemester.SelectedValue.ToString());
            string courseName = comboBox_select.Text;

            dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseName);
        }


        // Sửa đối với số thực
        public bool Isnum(string pValue)
        {
            Regex isValidInput = new Regex(@"^[0-9]*\.*[0-9]+$");
            if (!isValidInput.IsMatch(pValue))
            {
                return false;

            }
            return true;

        }
        // Dieu chinh voi phan Teacher
        private void button_findscore_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (idTeacher == 0)
            {
                SqlCommand query = new SqlCommand("SELECT Score.IdStudent, Student.FirstName, Student.LastName, Score.IdCourse, COURSE.Label, COURSE.Semester , Score.Score, Score.Description FROM Student INNER JOIN Score ON Student.Id = Score.IdStudent INNER JOIN Course ON Score.IdCourse = COURSE.Id WHERE concat(Score.IdStudent, Score.IdCourse, COURSE.Label, Student.FirstName, Student.LastName) LIKE'%" + textBox_findscore.Text + "%'", mydb.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(query);

                adapter.Fill(table);
            }
            else
            {
                SqlCommand query = new SqlCommand("SELECT Score.IdStudent, Student.FirstName, Student.LastName, Score.IdCourse, COURSE.Label, COURSE.Semester , Score.Score, Score.Description FROM Student INNER JOIN Score ON Student.Id = Score.IdStudent INNER JOIN Course ON Score.IdCourse = COURSE.Id WHERE COURSE.idTeacher = @idTeach and  concat(Score.IdStudent, Score.IdCourse, COURSE.Label, Student.FirstName, Student.LastName) LIKE'%" + textBox_findscore.Text + "%'", mydb.getConnection);
                query.Parameters.Add("@idTeach", SqlDbType.Int).Value = idTeacher;
                SqlDataAdapter adapter = new SqlDataAdapter(query);

                adapter.Fill(table);
            }
            try
            {
                if (String.IsNullOrEmpty(textBox_findscore.Text) != true)
                {
                    dataGridView1.DataSource = table;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Record To Search!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTypeGetCourse.Text = "By Semester";
            int semester = Convert.ToInt32(cbSemester.SelectedValue.ToString());

            comboBox_select.SelectedItem = null;
            comboBox_select.DisplayMember = "Label";
            comboBox_select.ValueMember = "Id";
            if (idTeacher == 0)
            {

                comboBox_select.DataSource = course.getAllCoursebySemester(semester);
            }
            else
            {
                comboBox_select.DataSource = course.getAllCoursebySemesterOfTeach(idTeacher,semester);
            }

            //string courseId = comboBox_select.Text;

            //dataGridView1.DataSource = score.getStudentsScoreBySemester(semester, courseId);

        }

        private bool verif()
        {
            if ((textBox_score.Text.Trim() == "") || (richTextBox_des.Text.Trim() == "") )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
