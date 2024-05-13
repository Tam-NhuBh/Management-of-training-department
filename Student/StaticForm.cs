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
    public partial class StaticForm : Form
    {
        public StaticForm()
        {
            InitializeComponent();
        }
        //color variables
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void StaticForm_Load(object sender, EventArgs e)
        {
            //lấy màu panel gốc bên form
            panTotalColor = panel_total.BackColor;
            panMaleColor = panel_male.BackColor;
            panFemaleColor = panel_female.BackColor;

            //hiển thị giá trị
            STUDENT student = new STUDENT();
            double toTalStudents = Convert.ToDouble(student.toTalStudent());
            double maleStudents = Convert.ToDouble(student.maleStudent());
            double femaleStudents = Convert.ToDouble(student.femaleStudent());

            //đếm %
            double malePercent = Math.Round(maleStudents * 100 / toTalStudents);
            double femalePercent = Math.Round(femaleStudents * 100 / toTalStudents);

            string m = malePercent.ToString();
            string f = femalePercent.ToString();


            //label_total.Text = "Total Students: " + toTalStudents.ToString();
            label_male.Text = "Male: " + malePercent.ToString() + "%";
            label_female.Text = "Female: " + femalePercent.ToString() + "%";

            static_Chart.Series["Static"].Points.AddXY(m + "%", malePercent);
            static_Chart.Series["Static"].Points.AddXY(f + "%", femalePercent);


            static_Chart.Series["Static"].Points[0].LegendText = "Male";
            static_Chart.Series["Static"].Points[0].Color = Color.AntiqueWhite;

            static_Chart.Series["Static"].Points[1].LegendText = "Female";
            static_Chart.Series["Static"].Points[1].Color = Color.Aqua;

            //chuyển thành biểu đồ tròn
            static_Chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

        }

        private void panel_total_MouseEnter(object sender, EventArgs e)
        {
            panel_total.BackColor = Color.AntiqueWhite;
            label_total.ForeColor = panTotalColor;
        }

        private void panel_total_MouseLeave(object sender, EventArgs e)
        {
            panel_total.BackColor = panTotalColor;
            label_total.ForeColor = Color.AntiqueWhite;
        }

        private void panel_male_MouseEnter(object sender, EventArgs e)
        {
            panel_male.BackColor = Color.AliceBlue;
            label_male.ForeColor = panMaleColor;
        }

        private void panel_male_MouseLeave(object sender, EventArgs e)
        {
            panel_male.BackColor = panMaleColor;
            label_male.ForeColor = Color.AliceBlue;
        }

        private void panel_female_MouseEnter(object sender, EventArgs e)
        {
            panel_female.BackColor = Color.BlueViolet;
            label_female.ForeColor = panFemaleColor;
        }

        private void panel_female_MouseLeave(object sender, EventArgs e)
        {
            panel_female.BackColor = panFemaleColor;
            label_female.ForeColor = Color.BlueViolet;
        }
    }
}
