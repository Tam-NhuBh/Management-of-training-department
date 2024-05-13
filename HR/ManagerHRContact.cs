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

namespace WindowsFormsApp1.HR
{
    public partial class ManagerHRContact : Form
    {
        HRClass HrCourse = new HRClass();
        public ManagerHRContact()
        {
            InitializeComponent();
        }

        private void ManagerHRContact_Load(object sender, EventArgs e)
        {
            fillDVGCourseNeed();

        }
        private void fillDVGCourseNeed()
        {

            //Chỉ hiển thị danh sách của giáo viên do HR quản lí    
            DVGCourseNTeacher.DataSource = HrCourse.GetAllCorseNTeacher();
        }

        private void listBoxCurrentCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDeleteCourse.Text = listBoxCurrentCourse.SelectedItem.ToString();
            tbOldCourse.Text = listBoxCurrentCourse.SelectedItem.ToString();
        }

        private void DVGCourseNTeacher_Click(object sender, EventArgs e)
        {
            txbNewCourse.Text = DVGCourseNTeacher.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbOldCourse.Text.Trim() != "" && txbNewCourse.Text.Trim() != "")
            {
                int idTeach = Convert.ToInt32(lvIdContact.Text);
                if (HrCourse.TransferCourse(tbOldCourse.Text, txbNewCourse.Text, idTeach))
                {
                    fillDVGCourseNeed();
                    listBoxCurrentCourse.Items.Clear();
                    DataTable dt = HrCourse.getAllCoursebyTeach(Convert.ToInt32(idTeach));
                    ShowCourseToList(dt, listBoxCurrentCourse);
                    MessageBox.Show("The teacher changed the course", "Transfer Course");
                }
                else
                {
                    MessageBox.Show("The teacher failed to convert the course successfully", "Transfer Course");
                }
            }
            else
            {
                MessageBox.Show("Select the Course to transfer at ListBox and DVG", "Transfer Course");
            }
        }
        private void ShowCourseToList(DataTable dataTable, ListBox lstBandau)
        {

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                lstBandau.Items.Add(dataTable.Rows[i]["Id"]);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbDeleteCourse.Text.Trim() != "" )
            {
                if (HrCourse.DeleteCourseOfTeach(tbDeleteCourse.Text))
                {
                    int idTeach = Convert.ToInt32(lvIdContact.Text);
                    fillDVGCourseNeed();
                    listBoxCurrentCourse.Items.Clear();
                    DataTable dt = HrCourse.getAllCoursebyTeach(Convert.ToInt32(idTeach));
                    if(dt != null)
                    {
                        ShowCourseToList(dt, listBoxCurrentCourse);
                    }
                    else
                    {
                        listBoxCurrentCourse.Items.Clear();
                    }
                    MessageBox.Show("The teacher is no longer in charge of the subject", "Delete Course");
                }
                else
                {
                    MessageBox.Show("Error Delete Course!!!", "Delete Course");
                }
            }
            else
            {
                MessageBox.Show("Select the Course to Delete at ListBox");
            }
        }
    }
}
