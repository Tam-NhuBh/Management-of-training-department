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

namespace WindowsFormsApp1
{
    public partial class EdiCourseForm : Form
    {
        public EdiCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();

        private void EdiCourseForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            comboBox1.DisplayMember = "Label";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = course.getAllCourse();



        }
        public void fillCombo(int index)
        {
            
            comboBox1.DisplayMember = "Label";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = course.getAllCourse();

            comboBox1.SelectedIndex = index;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                
                txtName.Text = table.Rows[0][1].ToString();
                numericUpDownkihoc.Value = Int32.Parse(table.Rows[0][2].ToString());
                numericUpDownHours.Value = Int32.Parse(table.Rows[0][3].ToString());
                rTxtDecription.Text = table.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int IdCourse = Convert.ToInt32(comboBox1.SelectedValue);
                    if (IdCourse > 0)
                    {
                        // update the selected course
                        string name = txtName.Text;
                        int hrs = (int)numericUpDownHours.Value;
                        string descr = rTxtDecription.Text;

                        int kihoc = (int)numericUpDownkihoc.Value;

                        if (course.CheckCourseName(name, kihoc, IdCourse) == true)
                        {
                            if (course.UpdateCourse(IdCourse, name, kihoc, hrs, descr))
                            {
                                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                fillCombo(comboBox1.SelectedIndex);
                            }
                            else
                            {
                                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                            MessageBox.Show("This course name exists in semester " + kihoc, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show("Id Course Is A Number Greater Than Zero", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }




                }
                else
                {
                    MessageBox.Show("The All Field Is Not NULL", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("No Course Selected", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if ( (txtName.Text.Trim() == "") || (rTxtDecription.Text.Trim() == ""))
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
