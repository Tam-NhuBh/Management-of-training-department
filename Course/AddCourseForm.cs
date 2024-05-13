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

namespace WindowsFormsApp1
{
    public partial class AddCourseForm : Form
    {

        public AddCourseForm()
        {
            InitializeComponent();
        }
        my_db mydb = new my_db();
        COURSE course = new COURSE();
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                if (IsNumber(txtId.Text))
                {
                    int IdCourse = Convert.ToInt32(txtId.Text);
                    if(IdCourse > 0)
                    {
                        int kihoc = (int)numericUpDownkihoc.Value;
                        string courselabel = txtName.Text;
                        int hours = (int)numericUpDownHours.Value;
                        string description = rTxtDecription.Text;
                        if (course.CheckIDCourse(IdCourse))
                        {
                            if (course.CheckCourseName(courselabel, kihoc, IdCourse) == true)
                            {
                                if (course.insertCourse(IdCourse, courselabel, kihoc, hours, description))
                                {
                                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                                MessageBox.Show("This course name already exists in semester "+ kihoc , "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("This course id already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Id Course Is A Number Greater Than Zero", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Id Course Is A Number", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else
            {
                MessageBox.Show("The All Field Is Not NULL", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
        private bool verif()
        {
            if ((txtId.Text.Trim() == "") || (txtName.Text.Trim() == "") || (rTxtDecription.Text.Trim() == ""))
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
