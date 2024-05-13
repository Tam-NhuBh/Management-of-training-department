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
using WindowsFormsApp1.Score;

namespace WindowsFormsApp1.HR
{
    public partial class FullContact : Form
    {
        HRClass hrClass = new HRClass();
        private const string getall = "all";
        private const int teachUserScore = 1;
        public FullContact()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            fillDVGContact();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fillDVGContact(string idGroup = getall)
        {

            if(idGroup == getall)
            {
                int idHr = GlobalData.GlobalUserID;
                
                
                DVGContact.DataSource = hrClass.GetAllContactofHR(idHr);
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)DVGContact.Columns["pic"];
                picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                //getALL
            }
            else
            {
                
                DVGContact.DataSource = hrClass.GetAllContactofGroup(idGroup);
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)DVGContact.Columns["pic"];
                picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                //Get Only
            }
        }
        private void filllistBox()
        {
            int idHr = GlobalData.GlobalUserID;
            DataTable dt = hrClass.getAllGroupbyIdHR(idHr);
            lstGroup.Items.Clear();

            if (dt.Rows.Count != 0)
            {
                lstGroup.DataSource = dt;
                lstGroup.DisplayMember = "name";
                lstGroup.ValueMember = "name";

            }
            else
            {
                lstGroup.Text = "This employee does not manage any department yet";
            }
        }

        private void FullContact_Load(object sender, EventArgs e)
        {
            filllistBox();
            fillDVGContact();
        }

        



        private void DVGContact_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int inTeacher = Convert.ToInt32(DVGContact.CurrentRow.Cells[0].Value.ToString());
                FormManageScore manageScore = new FormManageScore();
                manageScore.setidTeacher(inTeacher);

                manageScore.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("DVG is NUll");
            }
        }

        private void lstGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstGroup.Items.Count != 0)
                {
                    string Value = lstGroup.SelectedValue.ToString();
                    fillDVGContact(Value);
                }
            
            }
            catch (Exception)
            {
                MessageBox.Show("List Box NULL");
            }
            
        }


        //private void ShowGroupToList(DataTable dataTable, ListBox lstGroup)
        //{
        //    // Show cả hai mã và tên được không
        //    for (int i = 0; i < dataTable.Rows.Count; i++)
        //    {
        //        lstGroup.Items.Add(dataTable.Rows[i][1]);
        //    }
        //}

    }
}
