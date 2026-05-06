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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbSelectMonthPred = new System.Windows.Forms.ComboBox();
            this.numSelectYearPred = new System.Windows.Forms.NumericUpDown();
            this.lblPredSavingAmount = new System.Windows.Forms.Label();
            this.lblPredSpendingAmount = new System.Windows.Forms.Label();
            this.lblContextDate = new System.Windows.Forms.Label();
            this.chartForecast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SidebarTableLayoutPred = new System.Windows.Forms.FlowLayoutPanel();
            this.CentSibleTextPanelGoal = new System.Windows.Forms.Panel();
            this.CentSibleLabelPred = new System.Windows.Forms.Label();
            this.SideBarTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.LogoutButtonPred = new System.Windows.Forms.Button();
            this.PredTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.PredPicBoxPred = new System.Windows.Forms.PictureBox();
            this.PredButtonPred = new System.Windows.Forms.Button();
            this.SumTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.SumPicBoxPred = new System.Windows.Forms.PictureBox();
            this.SumButtonPred = new System.Windows.Forms.Button();
            this.TranTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.TranButtonPred = new System.Windows.Forms.Button();
            this.TranPicBoxPred = new System.Windows.Forms.PictureBox();
            this.GoalTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.GoalButtonPred = new System.Windows.Forms.Button();
            this.GoalPicBoxPred = new System.Windows.Forms.PictureBox();
            this.HomeTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.HomeButtonPred = new System.Windows.Forms.Button();
            this.HomePicBoxPred = new System.Windows.Forms.PictureBox();
            this.PredictionLblPred = new System.Windows.Forms.Label();
            this.PredSaveTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.PredSpendTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYearPred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).BeginInit();
            this.SidebarTableLayoutPred.SuspendLayout();
            this.CentSibleTextPanelGoal.SuspendLayout();
            this.SideBarTabLayPred.SuspendLayout();
            this.PredTabLayPred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredPicBoxPred)).BeginInit();
            this.SumTabLayPred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SumPicBoxPred)).BeginInit();
            this.TranTabLayPred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TranPicBoxPred)).BeginInit();
            this.GoalTabLayPred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoalPicBoxPred)).BeginInit();
            this.HomeTabLayPred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBoxPred)).BeginInit();
            this.PredSaveTabLayPred.SuspendLayout();
            this.PredSpendTabLayPred.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelectMonthPred
            // 
            this.cbSelectMonthPred.Font = new System.Drawing.Font("Segoe UI", 8.2F);
            this.cbSelectMonthPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
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
            this.cbSelectMonthPred.Location = new System.Drawing.Point(687, 45);
            this.cbSelectMonthPred.Name = "cbSelectMonthPred";
            this.cbSelectMonthPred.Size = new System.Drawing.Size(114, 27);
            this.cbSelectMonthPred.TabIndex = 1;
            // 
            // numSelectYearPred
            // 
            this.numSelectYearPred.Font = new System.Drawing.Font("Segoe UI", 8.2F);
            this.numSelectYearPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.numSelectYearPred.Location = new System.Drawing.Point(818, 46);
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
            this.numSelectYearPred.Size = new System.Drawing.Size(120, 26);
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
            this.lblPredSavingAmount.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblPredSavingAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.lblPredSavingAmount.Location = new System.Drawing.Point(6, 27);
            this.lblPredSavingAmount.Name = "lblPredSavingAmount";
            this.lblPredSavingAmount.Size = new System.Drawing.Size(127, 31);
            this.lblPredSavingAmount.TabIndex = 3;
            this.lblPredSavingAmount.Text = "Predicted Saving Amount";
            // 
            // lblPredSpendingAmount
            // 
            this.lblPredSpendingAmount.AutoSize = true;
            this.lblPredSpendingAmount.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblPredSpendingAmount.ForeColor = System.Drawing.Color.Red;
            this.lblPredSpendingAmount.Location = new System.Drawing.Point(6, 27);
            this.lblPredSpendingAmount.Name = "lblPredSpendingAmount";
            this.lblPredSpendingAmount.Size = new System.Drawing.Size(127, 31);
            this.lblPredSpendingAmount.TabIndex = 4;
            this.lblPredSpendingAmount.Text = "Predicted Spending Amount";
            // 
            // lblContextDate
            // 
            this.lblContextDate.AutoSize = true;
            this.lblContextDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblContextDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.lblContextDate.Location = new System.Drawing.Point(279, 68);
            this.lblContextDate.Name = "lblContextDate";
            this.lblContextDate.Size = new System.Drawing.Size(95, 19);
            this.lblContextDate.TabIndex = 5;
            this.lblContextDate.Text = "Dynamic Date";
            // 
            // chartForecast
            // 
            chartArea3.AxisX.LabelStyle.Interval = 1D;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.Interval = 1000D;
            chartArea3.AxisY.LabelStyle.Format = "₱ #,##0";
            chartArea3.AxisY.Maximum = 10000D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chartForecast.ChartAreas.Add(chartArea3);
            legend3.Name = "DefaultLegend";
            this.chartForecast.Legends.Add(legend3);
            this.chartForecast.Location = new System.Drawing.Point(230, 211);
            this.chartForecast.Name = "chartForecast";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "DefaultLegend";
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Expense";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series8.Legend = "DefaultLegend";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Budget";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Lime;
            series9.Legend = "DefaultLegend";
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series9.Name = "Saving";
            this.chartForecast.Series.Add(series7);
            this.chartForecast.Series.Add(series8);
            this.chartForecast.Series.Add(series9);
            this.chartForecast.Size = new System.Drawing.Size(769, 287);
            this.chartForecast.TabIndex = 6;
            this.chartForecast.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Predicted Saving";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Predicted Spending";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(523, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Monthy Forecast";
            // 
            // SidebarTableLayoutPred
            // 
            this.SidebarTableLayoutPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SidebarTableLayoutPred.Controls.Add(this.CentSibleTextPanelGoal);
            this.SidebarTableLayoutPred.Controls.Add(this.SideBarTabLayPred);
            this.SidebarTableLayoutPred.Location = new System.Drawing.Point(-2, -2);
            this.SidebarTableLayoutPred.Name = "SidebarTableLayoutPred";
            this.SidebarTableLayoutPred.Size = new System.Drawing.Size(200, 521);
            this.SidebarTableLayoutPred.TabIndex = 41;
            // 
            // CentSibleTextPanelGoal
            // 
            this.CentSibleTextPanelGoal.Controls.Add(this.CentSibleLabelPred);
            this.CentSibleTextPanelGoal.Location = new System.Drawing.Point(3, 3);
            this.CentSibleTextPanelGoal.Name = "CentSibleTextPanelGoal";
            this.CentSibleTextPanelGoal.Size = new System.Drawing.Size(197, 60);
            this.CentSibleTextPanelGoal.TabIndex = 12;
            // 
            // CentSibleLabelPred
            // 
            this.CentSibleLabelPred.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CentSibleLabelPred.Font = new System.Drawing.Font("Brush Script MT", 23F, System.Drawing.FontStyle.Italic);
            this.CentSibleLabelPred.ForeColor = System.Drawing.Color.White;
            this.CentSibleLabelPred.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CentSibleLabelPred.Location = new System.Drawing.Point(0, -3);
            this.CentSibleLabelPred.Name = "CentSibleLabelPred";
            this.CentSibleLabelPred.Size = new System.Drawing.Size(197, 63);
            this.CentSibleLabelPred.TabIndex = 10;
            this.CentSibleLabelPred.Text = "CentSible";
            this.CentSibleLabelPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideBarTabLayPred
            // 
            this.SideBarTabLayPred.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SideBarTabLayPred.ColumnCount = 1;
            this.SideBarTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SideBarTabLayPred.Controls.Add(this.LogoutButtonPred, 1, 6);
            this.SideBarTabLayPred.Controls.Add(this.PredTabLayPred, 0, 4);
            this.SideBarTabLayPred.Controls.Add(this.SumTabLayPred, 0, 3);
            this.SideBarTabLayPred.Controls.Add(this.TranTabLayPred, 0, 2);
            this.SideBarTabLayPred.Controls.Add(this.GoalTabLayPred, 0, 1);
            this.SideBarTabLayPred.Controls.Add(this.HomeTabLayPred, 0, 0);
            this.SideBarTabLayPred.Location = new System.Drawing.Point(3, 69);
            this.SideBarTabLayPred.Name = "SideBarTabLayPred";
            this.SideBarTabLayPred.RowCount = 7;
            this.SideBarTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SideBarTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.SideBarTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.SideBarTabLayPred.Size = new System.Drawing.Size(189, 441);
            this.SideBarTabLayPred.TabIndex = 11;
            // 
            // LogoutButtonPred
            // 
            this.LogoutButtonPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.LogoutButtonPred.FlatAppearance.BorderSize = 0;
            this.LogoutButtonPred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.LogoutButtonPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButtonPred.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LogoutButtonPred.ForeColor = System.Drawing.Color.White;
            this.LogoutButtonPred.Location = new System.Drawing.Point(3, 399);
            this.LogoutButtonPred.Name = "LogoutButtonPred";
            this.LogoutButtonPred.Size = new System.Drawing.Size(183, 39);
            this.LogoutButtonPred.TabIndex = 15;
            this.LogoutButtonPred.Text = "Logout";
            this.LogoutButtonPred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButtonPred.UseVisualStyleBackColor = false;
            this.LogoutButtonPred.Click += new System.EventHandler(this.LogoutButtonPred_Click);
            // 
            // PredTabLayPred
            // 
            this.PredTabLayPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.PredTabLayPred.ColumnCount = 2;
            this.PredTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.PredTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.PredTabLayPred.Controls.Add(this.PredPicBoxPred, 0, 0);
            this.PredTabLayPred.Controls.Add(this.PredButtonPred, 1, 0);
            this.PredTabLayPred.Location = new System.Drawing.Point(3, 203);
            this.PredTabLayPred.Name = "PredTabLayPred";
            this.PredTabLayPred.RowCount = 1;
            this.PredTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredTabLayPred.Size = new System.Drawing.Size(183, 44);
            this.PredTabLayPred.TabIndex = 24;
            // 
            // PredPicBoxPred
            // 
            this.PredPicBoxPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PredPicBoxPred.Image = global::CentSible.Properties.Resources.PredictionForm;
            this.PredPicBoxPred.Location = new System.Drawing.Point(12, 3);
            this.PredPicBoxPred.Name = "PredPicBoxPred";
            this.PredPicBoxPred.Size = new System.Drawing.Size(40, 38);
            this.PredPicBoxPred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PredPicBoxPred.TabIndex = 19;
            this.PredPicBoxPred.TabStop = false;
            // 
            // PredButtonPred
            // 
            this.PredButtonPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.PredButtonPred.FlatAppearance.BorderSize = 0;
            this.PredButtonPred.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.PredButtonPred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.PredButtonPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PredButtonPred.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PredButtonPred.ForeColor = System.Drawing.Color.White;
            this.PredButtonPred.Location = new System.Drawing.Point(67, 3);
            this.PredButtonPred.Name = "PredButtonPred";
            this.PredButtonPred.Size = new System.Drawing.Size(113, 38);
            this.PredButtonPred.TabIndex = 11;
            this.PredButtonPred.Text = "Prediction";
            this.PredButtonPred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PredButtonPred.UseVisualStyleBackColor = false;
            // 
            // SumTabLayPred
            // 
            this.SumTabLayPred.ColumnCount = 2;
            this.SumTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.SumTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.SumTabLayPred.Controls.Add(this.SumPicBoxPred, 0, 0);
            this.SumTabLayPred.Controls.Add(this.SumButtonPred, 1, 0);
            this.SumTabLayPred.Location = new System.Drawing.Point(3, 153);
            this.SumTabLayPred.Name = "SumTabLayPred";
            this.SumTabLayPred.RowCount = 1;
            this.SumTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SumTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SumTabLayPred.Size = new System.Drawing.Size(183, 44);
            this.SumTabLayPred.TabIndex = 24;
            // 
            // SumPicBoxPred
            // 
            this.SumPicBoxPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SumPicBoxPred.Image = global::CentSible.Properties.Resources.SummaryForm;
            this.SumPicBoxPred.Location = new System.Drawing.Point(12, 3);
            this.SumPicBoxPred.Name = "SumPicBoxPred";
            this.SumPicBoxPred.Size = new System.Drawing.Size(40, 38);
            this.SumPicBoxPred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SumPicBoxPred.TabIndex = 18;
            this.SumPicBoxPred.TabStop = false;
            // 
            // SumButtonPred
            // 
            this.SumButtonPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SumButtonPred.FlatAppearance.BorderSize = 0;
            this.SumButtonPred.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.SumButtonPred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.SumButtonPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumButtonPred.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SumButtonPred.ForeColor = System.Drawing.Color.White;
            this.SumButtonPred.Location = new System.Drawing.Point(67, 3);
            this.SumButtonPred.Name = "SumButtonPred";
            this.SumButtonPred.Size = new System.Drawing.Size(113, 38);
            this.SumButtonPred.TabIndex = 13;
            this.SumButtonPred.Text = "Summary";
            this.SumButtonPred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SumButtonPred.UseVisualStyleBackColor = false;
            this.SumButtonPred.Click += new System.EventHandler(this.SumButtonPred_Click);
            // 
            // TranTabLayPred
            // 
            this.TranTabLayPred.ColumnCount = 2;
            this.TranTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.TranTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.TranTabLayPred.Controls.Add(this.TranButtonPred, 1, 0);
            this.TranTabLayPred.Controls.Add(this.TranPicBoxPred, 0, 0);
            this.TranTabLayPred.Location = new System.Drawing.Point(3, 103);
            this.TranTabLayPred.Name = "TranTabLayPred";
            this.TranTabLayPred.RowCount = 1;
            this.TranTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TranTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TranTabLayPred.Size = new System.Drawing.Size(183, 44);
            this.TranTabLayPred.TabIndex = 23;
            // 
            // TranButtonPred
            // 
            this.TranButtonPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.TranButtonPred.FlatAppearance.BorderSize = 0;
            this.TranButtonPred.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.TranButtonPred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.TranButtonPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranButtonPred.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TranButtonPred.ForeColor = System.Drawing.Color.White;
            this.TranButtonPred.Location = new System.Drawing.Point(67, 3);
            this.TranButtonPred.Name = "TranButtonPred";
            this.TranButtonPred.Size = new System.Drawing.Size(113, 38);
            this.TranButtonPred.TabIndex = 12;
            this.TranButtonPred.Text = "Transactions";
            this.TranButtonPred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TranButtonPred.UseVisualStyleBackColor = false;
            this.TranButtonPred.Click += new System.EventHandler(this.TranButtonPred_Click);
            // 
            // TranPicBoxPred
            // 
            this.TranPicBoxPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TranPicBoxPred.Image = global::CentSible.Properties.Resources.TransactionForm;
            this.TranPicBoxPred.Location = new System.Drawing.Point(12, 5);
            this.TranPicBoxPred.Name = "TranPicBoxPred";
            this.TranPicBoxPred.Size = new System.Drawing.Size(40, 33);
            this.TranPicBoxPred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TranPicBoxPred.TabIndex = 16;
            this.TranPicBoxPred.TabStop = false;
            // 
            // GoalTabLayPred
            // 
            this.GoalTabLayPred.ColumnCount = 2;
            this.GoalTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.63415F));
            this.GoalTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.36585F));
            this.GoalTabLayPred.Controls.Add(this.GoalButtonPred, 1, 0);
            this.GoalTabLayPred.Controls.Add(this.GoalPicBoxPred, 0, 0);
            this.GoalTabLayPred.Location = new System.Drawing.Point(3, 53);
            this.GoalTabLayPred.Name = "GoalTabLayPred";
            this.GoalTabLayPred.RowCount = 1;
            this.GoalTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GoalTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GoalTabLayPred.Size = new System.Drawing.Size(183, 44);
            this.GoalTabLayPred.TabIndex = 22;
            // 
            // GoalButtonPred
            // 
            this.GoalButtonPred.FlatAppearance.BorderSize = 0;
            this.GoalButtonPred.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.GoalButtonPred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.GoalButtonPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalButtonPred.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GoalButtonPred.ForeColor = System.Drawing.Color.White;
            this.GoalButtonPred.Location = new System.Drawing.Point(66, 3);
            this.GoalButtonPred.Name = "GoalButtonPred";
            this.GoalButtonPred.Size = new System.Drawing.Size(114, 38);
            this.GoalButtonPred.TabIndex = 11;
            this.GoalButtonPred.Text = "Goal";
            this.GoalButtonPred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoalButtonPred.UseVisualStyleBackColor = false;
            this.GoalButtonPred.Click += new System.EventHandler(this.GoalButtonPred_Click);
            // 
            // GoalPicBoxPred
            // 
            this.GoalPicBoxPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoalPicBoxPred.Image = global::CentSible.Properties.Resources.GoalForm;
            this.GoalPicBoxPred.Location = new System.Drawing.Point(11, 3);
            this.GoalPicBoxPred.Name = "GoalPicBoxPred";
            this.GoalPicBoxPred.Size = new System.Drawing.Size(40, 38);
            this.GoalPicBoxPred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoalPicBoxPred.TabIndex = 17;
            this.GoalPicBoxPred.TabStop = false;
            // 
            // HomeTabLayPred
            // 
            this.HomeTabLayPred.ColumnCount = 2;
            this.HomeTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.HomeTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.HomeTabLayPred.Controls.Add(this.HomeButtonPred, 1, 0);
            this.HomeTabLayPred.Controls.Add(this.HomePicBoxPred, 0, 0);
            this.HomeTabLayPred.Location = new System.Drawing.Point(3, 3);
            this.HomeTabLayPred.Name = "HomeTabLayPred";
            this.HomeTabLayPred.RowCount = 1;
            this.HomeTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HomeTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HomeTabLayPred.Size = new System.Drawing.Size(183, 44);
            this.HomeTabLayPred.TabIndex = 21;
            // 
            // HomeButtonPred
            // 
            this.HomeButtonPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.HomeButtonPred.FlatAppearance.BorderSize = 0;
            this.HomeButtonPred.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.HomeButtonPred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.HomeButtonPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButtonPred.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HomeButtonPred.ForeColor = System.Drawing.Color.White;
            this.HomeButtonPred.Location = new System.Drawing.Point(67, 3);
            this.HomeButtonPred.Name = "HomeButtonPred";
            this.HomeButtonPred.Size = new System.Drawing.Size(108, 38);
            this.HomeButtonPred.TabIndex = 8;
            this.HomeButtonPred.Text = "Home";
            this.HomeButtonPred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButtonPred.UseVisualStyleBackColor = false;
            this.HomeButtonPred.Click += new System.EventHandler(this.HomeButtonPred_Click);
            // 
            // HomePicBoxPred
            // 
            this.HomePicBoxPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HomePicBoxPred.Image = global::CentSible.Properties.Resources.HomeForm;
            this.HomePicBoxPred.Location = new System.Drawing.Point(12, 3);
            this.HomePicBoxPred.Name = "HomePicBoxPred";
            this.HomePicBoxPred.Size = new System.Drawing.Size(40, 38);
            this.HomePicBoxPred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePicBoxPred.TabIndex = 15;
            this.HomePicBoxPred.TabStop = false;
            // 
            // PredictionLblPred
            // 
            this.PredictionLblPred.AutoSize = true;
            this.PredictionLblPred.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.PredictionLblPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.PredictionLblPred.Location = new System.Drawing.Point(277, 35);
            this.PredictionLblPred.Name = "PredictionLblPred";
            this.PredictionLblPred.Size = new System.Drawing.Size(135, 35);
            this.PredictionLblPred.TabIndex = 42;
            this.PredictionLblPred.Text = "Prediction";
            // 
            // PredSaveTabLayPred
            // 
            this.PredSaveTabLayPred.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.PredSaveTabLayPred.ColumnCount = 1;
            this.PredSaveTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredSaveTabLayPred.Controls.Add(this.label1, 0, 0);
            this.PredSaveTabLayPred.Controls.Add(this.lblPredSavingAmount, 0, 1);
            this.PredSaveTabLayPred.Location = new System.Drawing.Point(402, 109);
            this.PredSaveTabLayPred.Name = "PredSaveTabLayPred";
            this.PredSaveTabLayPred.RowCount = 2;
            this.PredSaveTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredSaveTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.PredSaveTabLayPred.Size = new System.Drawing.Size(190, 61);
            this.PredSaveTabLayPred.TabIndex = 43;
            // 
            // PredSpendTabLayPred
            // 
            this.PredSpendTabLayPred.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.PredSpendTabLayPred.ColumnCount = 1;
            this.PredSpendTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredSpendTabLayPred.Controls.Add(this.lblPredSpendingAmount, 0, 1);
            this.PredSpendTabLayPred.Controls.Add(this.label2, 0, 0);
            this.PredSpendTabLayPred.Location = new System.Drawing.Point(598, 109);
            this.PredSpendTabLayPred.Name = "PredSpendTabLayPred";
            this.PredSpendTabLayPred.RowCount = 2;
            this.PredSpendTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredSpendTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.PredSpendTabLayPred.Size = new System.Drawing.Size(190, 61);
            this.PredSpendTabLayPred.TabIndex = 44;
            // 
            // PredictionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1035, 510);
            this.Controls.Add(this.PredSpendTabLayPred);
            this.Controls.Add(this.PredSaveTabLayPred);
            this.Controls.Add(this.PredictionLblPred);
            this.Controls.Add(this.SidebarTableLayoutPred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartForecast);
            this.Controls.Add(this.lblContextDate);
            this.Controls.Add(this.numSelectYearPred);
            this.Controls.Add(this.cbSelectMonthPred);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1053, 557);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1053, 557);
            this.Name = "PredictionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prediction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PredictionForm_FormClosing);
            this.Load += new System.EventHandler(this.PredictionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYearPred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).EndInit();
            this.SidebarTableLayoutPred.ResumeLayout(false);
            this.CentSibleTextPanelGoal.ResumeLayout(false);
            this.SideBarTabLayPred.ResumeLayout(false);
            this.PredTabLayPred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PredPicBoxPred)).EndInit();
            this.SumTabLayPred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SumPicBoxPred)).EndInit();
            this.TranTabLayPred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TranPicBoxPred)).EndInit();
            this.GoalTabLayPred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoalPicBoxPred)).EndInit();
            this.HomeTabLayPred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomePicBoxPred)).EndInit();
            this.PredSaveTabLayPred.ResumeLayout(false);
            this.PredSaveTabLayPred.PerformLayout();
            this.PredSpendTabLayPred.ResumeLayout(false);
            this.PredSpendTabLayPred.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ComboBox cbSelectMonthPred;
        private System.Windows.Forms.NumericUpDown numSelectYearPred;
        private System.Windows.Forms.Label lblPredSavingAmount;
        private System.Windows.Forms.Label lblPredSpendingAmount;
        private System.Windows.Forms.Label lblContextDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForecast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel SidebarTableLayoutPred;
        private System.Windows.Forms.Panel CentSibleTextPanelGoal;
        private System.Windows.Forms.Label CentSibleLabelPred;
        private System.Windows.Forms.TableLayoutPanel SideBarTabLayPred;
        private System.Windows.Forms.Button LogoutButtonPred;
        private System.Windows.Forms.TableLayoutPanel PredTabLayPred;
        private System.Windows.Forms.PictureBox PredPicBoxPred;
        private System.Windows.Forms.Button PredButtonPred;
        private System.Windows.Forms.TableLayoutPanel SumTabLayPred;
        private System.Windows.Forms.PictureBox SumPicBoxPred;
        private System.Windows.Forms.Button SumButtonPred;
        private System.Windows.Forms.TableLayoutPanel TranTabLayPred;
        private System.Windows.Forms.Button TranButtonPred;
        private System.Windows.Forms.PictureBox TranPicBoxPred;
        private System.Windows.Forms.TableLayoutPanel GoalTabLayPred;
        private System.Windows.Forms.Button GoalButtonPred;
        private System.Windows.Forms.PictureBox GoalPicBoxPred;
        private System.Windows.Forms.TableLayoutPanel HomeTabLayPred;
        private System.Windows.Forms.Button HomeButtonPred;
        private System.Windows.Forms.PictureBox HomePicBoxPred;
        private System.Windows.Forms.Label PredictionLblPred;
        private System.Windows.Forms.TableLayoutPanel PredSaveTabLayPred;
        private System.Windows.Forms.TableLayoutPanel PredSpendTabLayPred;
    }
}