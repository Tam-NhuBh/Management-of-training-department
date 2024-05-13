using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SpashForm : Form
    {
        public SpashForm()
        {
            InitializeComponent();
        }

        private void SpashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.progressBar1.Maximum= 21;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (progressBar1.Value > 20)
            {
                LoginForm login = new LoginForm();
                
                timer1.Stop();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            else
                this.progressBar1.Value += 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
