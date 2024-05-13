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

namespace WindowsFormsApp1.Result
{
    public partial class StatisticResult : Form
    {
        SCORE scoure = new SCORE();
        Results result = new Results();

        public StatisticResult()
        {
            InitializeComponent();
        }


        private void StatisticResult_Load(object sender, EventArgs e)
        {
            SCORE score = new SCORE();
            DataTable dataTable = score.getAvgScoreByCourse();
            StatisticCourse.DataSource = dataTable;

            showGraph(StatisticCourse);
            
            showGraphResult();

            // Part Statistic by Result
            DataTable dtAllResult = result.getAllScore();
            calculation(dtAllResult);
        }
        public void showGraph(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {

                chartCourse.Series["Static"].Points.AddXY(dataGridView.Rows[i].Cells["Label"].Value, dataGridView.Rows[i].Cells["Average"].Value);
                chartCourse.Series["Static"].LegendText = "AVG Score By Course";
                //chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
        }
        
        public void showGraphResult()
        {

            double numPassCourse = Convert.ToDouble(labelPass.Text.Replace("%",""));
            double numHigh = Convert.ToDouble(labelHigh.Text.Replace("%", ""));
            double numCredit = Convert.ToDouble(labelCredit.Text.Replace("%", ""));

            double numFailCourse = Convert.ToDouble(labelFail.Text.Replace("%", ""));





            int i = 0;
            if(numFailCourse != 0.0)
            {
                chartRate.Series["Static"].Points.AddXY(numFailCourse + "%", numFailCourse);
                chartRate.Series["Static"].Points[i].LegendText = "Fail";
                chartRate.Series["Static"].Points[i].Color = Color.AntiqueWhite;
                i++;
            }
            if (numPassCourse != 0.0)
            {
                chartRate.Series["Static"].Points.AddXY(numPassCourse + "%", numPassCourse);
                chartRate.Series["Static"].Points[i].LegendText = "Pass";
                chartRate.Series["Static"].Points[i].Color = Color.Aqua;
                i++;
            }
            if (numCredit != 0.0)
            {
                chartRate.Series["Static"].Points.AddXY(numCredit + "%", numCredit);
                chartRate.Series["Static"].Points[i].LegendText = "Credit";
                chartRate.Series["Static"].Points[i].Color = Color.AliceBlue;
                i++;
            }
            if (numHigh != 0.0)
            {
                chartRate.Series["Static"].Points.AddXY(numHigh + "%", numHigh);
                chartRate.Series["Static"].Points[i].LegendText = "High";
                chartRate.Series["Static"].Points[i].Color = Color.BlueViolet;
                i++;
            }




            

            

            // chuyển thành biểu đồ tròn
            chartRate.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void chartCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChartCourse chartCourse = new ChartCourse();
            chartCourse.dvg = StatisticCourse;
            chartCourse.ShowDialog();
            this.Visible = true;

        }

        private void StatisticCourse_DoubleClick(object sender, EventArgs e)
        {
            int semester =Convert.ToInt32(StatisticCourse.CurrentRow.Cells["Semester"].Value);
            string nameCourse = StatisticCourse.CurrentRow.Cells["Label"].Value.ToString();
            DataTable dataTable = new DataTable();
            dataTable = result.getAllScoreInCSemester(semester, nameCourse);
            calculation(dataTable);
        }
        private void calculation(DataTable dtScore)
        {
            double pass = 0.0;
            double high = 0.0;
            double credit = 0.0;
            int numCount = dtScore.Rows.Count;
            if(numCount > 0)
            {
                foreach (DataRow row in dtScore.Rows)
                {
                    if (row["Score"].ToString() != "")
                    {
                        float score = Convert.ToInt32(row["Score"].ToString());
                        if (score >= 8)
                        {
                            high++;
                        }
                        else if (score >= 6.5)
                        {
                            credit++;
                        }
                        else if (score >= 5.0)
                        {
                            pass++;
                        }
                    }
                }

                double numPassCourse = (Math.Round((pass / numCount), 2)) * 100;
                double numHigh = (Math.Round((high / numCount), 2)) * 100;
                double numCredit = (Math.Round((credit / numCount), 2)) * 100;

                double numFailCourse = 100.0 - numHigh - numCredit - numPassCourse;

                labelHigh.Text = numHigh.ToString() + "%";
                labelCredit.Text = numCredit.ToString() + "%";
                labelPass.Text = numPassCourse.ToString() + "%";
                labelFail.Text = numFailCourse.ToString() + "%";
            }
            else
            {
                labelHigh.Text = "0%";
                labelCredit.Text = "0%";
                labelPass.Text = "0%";
                labelFail.Text = "0%";
            }
            

            foreach (var series in chartRate.Series)
            {
                series.Points.Clear();
            }
            showGraphResult();
        }


        private void labelbyResult_Click(object sender, EventArgs e)
        {
            // Part Statistic by Result
            DataTable dtAllResult = result.getAllScore();
            calculation(dtAllResult);
        }
    }
}
