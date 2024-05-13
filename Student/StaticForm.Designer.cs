namespace WindowsFormsApp1
{
    partial class StaticForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label_female = new System.Windows.Forms.Label();
            this.panel_total = new System.Windows.Forms.Panel();
            this.label_total = new System.Windows.Forms.Label();
            this.label_male = new System.Windows.Forms.Label();
            this.panel_female = new System.Windows.Forms.Panel();
            this.panel_male = new System.Windows.Forms.Panel();
            this.static_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_total.SuspendLayout();
            this.panel_female.SuspendLayout();
            this.panel_male.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.static_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label_female
            // 
            this.label_female.AutoSize = true;
            this.label_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_female.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_female.Location = new System.Drawing.Point(4, 79);
            this.label_female.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_female.Name = "label_female";
            this.label_female.Size = new System.Drawing.Size(166, 29);
            this.label_female.TabIndex = 2;
            this.label_female.Text = "Female: 50%";
            // 
            // panel_total
            // 
            this.panel_total.BackColor = System.Drawing.Color.Plum;
            this.panel_total.Controls.Add(this.label_total);
            this.panel_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel_total.Location = new System.Drawing.Point(291, 2);
            this.panel_total.Margin = new System.Windows.Forms.Padding(4);
            this.panel_total.Name = "panel_total";
            this.panel_total.Size = new System.Drawing.Size(301, 346);
            this.panel_total.TabIndex = 3;
            this.panel_total.MouseEnter += new System.EventHandler(this.panel_total_MouseEnter);
            this.panel_total.MouseLeave += new System.EventHandler(this.panel_total_MouseLeave);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(10, 144);
            this.label_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(261, 29);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "Total Students: 100%";
            // 
            // label_male
            // 
            this.label_male.AutoSize = true;
            this.label_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_male.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_male.Location = new System.Drawing.Point(4, 69);
            this.label_male.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_male.Name = "label_male";
            this.label_male.Size = new System.Drawing.Size(135, 29);
            this.label_male.TabIndex = 1;
            this.label_male.Text = "Male: 50%";
            // 
            // panel_female
            // 
            this.panel_female.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_female.Controls.Add(this.label_female);
            this.panel_female.Location = new System.Drawing.Point(587, 2);
            this.panel_female.Name = "panel_female";
            this.panel_female.Size = new System.Drawing.Size(334, 346);
            this.panel_female.TabIndex = 5;
            this.panel_female.MouseEnter += new System.EventHandler(this.panel_female_MouseEnter);
            this.panel_female.MouseLeave += new System.EventHandler(this.panel_male_MouseLeave);
            // 
            // panel_male
            // 
            this.panel_male.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_male.Controls.Add(this.label_male);
            this.panel_male.Location = new System.Drawing.Point(1, 2);
            this.panel_male.Name = "panel_male";
            this.panel_male.Size = new System.Drawing.Size(293, 346);
            this.panel_male.TabIndex = 4;
            this.panel_male.MouseEnter += new System.EventHandler(this.panel_male_MouseEnter);
            this.panel_male.MouseLeave += new System.EventHandler(this.panel_male_MouseLeave);
            // 
            // static_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.static_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.static_Chart.Legends.Add(legend1);
            this.static_Chart.Location = new System.Drawing.Point(1, 343);
            this.static_Chart.Name = "static_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Statistic Chart";
            series1.Name = "Static";
            this.static_Chart.Series.Add(series1);
            this.static_Chart.Size = new System.Drawing.Size(920, 351);
            this.static_Chart.TabIndex = 4;
            this.static_Chart.Text = "Statistic ";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.ForeColor = System.Drawing.Color.LightSeaGreen;
            title1.Name = "Title_chart";
            title1.Text = "Statistics Chart ";
            this.static_Chart.Titles.Add(title1);
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 690);
            this.Controls.Add(this.static_Chart);
            this.Controls.Add(this.panel_total);
            this.Controls.Add(this.panel_female);
            this.Controls.Add(this.panel_male);
            this.Name = "StaticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticForm";
            this.Load += new System.EventHandler(this.StaticForm_Load);
            this.panel_total.ResumeLayout(false);
            this.panel_total.PerformLayout();
            this.panel_female.ResumeLayout(false);
            this.panel_female.PerformLayout();
            this.panel_male.ResumeLayout(false);
            this.panel_male.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.static_Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_female;
        private System.Windows.Forms.Panel panel_total;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_male;
        private System.Windows.Forms.Panel panel_female;
        private System.Windows.Forms.Panel panel_male;
        private System.Windows.Forms.DataVisualization.Charting.Chart static_Chart;
    }
}