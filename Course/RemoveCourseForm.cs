using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class RemoveCourseForm : Form
    {
        COURSE course = new COURSE();
        string cotID = "Ma Khoa Hoc";
        string cotName = "Ten Lop Hoc";
        string cotHour = "So Luong Gio";
        string cotMoTa = "Mo ta";
        string coutKihoc = "Hoc Ki";

        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int courseld = Convert.ToInt32(textBoxID.Text);
                COURSE course = new COURSE();
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseld))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                            fillDataGridview();

                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
                
            
        }

        private void RemoveCourseForm_Load(object sender, EventArgs e)
        {
            fillDataGridview();
        }
        public void fillDataGridview(string cmd = "SELECT * FROM Course")
        {

            dataGridViewCourse.ReadOnly = true;
            dataGridViewCourse.RowTemplate.Height = 80;
            dataGridViewCourse.DataSource = course.getAllCourse(cmd);


            //int index = Convert.ToInt32(dataGridViewCourse.CurrentRow.Index + 1);
            //dataGridViewCourse.Rows[index].Select = true;
            dataGridViewCourse.Columns[0].HeaderText = cotID;
            dataGridViewCourse.Columns[1].HeaderText = cotName;
            dataGridViewCourse.Columns[2].HeaderText = coutKihoc;
            dataGridViewCourse.Columns[3].HeaderText = cotHour;
            dataGridViewCourse.Columns[4].HeaderText = cotMoTa;

            label_total.Text = "Total Course: " + (dataGridViewCourse.Rows.Count);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fillDataGridview();
        }

        private void dataGridViewCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewCourse.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridViewCourse_DoubleClick(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewCourse.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
