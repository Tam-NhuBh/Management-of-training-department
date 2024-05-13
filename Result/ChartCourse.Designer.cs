namespace WindowsFormsApp1.Result
{
    partial class ChartCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartbyCourse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartbyCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // chartbyCourse
            // 
            chartArea1.Name = "ChartArea1";
            this.chartbyCourse.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartbyCourse.Legends.Add(legend1);
            this.chartbyCourse.Location = new System.Drawing.Point(21, 25);
            this.chartbyCourse.Name = "chartbyCourse";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Static";
            this.chartbyCourse.Series.Add(series1);
            this.chartbyCourse.Size = new System.Drawing.Size(731, 393);
            this.chartbyCourse.TabIndex = 5;
            this.chartbyCourse.Text = "chart1";
            // 
            // ChartCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartbyCourse);
            this.Name = "ChartCourse";
            this.Text = "ChartCourse";
            this.Load += new System.EventHandler(this.ChartCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartbyCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartbyCourse;
    }
}