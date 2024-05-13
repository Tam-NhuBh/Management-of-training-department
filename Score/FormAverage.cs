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

namespace WindowsFormsApp1.Score
{
    public partial class FormAverage : Form
    {
        public FormAverage()
        {
            InitializeComponent();
        }
        private int idteach { get; set; } = 0;
        public void setIdTeach(int idTeach)
        {
            this.idteach = idTeach;
        }
        private void FormAverage_Load(object sender, EventArgs e)
        {
            SCORE score = new SCORE();

            // Hệ thống kì học và phân công giáo viên
            if (idteach == 0)
            {
                DataTable dataTable = score.getAvgScoreByCourse();
                dataGridView1.DataSource = dataTable;
            }
            else
            {
                DataTable dataTable = score.getAvgScoreByCourseOfTeach(idteach);
                dataGridView1.DataSource = dataTable;
            }
            

            showGraph(dataGridView1);
        }
        public void showGraph(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {

                
                chart.Series["Static"].Points.AddXY(dataGridView.Rows[i].Cells["Label"].Value, dataGridView.Rows[i].Cells["Average"].Value);
                chart.Series["Static"].LegendText = "Average Score By Course";
                //chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
        }
    }
}
