namespace WindowsFormsApp1.Result
{
    partial class StatisticResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartCourse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatisticCourse = new System.Windows.Forms.DataGridView();
            this.labelbyResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFail = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chartRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCredit = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticCourse)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistic by Course";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.chartCourse);
            this.panel1.Controls.Add(this.StatisticCourse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 503);
            this.panel1.TabIndex = 2;
            // 
            // chartCourse
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCourse.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCourse.Legends.Add(legend1);
            this.chartCourse.Location = new System.Drawing.Point(10, 293);
            this.chartCourse.Name = "chartCourse";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Static";
            this.chartCourse.Series.Add(series1);
            this.chartCourse.Size = new System.Drawing.Size(411, 193);
            this.chartCourse.TabIndex = 4;
            this.chartCourse.Text = "chart1";
            this.chartCourse.Click += new System.EventHandler(this.chartCourse_Click);
            // 
            // StatisticCourse
            // 
            this.StatisticCourse.AllowUserToAddRows = false;
            this.StatisticCourse.AllowUserToDeleteRows = false;
            this.StatisticCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StatisticCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StatisticCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticCourse.Location = new System.Drawing.Point(3, 107);
            this.StatisticCourse.Name = "StatisticCourse";
            this.StatisticCourse.ReadOnly = true;
            this.StatisticCourse.RowHeadersWidth = 51;
            this.StatisticCourse.RowTemplate.Height = 24;
            this.StatisticCourse.Size = new System.Drawing.Size(418, 180);
            this.StatisticCourse.TabIndex = 1;
            this.StatisticCourse.DoubleClick += new System.EventHandler(this.StatisticCourse_DoubleClick);
            // 
            // labelbyResult
            // 
            this.labelbyResult.AutoSize = true;
            this.labelbyResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelbyResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbyResult.ForeColor = System.Drawing.Color.IndianRed;
            this.labelbyResult.Location = new System.Drawing.Point(25, 50);
            this.labelbyResult.Name = "labelbyResult";
            this.labelbyResult.Size = new System.Drawing.Size(242, 34);
            this.labelbyResult.TabIndex = 3;
            this.labelbyResult.Text = "Statistic by Result";
            this.labelbyResult.Click += new System.EventHandler(this.labelbyResult_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelFail);
            this.panel2.Controls.Add(this.labelPass);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelbyResult);
            this.panel2.Controls.Add(this.chartRate);
            this.panel2.Controls.Add(this.labelCredit);
            this.panel2.Controls.Add(this.labelHigh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(478, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 503);
            this.panel2.TabIndex = 4;
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFail.Location = new System.Drawing.Point(190, 250);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(34, 25);
            this.labelFail.TabIndex = 9;
            this.labelFail.Text = "25";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(190, 203);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(34, 25);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fail:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Pass:";
            // 
            // chartRate
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRate.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRate.Legends.Add(legend2);
            this.chartRate.Location = new System.Drawing.Point(3, 293);
            this.chartRate.Name = "chartRate";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Static";
            this.chartRate.Series.Add(series2);
            this.chartRate.Size = new System.Drawing.Size(299, 193);
            this.chartRate.TabIndex = 5;
            this.chartRate.Text = "chart1";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(190, 154);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(34, 25);
            this.labelCredit.TabIndex = 3;
            this.labelCredit.Text = "25";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHigh.Location = new System.Drawing.Point(190, 107);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(34, 25);
            this.labelHigh.TabIndex = 2;
            this.labelHigh.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Credit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "High distinction:";
            // 
            // StatisticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "StatisticResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticResult";
            this.Load += new System.EventHandler(this.StatisticResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticCourse)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelbyResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView StatisticCourse;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCourse;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRate;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}