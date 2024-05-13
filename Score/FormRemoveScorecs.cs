using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Score
{
    public partial class FormRemoveScorecs : Form
    {
        public FormRemoveScorecs()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        my_db mydb = new my_db();
        
        private void FormRemoveScorecs_Load(object sender, EventArgs e)
        {
            
                dataGridView1.DataSource = score.getStudentsScore();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            // remove the selected score
            int studentId = int.Parse(dataGridView1.CurrentRow.Cells["IdStudent"].Value.ToString());
            int courseId = int.Parse(dataGridView1.CurrentRow.Cells["IdCourse"].Value.ToString());

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
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            SqlCommand query = new SqlCommand("SELECT Score.IdStudent, Student.FirstName, Student.LastName, Score.IdCourse, COURSE.Label, COURSE.Semester , Score.Score, Score.Description FROM Student INNER JOIN Score ON Student.Id = Score.IdStudent INNER JOIN Course ON Score.IdCourse = COURSE.Id WHERE concat(Score.IdStudent, Score.IdCourse, COURSE.Label, Student.FirstName, Student.LastName) LIKE'%" + txbSearch.Text + "%'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(query);
            DataTable table = new DataTable();
            adapter.Fill(table);
            try
            {
                if (String.IsNullOrEmpty(txbSearch.Text) != true)
                {
                    dataGridView1.DataSource = table;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No Record To Search!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentsScore();
        }
    }
}
