namespace CentSible.Forms
{
    partial class PredictionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CentSibleLabel = new System.Windows.Forms.Label();
            this.HomeButtonGoal = new System.Windows.Forms.Button();
            this.GoalButtonGoal = new System.Windows.Forms.Button();
            this.TranButtonGoal = new System.Windows.Forms.Button();
            this.SumButtonGoal = new System.Windows.Forms.Button();
            this.PredButtonGoal = new System.Windows.Forms.Button();
            this.LogoutButtonGoal = new System.Windows.Forms.Button();
            this.cbSelectMonthPred = new System.Windows.Forms.ComboBox();
            this.numSelectYearPred = new System.Windows.Forms.NumericUpDown();
            this.lblPredSavingAmount = new System.Windows.Forms.Label();
            this.lblPredSpendingAmount = new System.Windows.Forms.Label();
            this.lblContextDate = new System.Windows.Forms.Label();
            this.chartForecast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SidebarLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYearPred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarLayout
            // 
            this.SidebarLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SidebarLayout.ColumnCount = 1;
            this.SidebarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SidebarLayout.Controls.Add(this.CentSibleLabel, 0, 0);
            this.SidebarLayout.Controls.Add(this.HomeButtonGoal, 0, 1);
            this.SidebarLayout.Controls.Add(this.GoalButtonGoal, 0, 2);
            this.SidebarLayout.Controls.Add(this.TranButtonGoal, 0, 3);
            this.SidebarLayout.Controls.Add(this.SumButtonGoal, 0, 4);
            this.SidebarLayout.Controls.Add(this.PredButtonGoal, 0, 5);
            this.SidebarLayout.Controls.Add(this.LogoutButtonGoal, 0, 6);
            this.SidebarLayout.Location = new System.Drawing.Point(1, -2);
            this.SidebarLayout.Name = "SidebarLayout";
            this.SidebarLayout.RowCount = 7;
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.48F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14F));
            this.SidebarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83F));
            this.SidebarLayout.Size = new System.Drawing.Size(170, 454);
            this.SidebarLayout.TabIndex = 0;
            // 
            // CentSibleLabel
            // 
            this.CentSibleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CentSibleLabel.AutoSize = true;
            this.CentSibleLabel.Font = new System.Drawing.Font("Brush Script MT", 23F, System.Drawing.FontStyle.Italic);
            this.CentSibleLabel.ForeColor = System.Drawing.Color.White;
            this.CentSibleLabel.Location = new System.Drawing.Point(12, 8);
            this.CentSibleLabel.Name = "CentSibleLabel";
            this.CentSibleLabel.Size = new System.Drawing.Size(146, 48);
            this.CentSibleLabel.TabIndex = 0;
            this.CentSibleLabel.Text = "CentSible";
            this.CentSibleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeButtonGoal
            // 
            this.HomeButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.HomeButtonGoal.FlatAppearance.BorderSize = 0;
            this.HomeButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.HomeButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.HomeButtonGoal.ForeColor = System.Drawing.Color.White;
            this.HomeButtonGoal.Location = new System.Drawing.Point(3, 68);
            this.HomeButtonGoal.Name = "HomeButtonGoal";
            this.HomeButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.HomeButtonGoal.TabIndex = 1;
            this.HomeButtonGoal.Text = "Home";
            this.HomeButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButtonGoal.UseVisualStyleBackColor = false;
            this.HomeButtonGoal.Click += new System.EventHandler(this.HomeButtonGoal_Click);
            // 
            // GoalButtonGoal
            // 
            this.GoalButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.GoalButtonGoal.FlatAppearance.BorderSize = 0;
            this.GoalButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.GoalButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.GoalButtonGoal.ForeColor = System.Drawing.Color.White;
            this.GoalButtonGoal.Location = new System.Drawing.Point(3, 114);
            this.GoalButtonGoal.Name = "GoalButtonGoal";
            this.GoalButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.GoalButtonGoal.TabIndex = 2;
            this.GoalButtonGoal.Text = "Goal";
            this.GoalButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoalButtonGoal.UseVisualStyleBackColor = false;
            this.GoalButtonGoal.Click += new System.EventHandler(this.GoalButtonGoal_Click);
            // 
            // TranButtonGoal
            // 
            this.TranButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.TranButtonGoal.FlatAppearance.BorderSize = 0;
            this.TranButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.TranButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.TranButtonGoal.ForeColor = System.Drawing.Color.White;
            this.TranButtonGoal.Location = new System.Drawing.Point(3, 160);
            this.TranButtonGoal.Name = "TranButtonGoal";
            this.TranButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.TranButtonGoal.TabIndex = 3;
            this.TranButtonGoal.Text = "Transactions";
            this.TranButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TranButtonGoal.UseVisualStyleBackColor = false;
            this.TranButtonGoal.Click += new System.EventHandler(this.TranButtonGoal_Click);
            // 
            // SumButtonGoal
            // 
            this.SumButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SumButtonGoal.FlatAppearance.BorderSize = 0;
            this.SumButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.SumButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.SumButtonGoal.ForeColor = System.Drawing.Color.White;
            this.SumButtonGoal.Location = new System.Drawing.Point(3, 206);
            this.SumButtonGoal.Name = "SumButtonGoal";
            this.SumButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.SumButtonGoal.TabIndex = 4;
            this.SumButtonGoal.Text = "Summary";
            this.SumButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SumButtonGoal.UseVisualStyleBackColor = false;
            this.SumButtonGoal.Click += new System.EventHandler(this.SumButtonGoal_Click);
            // 
            // PredButtonGoal
            // 
            this.PredButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.PredButtonGoal.FlatAppearance.BorderSize = 0;
            this.PredButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.PredButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PredButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.PredButtonGoal.ForeColor = System.Drawing.Color.White;
            this.PredButtonGoal.Location = new System.Drawing.Point(3, 252);
            this.PredButtonGoal.Name = "PredButtonGoal";
            this.PredButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.PredButtonGoal.TabIndex = 5;
            this.PredButtonGoal.Text = "Prediction";
            this.PredButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PredButtonGoal.UseVisualStyleBackColor = false;
            this.PredButtonGoal.Click += new System.EventHandler(this.PredButtonGoal_Click);
            // 
            // LogoutButtonGoal
            // 
            this.LogoutButtonGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.LogoutButtonGoal.FlatAppearance.BorderSize = 0;
            this.LogoutButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.LogoutButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.LogoutButtonGoal.ForeColor = System.Drawing.Color.White;
            this.LogoutButtonGoal.Location = new System.Drawing.Point(3, 411);
            this.LogoutButtonGoal.Name = "LogoutButtonGoal";
            this.LogoutButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.LogoutButtonGoal.TabIndex = 6;
            this.LogoutButtonGoal.Text = "Logout";
            this.LogoutButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButtonGoal.UseVisualStyleBackColor = false;
            this.LogoutButtonGoal.Click += new System.EventHandler(this.LogoutButtonGoal_Click);
            // 
            // cbSelectMonthPred
            // 
            this.cbSelectMonthPred.FormattingEnabled = true;
            this.cbSelectMonthPred.Items.AddRange(new object[] {
            "January",
            "February ",
            "March",
            "April ",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November ",
            "December"});
            this.cbSelectMonthPred.Location = new System.Drawing.Point(548, 12);
            this.cbSelectMonthPred.Name = "cbSelectMonthPred";
            this.cbSelectMonthPred.Size = new System.Drawing.Size(114, 24);
            this.cbSelectMonthPred.TabIndex = 1;
            // 
            // numSelectYearPred
            // 
            this.numSelectYearPred.Location = new System.Drawing.Point(668, 14);
            this.numSelectYearPred.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numSelectYearPred.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numSelectYearPred.Name = "numSelectYearPred";
            this.numSelectYearPred.Size = new System.Drawing.Size(120, 22);
            this.numSelectYearPred.TabIndex = 2;
            this.numSelectYearPred.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblPredSavingAmount
            // 
            this.lblPredSavingAmount.AutoSize = true;
            this.lblPredSavingAmount.Location = new System.Drawing.Point(186, 80);
            this.lblPredSavingAmount.Name = "lblPredSavingAmount";
            this.lblPredSavingAmount.Size = new System.Drawing.Size(158, 16);
            this.lblPredSavingAmount.TabIndex = 3;
            this.lblPredSavingAmount.Text = "Predicted Saving Amount";
            // 
            // lblPredSpendingAmount
            // 
            this.lblPredSpendingAmount.AutoSize = true;
            this.lblPredSpendingAmount.Location = new System.Drawing.Point(359, 80);
            this.lblPredSpendingAmount.Name = "lblPredSpendingAmount";
            this.lblPredSpendingAmount.Size = new System.Drawing.Size(174, 16);
            this.lblPredSpendingAmount.TabIndex = 4;
            this.lblPredSpendingAmount.Text = "Predicted Spending Amount";
            // 
            // lblContextDate
            // 
            this.lblContextDate.AutoSize = true;
            this.lblContextDate.Location = new System.Drawing.Point(186, 9);
            this.lblContextDate.Name = "lblContextDate";
            this.lblContextDate.Size = new System.Drawing.Size(92, 16);
            this.lblContextDate.TabIndex = 5;
            this.lblContextDate.Text = "Dynamic Date";
            // 
            // chartForecast
            // 
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Format = "₱ #,##0";
            chartArea1.AxisY.Maximum = 20000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartForecast.ChartAreas.Add(chartArea1);
            legend1.Name = "DefaultLegend";
            this.chartForecast.Legends.Add(legend1);
            this.chartForecast.Location = new System.Drawing.Point(208, 158);
            this.chartForecast.Name = "chartForecast";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "DefaultLegend";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Expense";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "DefaultLegend";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Budget";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "DefaultLegend";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Saving";
            this.chartForecast.Series.Add(series1);
            this.chartForecast.Series.Add(series2);
            this.chartForecast.Series.Add(series3);
            this.chartForecast.Size = new System.Drawing.Size(553, 264);
            this.chartForecast.TabIndex = 6;
            this.chartForecast.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Predicted Saving";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Predicted Spending";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Monthy Forecast";
            // 
            // PredictionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartForecast);
            this.Controls.Add(this.lblContextDate);
            this.Controls.Add(this.lblPredSpendingAmount);
            this.Controls.Add(this.lblPredSavingAmount);
            this.Controls.Add(this.numSelectYearPred);
            this.Controls.Add(this.cbSelectMonthPred);
            this.Controls.Add(this.SidebarLayout);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "PredictionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prediction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PredictionForm_FormClosing);
            this.Load += new System.EventHandler(this.PredictionForm_Load);
            this.SidebarLayout.ResumeLayout(false);
            this.SidebarLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYearPred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel SidebarLayout;
        private System.Windows.Forms.Label CentSibleLabel;
        private System.Windows.Forms.Button HomeButtonGoal;
        private System.Windows.Forms.Button GoalButtonGoal;
        private System.Windows.Forms.Button TranButtonGoal;
        private System.Windows.Forms.Button SumButtonGoal;
        private System.Windows.Forms.Button PredButtonGoal;
        private System.Windows.Forms.Button LogoutButtonGoal;
        private System.Windows.Forms.ComboBox cbSelectMonthPred;
        private System.Windows.Forms.NumericUpDown numSelectYearPred;
        private System.Windows.Forms.Label lblPredSavingAmount;
        private System.Windows.Forms.Label lblPredSpendingAmount;
        private System.Windows.Forms.Label lblContextDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForecast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}