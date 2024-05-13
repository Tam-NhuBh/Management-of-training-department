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
    public partial class ChooseContactofHR : Form
    {
        
        
        HRClass hRClass = new HRClass();
        public string idCtact { get; set; }
        public ChooseContactofHR()
        {
            InitializeComponent();
            
        }

        private void ChooseContactofHR_Load(object sender, EventArgs e)
        {
            int idHR = GlobalData.GlobalUserID;
            DVGContactOfHR.DataSource = hRClass.GetAllContactofHR(idHR);
            if(DVGContactOfHR.DataSource == null)
            {
                MessageBox.Show("You have not managed an employee yet", "Choose Contact");
            }
        }

        private void DVGContactOfHR_DoubleClick(object sender, EventArgs e)
        {
            idContact.Text = DVGContactOfHR.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void btnConfim_Click(object sender, EventArgs e)
        {
            idCtact = idContact.Text;
            this.Close();
        }
    }
}
