using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Result
{
    public partial class ChartCourse : Form
    {
        public DataGridView dvg { get; set; }
        public ChartCourse()
        {
            InitializeComponent();
        }

        private void ChartCourse_Load(object sender, EventArgs e)
        {
            showGraph(dvg);
        }
        public void showGraph(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {

                chartbyCourse.Series["Static"].Points.AddXY(dataGridView.Rows[i].Cells["Label"].Value, dataGridView.Rows[i].Cells["Average"].Value);
                chartbyCourse.Series["Static"].LegendText = "AVG Score By Course";
                //chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
        }
    }
}
