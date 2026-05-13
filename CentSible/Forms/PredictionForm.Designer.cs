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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictionForm));
            this.cbSelectMonthPred = new System.Windows.Forms.ComboBox();
            this.numSelectYearPred = new System.Windows.Forms.NumericUpDown();
            this.PredSaveLblPred = new System.Windows.Forms.Label();
            this.PredSpendLblPred = new System.Windows.Forms.Label();
            this.lblContextDate = new System.Windows.Forms.Label();
            this.PredSavLblPred = new System.Windows.Forms.Label();
            this.PredSpenLblPred = new System.Windows.Forms.Label();
            this.MonthlyForecastLblPred = new System.Windows.Forms.Label();
            this.SidebarTableLayoutPred = new System.Windows.Forms.FlowLayoutPanel();
            this.CentSibleTextPanelGoal = new System.Windows.Forms.Panel();
            this.CentSibleLabelPred = new System.Windows.Forms.Label();
            this.SideBarTabLayPred = new System.Windows.Forms.TableLayoutPanel();
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
            this.LogTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.LogPicBoxPred = new System.Windows.Forms.PictureBox();
            this.LogoutBtnPred = new System.Windows.Forms.Button();
            this.PredictionLblPred = new System.Windows.Forms.Label();
            this.LegendTabLayPred = new System.Windows.Forms.TableLayoutPanel();
            this.ExpenseLblPred = new System.Windows.Forms.Label();
            this.LegendOrangePnlPred = new System.Windows.Forms.FlowLayoutPanel();
            this.BudgetLblPred = new System.Windows.Forms.Label();
            this.SavingLblPred = new System.Windows.Forms.Label();
            this.LegendGreenPnlPred = new System.Windows.Forms.FlowLayoutPanel();
            this.LegendRedPnlPred = new System.Windows.Forms.FlowLayoutPanel();
            this.PredSavePnlPred = new Guna.UI2.WinForms.Guna2Panel();
            this.PredSpendPnlPred = new Guna.UI2.WinForms.Guna2Panel();
            this.LegendPnlPred = new Guna.UI2.WinForms.Guna2Panel();
            this.ForecastPnlPred = new Guna.UI2.WinForms.Guna2Panel();
            this.ForecastChrtPred = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYearPred)).BeginInit();
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
            this.LogTabLayPred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogPicBoxPred)).BeginInit();
            this.LegendTabLayPred.SuspendLayout();
            this.PredSavePnlPred.SuspendLayout();
            this.PredSpendPnlPred.SuspendLayout();
            this.LegendPnlPred.SuspendLayout();
            this.ForecastPnlPred.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ForecastChrtPred)).BeginInit();
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
            this.cbSelectMonthPred.Location = new System.Drawing.Point(788, 35);
            this.cbSelectMonthPred.Name = "cbSelectMonthPred";
            this.cbSelectMonthPred.Size = new System.Drawing.Size(120, 27);
            this.cbSelectMonthPred.TabIndex = 1;
            // 
            // numSelectYearPred
            // 
            this.numSelectYearPred.Font = new System.Drawing.Font("Segoe UI", 8.2F);
            this.numSelectYearPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.numSelectYearPred.Location = new System.Drawing.Point(657, 35);
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
            // PredSaveLblPred
            // 
            this.PredSaveLblPred.AutoSize = true;
            this.PredSaveLblPred.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold);
            this.PredSaveLblPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.PredSaveLblPred.Location = new System.Drawing.Point(5, 30);
            this.PredSaveLblPred.Name = "PredSaveLblPred";
            this.PredSaveLblPred.Size = new System.Drawing.Size(180, 30);
            this.PredSaveLblPred.TabIndex = 3;
            this.PredSaveLblPred.Text = "Predicted Saving";
            // 
            // PredSpendLblPred
            // 
            this.PredSpendLblPred.AutoSize = true;
            this.PredSpendLblPred.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PredSpendLblPred.ForeColor = System.Drawing.Color.Red;
            this.PredSpendLblPred.Location = new System.Drawing.Point(5, 30);
            this.PredSpendLblPred.Name = "PredSpendLblPred";
            this.PredSpendLblPred.Size = new System.Drawing.Size(177, 30);
            this.PredSpendLblPred.TabIndex = 4;
            this.PredSpendLblPred.Text = "Predicted Spend";
            // 
            // lblContextDate
            // 
            this.lblContextDate.AutoSize = true;
            this.lblContextDate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContextDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.lblContextDate.Location = new System.Drawing.Point(237, 44);
            this.lblContextDate.Name = "lblContextDate";
            this.lblContextDate.Size = new System.Drawing.Size(92, 17);
            this.lblContextDate.TabIndex = 5;
            this.lblContextDate.Text = "Dynamic Date";
            // 
            // PredSavLblPred
            // 
            this.PredSavLblPred.AutoSize = true;
            this.PredSavLblPred.Font = new System.Drawing.Font("Segoe UI", 8.2F);
            this.PredSavLblPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.PredSavLblPred.Location = new System.Drawing.Point(7, 11);
            this.PredSavLblPred.Name = "PredSavLblPred";
            this.PredSavLblPred.Size = new System.Drawing.Size(110, 19);
            this.PredSavLblPred.TabIndex = 7;
            this.PredSavLblPred.Text = "Predicted Saving";
            // 
            // PredSpenLblPred
            // 
            this.PredSpenLblPred.AutoSize = true;
            this.PredSpenLblPred.Font = new System.Drawing.Font("Segoe UI", 8.2F);
            this.PredSpenLblPred.ForeColor = System.Drawing.Color.Red;
            this.PredSpenLblPred.Location = new System.Drawing.Point(7, 11);
            this.PredSpenLblPred.Name = "PredSpenLblPred";
            this.PredSpenLblPred.Size = new System.Drawing.Size(127, 19);
            this.PredSpenLblPred.TabIndex = 8;
            this.PredSpenLblPred.Text = "Predicted Spending";
            // 
            // MonthlyForecastLblPred
            // 
            this.MonthlyForecastLblPred.AutoSize = true;
            this.MonthlyForecastLblPred.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.MonthlyForecastLblPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.MonthlyForecastLblPred.Location = new System.Drawing.Point(490, 181);
            this.MonthlyForecastLblPred.Name = "MonthlyForecastLblPred";
            this.MonthlyForecastLblPred.Size = new System.Drawing.Size(140, 23);
            this.MonthlyForecastLblPred.TabIndex = 9;
            this.MonthlyForecastLblPred.Text = "Monthy Forecast";
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
            this.SideBarTabLayPred.Controls.Add(this.PredTabLayPred, 0, 4);
            this.SideBarTabLayPred.Controls.Add(this.SumTabLayPred, 0, 3);
            this.SideBarTabLayPred.Controls.Add(this.TranTabLayPred, 0, 2);
            this.SideBarTabLayPred.Controls.Add(this.GoalTabLayPred, 0, 1);
            this.SideBarTabLayPred.Controls.Add(this.HomeTabLayPred, 0, 0);
            this.SideBarTabLayPred.Controls.Add(this.LogTabLayPred, 0, 6);
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
            this.SideBarTabLayPred.Size = new System.Drawing.Size(195, 411);
            this.SideBarTabLayPred.TabIndex = 11;
            // 
            // PredTabLayPred
            // 
            this.PredTabLayPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(110)))), ((int)(((byte)(60)))));
            this.PredTabLayPred.ColumnCount = 2;
            this.PredTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.PredTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.PredTabLayPred.Controls.Add(this.PredPicBoxPred, 0, 0);
            this.PredTabLayPred.Controls.Add(this.PredButtonPred, 1, 0);
            this.PredTabLayPred.Location = new System.Drawing.Point(3, 179);
            this.PredTabLayPred.Name = "PredTabLayPred";
            this.PredTabLayPred.RowCount = 1;
            this.PredTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PredTabLayPred.Size = new System.Drawing.Size(183, 38);
            this.PredTabLayPred.TabIndex = 24;
            // 
            // PredPicBoxPred
            // 
            this.PredPicBoxPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PredPicBoxPred.Image = global::CentSible.Properties.Resources.PredictionForm;
            this.PredPicBoxPred.Location = new System.Drawing.Point(12, 3);
            this.PredPicBoxPred.Name = "PredPicBoxPred";
            this.PredPicBoxPred.Size = new System.Drawing.Size(40, 32);
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
            this.PredButtonPred.Size = new System.Drawing.Size(113, 32);
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
            this.SumTabLayPred.Location = new System.Drawing.Point(3, 135);
            this.SumTabLayPred.Name = "SumTabLayPred";
            this.SumTabLayPred.RowCount = 1;
            this.SumTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SumTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SumTabLayPred.Size = new System.Drawing.Size(183, 38);
            this.SumTabLayPred.TabIndex = 24;
            // 
            // SumPicBoxPred
            // 
            this.SumPicBoxPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SumPicBoxPred.Image = global::CentSible.Properties.Resources.SummaryForm;
            this.SumPicBoxPred.Location = new System.Drawing.Point(12, 3);
            this.SumPicBoxPred.Name = "SumPicBoxPred";
            this.SumPicBoxPred.Size = new System.Drawing.Size(40, 32);
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
            this.SumButtonPred.Size = new System.Drawing.Size(113, 32);
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
            this.TranTabLayPred.Location = new System.Drawing.Point(3, 91);
            this.TranTabLayPred.Name = "TranTabLayPred";
            this.TranTabLayPred.RowCount = 1;
            this.TranTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TranTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TranTabLayPred.Size = new System.Drawing.Size(183, 38);
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
            this.TranButtonPred.Size = new System.Drawing.Size(113, 32);
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
            this.TranPicBoxPred.Location = new System.Drawing.Point(12, 3);
            this.TranPicBoxPred.Name = "TranPicBoxPred";
            this.TranPicBoxPred.Size = new System.Drawing.Size(40, 32);
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
            this.GoalTabLayPred.Location = new System.Drawing.Point(3, 47);
            this.GoalTabLayPred.Name = "GoalTabLayPred";
            this.GoalTabLayPred.RowCount = 1;
            this.GoalTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GoalTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GoalTabLayPred.Size = new System.Drawing.Size(183, 38);
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
            this.GoalButtonPred.Size = new System.Drawing.Size(114, 32);
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
            this.GoalPicBoxPred.Size = new System.Drawing.Size(40, 32);
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
            this.HomeTabLayPred.Size = new System.Drawing.Size(183, 38);
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
            this.HomeButtonPred.Size = new System.Drawing.Size(108, 32);
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
            this.HomePicBoxPred.Size = new System.Drawing.Size(40, 32);
            this.HomePicBoxPred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePicBoxPred.TabIndex = 15;
            this.HomePicBoxPred.TabStop = false;
            // 
            // LogTabLayPred
            // 
            this.LogTabLayPred.ColumnCount = 2;
            this.LogTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12195F));
            this.LogTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87805F));
            this.LogTabLayPred.Controls.Add(this.LogPicBoxPred, 0, 0);
            this.LogTabLayPred.Controls.Add(this.LogoutBtnPred, 1, 0);
            this.LogTabLayPred.Location = new System.Drawing.Point(3, 369);
            this.LogTabLayPred.Name = "LogTabLayPred";
            this.LogTabLayPred.RowCount = 1;
            this.LogTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LogTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LogTabLayPred.Size = new System.Drawing.Size(183, 38);
            this.LogTabLayPred.TabIndex = 25;
            // 
            // LogPicBoxPred
            // 
            this.LogPicBoxPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogPicBoxPred.Image = global::CentSible.Properties.Resources.LogoutForm;
            this.LogPicBoxPred.Location = new System.Drawing.Point(12, 3);
            this.LogPicBoxPred.Name = "LogPicBoxPred";
            this.LogPicBoxPred.Size = new System.Drawing.Size(40, 32);
            this.LogPicBoxPred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogPicBoxPred.TabIndex = 18;
            this.LogPicBoxPred.TabStop = false;
            // 
            // LogoutBtnPred
            // 
            this.LogoutBtnPred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutBtnPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.LogoutBtnPred.FlatAppearance.BorderSize = 0;
            this.LogoutBtnPred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(160)))), ((int)(((byte)(90)))));
            this.LogoutBtnPred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtnPred.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LogoutBtnPred.ForeColor = System.Drawing.Color.White;
            this.LogoutBtnPred.Location = new System.Drawing.Point(67, 3);
            this.LogoutBtnPred.Name = "LogoutBtnPred";
            this.LogoutBtnPred.Size = new System.Drawing.Size(113, 32);
            this.LogoutBtnPred.TabIndex = 15;
            this.LogoutBtnPred.Text = "Logout";
            this.LogoutBtnPred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutBtnPred.UseVisualStyleBackColor = false;
            this.LogoutBtnPred.Click += new System.EventHandler(this.LogoutBtnPred_Click);
            // 
            // PredictionLblPred
            // 
            this.PredictionLblPred.AutoSize = true;
            this.PredictionLblPred.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.PredictionLblPred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.PredictionLblPred.Location = new System.Drawing.Point(231, 20);
            this.PredictionLblPred.Name = "PredictionLblPred";
            this.PredictionLblPred.Size = new System.Drawing.Size(120, 30);
            this.PredictionLblPred.TabIndex = 42;
            this.PredictionLblPred.Text = "Prediction";
            // 
            // LegendTabLayPred
            // 
            this.LegendTabLayPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.LegendTabLayPred.ColumnCount = 2;
            this.LegendTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LegendTabLayPred.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LegendTabLayPred.Controls.Add(this.ExpenseLblPred, 0, 2);
            this.LegendTabLayPred.Controls.Add(this.LegendOrangePnlPred, 1, 1);
            this.LegendTabLayPred.Controls.Add(this.BudgetLblPred, 0, 1);
            this.LegendTabLayPred.Controls.Add(this.SavingLblPred, 0, 0);
            this.LegendTabLayPred.Controls.Add(this.LegendGreenPnlPred, 1, 0);
            this.LegendTabLayPred.Controls.Add(this.LegendRedPnlPred, 1, 2);
            this.LegendTabLayPred.Location = new System.Drawing.Point(17, 5);
            this.LegendTabLayPred.Name = "LegendTabLayPred";
            this.LegendTabLayPred.RowCount = 3;
            this.LegendTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LegendTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LegendTabLayPred.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LegendTabLayPred.Size = new System.Drawing.Size(170, 57);
            this.LegendTabLayPred.TabIndex = 0;
            // 
            // ExpenseLblPred
            // 
            this.ExpenseLblPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExpenseLblPred.AutoSize = true;
            this.ExpenseLblPred.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpenseLblPred.ForeColor = System.Drawing.Color.Red;
            this.ExpenseLblPred.Location = new System.Drawing.Point(11, 36);
            this.ExpenseLblPred.Name = "ExpenseLblPred";
            this.ExpenseLblPred.Size = new System.Drawing.Size(63, 20);
            this.ExpenseLblPred.TabIndex = 46;
            this.ExpenseLblPred.Text = "Expense";
            // 
            // LegendOrangePnlPred
            // 
            this.LegendOrangePnlPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegendOrangePnlPred.BackColor = System.Drawing.Color.Orange;
            this.LegendOrangePnlPred.Location = new System.Drawing.Point(113, 22);
            this.LegendOrangePnlPred.Name = "LegendOrangePnlPred";
            this.LegendOrangePnlPred.Size = new System.Drawing.Size(29, 10);
            this.LegendOrangePnlPred.TabIndex = 50;
            // 
            // BudgetLblPred
            // 
            this.BudgetLblPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BudgetLblPred.AutoSize = true;
            this.BudgetLblPred.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BudgetLblPred.ForeColor = System.Drawing.Color.Orange;
            this.BudgetLblPred.Location = new System.Drawing.Point(14, 18);
            this.BudgetLblPred.Name = "BudgetLblPred";
            this.BudgetLblPred.Size = new System.Drawing.Size(57, 18);
            this.BudgetLblPred.TabIndex = 47;
            this.BudgetLblPred.Text = "Budget";
            // 
            // SavingLblPred
            // 
            this.SavingLblPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SavingLblPred.AutoSize = true;
            this.SavingLblPred.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SavingLblPred.ForeColor = System.Drawing.Color.Lime;
            this.SavingLblPred.Location = new System.Drawing.Point(16, 0);
            this.SavingLblPred.Name = "SavingLblPred";
            this.SavingLblPred.Size = new System.Drawing.Size(53, 18);
            this.SavingLblPred.TabIndex = 48;
            this.SavingLblPred.Text = "Saving";
            // 
            // LegendGreenPnlPred
            // 
            this.LegendGreenPnlPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegendGreenPnlPred.BackColor = System.Drawing.Color.Lime;
            this.LegendGreenPnlPred.Location = new System.Drawing.Point(113, 4);
            this.LegendGreenPnlPred.Name = "LegendGreenPnlPred";
            this.LegendGreenPnlPred.Size = new System.Drawing.Size(29, 10);
            this.LegendGreenPnlPred.TabIndex = 50;
            // 
            // LegendRedPnlPred
            // 
            this.LegendRedPnlPred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegendRedPnlPred.BackColor = System.Drawing.Color.Red;
            this.LegendRedPnlPred.Location = new System.Drawing.Point(113, 41);
            this.LegendRedPnlPred.Name = "LegendRedPnlPred";
            this.LegendRedPnlPred.Size = new System.Drawing.Size(29, 10);
            this.LegendRedPnlPred.TabIndex = 49;
            // 
            // PredSavePnlPred
            // 
            this.PredSavePnlPred.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.PredSavePnlPred.BorderRadius = 10;
            this.PredSavePnlPred.BorderThickness = 3;
            this.PredSavePnlPred.Controls.Add(this.PredSaveLblPred);
            this.PredSavePnlPred.Controls.Add(this.PredSavLblPred);
            this.PredSavePnlPred.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.PredSavePnlPred.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PredSavePnlPred.Location = new System.Drawing.Point(223, 86);
            this.PredSavePnlPred.Name = "PredSavePnlPred";
            this.PredSavePnlPred.Size = new System.Drawing.Size(202, 66);
            this.PredSavePnlPred.TabIndex = 59;
            // 
            // PredSpendPnlPred
            // 
            this.PredSpendPnlPred.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.PredSpendPnlPred.BorderRadius = 10;
            this.PredSpendPnlPred.BorderThickness = 3;
            this.PredSpendPnlPred.Controls.Add(this.PredSpenLblPred);
            this.PredSpendPnlPred.Controls.Add(this.PredSpendLblPred);
            this.PredSpendPnlPred.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.PredSpendPnlPred.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PredSpendPnlPred.Location = new System.Drawing.Point(464, 86);
            this.PredSpendPnlPred.Name = "PredSpendPnlPred";
            this.PredSpendPnlPred.Size = new System.Drawing.Size(202, 66);
            this.PredSpendPnlPred.TabIndex = 60;
            // 
            // LegendPnlPred
            // 
            this.LegendPnlPred.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.LegendPnlPred.BorderRadius = 10;
            this.LegendPnlPred.BorderThickness = 3;
            this.LegendPnlPred.Controls.Add(this.LegendTabLayPred);
            this.LegendPnlPred.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.LegendPnlPred.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LegendPnlPred.Location = new System.Drawing.Point(706, 86);
            this.LegendPnlPred.Name = "LegendPnlPred";
            this.LegendPnlPred.Size = new System.Drawing.Size(202, 66);
            this.LegendPnlPred.TabIndex = 61;
            // 
            // ForecastPnlPred
            // 
            this.ForecastPnlPred.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.ForecastPnlPred.BorderRadius = 10;
            this.ForecastPnlPred.BorderThickness = 3;
            this.ForecastPnlPred.Controls.Add(this.ForecastChrtPred);
            this.ForecastPnlPred.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.ForecastPnlPred.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ForecastPnlPred.Location = new System.Drawing.Point(220, 208);
            this.ForecastPnlPred.Name = "ForecastPnlPred";
            this.ForecastPnlPred.Size = new System.Drawing.Size(691, 258);
            this.ForecastPnlPred.TabIndex = 60;
            // 
            // ForecastChrtPred
            // 
            this.ForecastChrtPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ForecastChrtPred.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ForecastChrtPred.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.Interval = 1000D;
            chartArea1.AxisY.LabelStyle.Format = "₱ #,##0";
            chartArea1.AxisY.Maximum = 10000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            chartArea1.Name = "ChartArea1";
            this.ForecastChrtPred.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "DefaultLegend";
            this.ForecastChrtPred.Legends.Add(legend1);
            this.ForecastChrtPred.Location = new System.Drawing.Point(3, 27);
            this.ForecastChrtPred.Name = "ForecastChrtPred";
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
            this.ForecastChrtPred.Series.Add(series1);
            this.ForecastChrtPred.Series.Add(series2);
            this.ForecastChrtPred.Series.Add(series3);
            this.ForecastChrtPred.Size = new System.Drawing.Size(685, 224);
            this.ForecastChrtPred.TabIndex = 6;
            this.ForecastChrtPred.Text = "chart1";
            // 
            // PredictionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(932, 478);
            this.Controls.Add(this.ForecastPnlPred);
            this.Controls.Add(this.LegendPnlPred);
            this.Controls.Add(this.PredSpendPnlPred);
            this.Controls.Add(this.PredSavePnlPred);
            this.Controls.Add(this.lblContextDate);
            this.Controls.Add(this.PredictionLblPred);
            this.Controls.Add(this.MonthlyForecastLblPred);
            this.Controls.Add(this.SidebarTableLayoutPred);
            this.Controls.Add(this.numSelectYearPred);
            this.Controls.Add(this.cbSelectMonthPred);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 525);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 525);
            this.Name = "PredictionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prediction";
            this.Load += new System.EventHandler(this.PredictionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYearPred)).EndInit();
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
            this.LogTabLayPred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogPicBoxPred)).EndInit();
            this.LegendTabLayPred.ResumeLayout(false);
            this.LegendTabLayPred.PerformLayout();
            this.PredSavePnlPred.ResumeLayout(false);
            this.PredSavePnlPred.PerformLayout();
            this.PredSpendPnlPred.ResumeLayout(false);
            this.PredSpendPnlPred.PerformLayout();
            this.LegendPnlPred.ResumeLayout(false);
            this.ForecastPnlPred.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ForecastChrtPred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ComboBox cbSelectMonthPred;
        private System.Windows.Forms.NumericUpDown numSelectYearPred;
        private System.Windows.Forms.Label PredSaveLblPred;
        private System.Windows.Forms.Label PredSpendLblPred;
        private System.Windows.Forms.Label lblContextDate;
        private System.Windows.Forms.Label PredSavLblPred;
        private System.Windows.Forms.Label PredSpenLblPred;
        private System.Windows.Forms.Label MonthlyForecastLblPred;
        private System.Windows.Forms.FlowLayoutPanel SidebarTableLayoutPred;
        private System.Windows.Forms.Panel CentSibleTextPanelGoal;
        private System.Windows.Forms.Label CentSibleLabelPred;
        private System.Windows.Forms.TableLayoutPanel SideBarTabLayPred;
        private System.Windows.Forms.Button LogoutBtnPred;
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
        private System.Windows.Forms.TableLayoutPanel LegendTabLayPred;
        private System.Windows.Forms.Label ExpenseLblPred;
        private System.Windows.Forms.Label SavingLblPred;
        private System.Windows.Forms.Label BudgetLblPred;
        private System.Windows.Forms.FlowLayoutPanel LegendRedPnlPred;
        private System.Windows.Forms.FlowLayoutPanel LegendGreenPnlPred;
        private System.Windows.Forms.FlowLayoutPanel LegendOrangePnlPred;
        private Guna.UI2.WinForms.Guna2Panel PredSavePnlPred;
        private Guna.UI2.WinForms.Guna2Panel PredSpendPnlPred;
        private Guna.UI2.WinForms.Guna2Panel LegendPnlPred;
        private Guna.UI2.WinForms.Guna2Panel ForecastPnlPred;
        private System.Windows.Forms.DataVisualization.Charting.Chart ForecastChrtPred;
        private System.Windows.Forms.TableLayoutPanel LogTabLayPred;
        private System.Windows.Forms.PictureBox LogPicBoxPred;
    }
}