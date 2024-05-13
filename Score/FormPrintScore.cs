using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Score.Print;

namespace WindowsFormsApp1.Score
{
    public partial class FormPrintScore : Form
    {
        public FormPrintScore()
        {
            InitializeComponent();
        }

        private void printStudentInCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildPrintCourse());
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void printScoreStu_Click(object sender, EventArgs e)
        {
            openChildForm(new ChildPrintStudent());
        }
    }
}
