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

namespace WindowsFormsApp1.Student
{
    public partial class ErollCourseForm : Form
    {
        public ErollCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        public String listCourse { get; set; }
        public int soluongmon { get; set; } = 0;
        private void btTraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.SelectedItems.Count; //Tong so muc duoc chon
            for (int i = 0; i <= n - 1; i++)
            {
                string idcourse = getIdCourseByNameAngSemester(lstBandau.SelectedItems[i].ToString());
                if (isNotExitID(idcourse))
                {
                    lstKetqua.Items.Add(idcourse);
                }
                
            }
                
            while (lstBandau.SelectedIndices.Count != 0)
            {
                lstBandau.Items.RemoveAt(lstBandau.SelectedIndices[0]);
            }
        }
        private string getIdCourseByNameAngSemester(string nameCourse)
        {
            int semester = Convert.ToInt32(comboBox1.Text);
            string idCourse = course.getCourseIDByNameAndSemester(nameCourse, semester).ToString();
            return idCourse;
        }
        private bool isNotExitID(string idcourse)
        {
            int n = lstKetqua.Items.Count;
            for (int j = 0; j < n; j++)
            {
                if (idcourse == lstKetqua.Items[j].ToString())
                {
                    return false;
                }

            }
            return true;
        }
        private void btTatcatraisangphai_Click(object sender, EventArgs e)
        {
            int n = lstBandau.Items.Count;
            for (int i = 0; i <= n - 1; i++)
            {
                string idcourse = getIdCourseByNameAngSemester(lstBandau.Items[i].ToString());
                if (isNotExitID(idcourse))
                {
                    lstKetqua.Items.Add(idcourse);
                }
            }
                
            for (int j = n - 1; j >= 0; j--)
                lstBandau.Items.Clear();
        }

        private void btPhaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; //Tong so muc duoc chon
            
            while (lstKetqua.SelectedIndices.Count != 0)
            {
                lstKetqua.Items.RemoveAt(lstKetqua.SelectedIndices[0]);
            }
        }

        private void btTatcaphaisangtrai_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            
            for (int j = n - 1; j >= 0; j--)
                lstKetqua.Items.Clear();
        }

        private void ErollCourseForm_Load(object sender, EventArgs e)
        {
            
        }
        private void ShowCourseToList(DataTable dataTable, ListBox lstBandau)
        {

            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                lstBandau.Items.Add(dataTable.Rows[i][1]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kihoc = Convert.ToInt32( comboBox1.GetItemText(comboBox1.SelectedItem));
            DataTable dt = course.getAllCoursebySemester(kihoc);
            lstBandau.Items.Clear();

            if (dt.Rows.Count != 0)
            {
                lbPhanHoi.Text = "Chon mon hoc can dang ki";
                ShowCourseToList(dt, lstBandau);
            }
            else
            {
                lbPhanHoi.Text = "Khong co mon hoc nao trong ki nay";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            soluongmon = lstKetqua.Items.Count;
            for (int j = 0; j < lstKetqua.Items.Count; j++)
            {
                if(j == 0)
                {
                    listCourse = lstKetqua.Items[j].ToString();
                }
                else
                    listCourse = listCourse + "," +lstKetqua.Items[j].ToString();
            }

            this.Close();
        }

        private void lstKetqua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstKetqua.SelectedIndex > -1)
            {
                if (lstKetqua.SelectedItems[0] != null)
                {
                    string iscourse = lstKetqua.SelectedItems[0].ToString();
                    lbNameCourse.Text = course.getNamebyIDCourse(iscourse);
                }
            }
            
                
            
            
        }
    }
}
