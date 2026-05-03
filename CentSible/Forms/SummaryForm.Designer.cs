namespace CentSible.Forms
{
    partial class SummaryForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SidebarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CentSibleLabel = new System.Windows.Forms.Label();
            this.HomeButtonGoal = new System.Windows.Forms.Button();
            this.GoalButtonGoal = new System.Windows.Forms.Button();
            this.TranButtonGoal = new System.Windows.Forms.Button();
            this.SumButtonGoal = new System.Windows.Forms.Button();
            this.PredButtonGoal = new System.Windows.Forms.Button();
            this.LogoutButtonGoal = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.chartSummary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlBreakdown = new System.Windows.Forms.Panel();
            this.lblOTotal = new System.Windows.Forms.Label();
            this.lblLTotal = new System.Windows.Forms.Label();
            this.lblHTotal = new System.Windows.Forms.Label();
            this.lblUTotal = new System.Windows.Forms.Label();
            this.lblTTotal = new System.Windows.Forms.Label();
            this.lblFTotal = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.lblLeisure = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblUtilities = new System.Windows.Forms.Label();
            this.lblTransportation = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.pnlOthers = new System.Windows.Forms.Panel();
            this.pnlLeisure = new System.Windows.Forms.Panel();
            this.pnlHealth = new System.Windows.Forms.Panel();
            this.pnlUtilities = new System.Windows.Forms.Panel();
            this.pnlTransportation = new System.Windows.Forms.Panel();
            this.pnlFood = new System.Windows.Forms.Panel();
            this.lblBreakdown = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblMSummary = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.SidebarLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSummary)).BeginInit();
            this.pnlBreakdown.SuspendLayout();
            this.pnlSummary.SuspendLayout();
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
            this.SidebarLayout.Size = new System.Drawing.Size(170, 512);
            this.SidebarLayout.TabIndex = 0;
            // 
            // CentSibleLabel
            // 
            this.CentSibleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CentSibleLabel.AutoSize = true;
            this.CentSibleLabel.Font = new System.Drawing.Font("Brush Script MT", 23F, System.Drawing.FontStyle.Italic);
            this.CentSibleLabel.ForeColor = System.Drawing.Color.White;
            this.CentSibleLabel.Location = new System.Drawing.Point(12, 13);
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
            this.HomeButtonGoal.Location = new System.Drawing.Point(3, 77);
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
            this.GoalButtonGoal.Location = new System.Drawing.Point(3, 128);
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
            this.TranButtonGoal.Location = new System.Drawing.Point(3, 179);
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
            this.SumButtonGoal.Location = new System.Drawing.Point(3, 230);
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
            this.PredButtonGoal.Location = new System.Drawing.Point(3, 281);
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
            this.LogoutButtonGoal.Location = new System.Drawing.Point(3, 469);
            this.LogoutButtonGoal.Name = "LogoutButtonGoal";
            this.LogoutButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.LogoutButtonGoal.TabIndex = 6;
            this.LogoutButtonGoal.Text = "Logout";
            this.LogoutButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButtonGoal.UseVisualStyleBackColor = false;
            this.LogoutButtonGoal.Click += new System.EventHandler(this.LogoutButtonGoal_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(201, 9);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(121, 29);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "Summary";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDate.Location = new System.Drawing.Point(212, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "March 2026";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(723, 16);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.Text = "Year";
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(868, 16);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 4;
            this.cmbMonth.Text = "Month";
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // chartSummary
            // 
            this.chartSummary.BorderlineColor = System.Drawing.Color.DarkGreen;
            this.chartSummary.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartSummary.BorderlineWidth = 2;
            chartArea4.Name = "ChartArea1";
            this.chartSummary.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSummary.Legends.Add(legend4);
            this.chartSummary.Location = new System.Drawing.Point(627, 75);
            this.chartSummary.Name = "chartSummary";
            this.chartSummary.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartSummary.Series.Add(series4);
            this.chartSummary.Size = new System.Drawing.Size(362, 412);
            this.chartSummary.TabIndex = 5;
            this.chartSummary.Text = "Category Breakdown";
            // 
            // pnlBreakdown
            // 
            this.pnlBreakdown.Controls.Add(this.lblOTotal);
            this.pnlBreakdown.Controls.Add(this.lblLTotal);
            this.pnlBreakdown.Controls.Add(this.lblHTotal);
            this.pnlBreakdown.Controls.Add(this.lblUTotal);
            this.pnlBreakdown.Controls.Add(this.lblTTotal);
            this.pnlBreakdown.Controls.Add(this.lblFTotal);
            this.pnlBreakdown.Controls.Add(this.lblOthers);
            this.pnlBreakdown.Controls.Add(this.lblLeisure);
            this.pnlBreakdown.Controls.Add(this.lblHealth);
            this.pnlBreakdown.Controls.Add(this.lblUtilities);
            this.pnlBreakdown.Controls.Add(this.lblTransportation);
            this.pnlBreakdown.Controls.Add(this.lblFood);
            this.pnlBreakdown.Controls.Add(this.pnlOthers);
            this.pnlBreakdown.Controls.Add(this.pnlLeisure);
            this.pnlBreakdown.Controls.Add(this.pnlHealth);
            this.pnlBreakdown.Controls.Add(this.pnlUtilities);
            this.pnlBreakdown.Controls.Add(this.pnlTransportation);
            this.pnlBreakdown.Controls.Add(this.pnlFood);
            this.pnlBreakdown.Controls.Add(this.lblBreakdown);
            this.pnlBreakdown.Location = new System.Drawing.Point(215, 75);
            this.pnlBreakdown.Name = "pnlBreakdown";
            this.pnlBreakdown.Size = new System.Drawing.Size(377, 276);
            this.pnlBreakdown.TabIndex = 6;
            // 
            // lblOTotal
            // 
            this.lblOTotal.AutoSize = true;
            this.lblOTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTotal.Location = new System.Drawing.Point(286, 238);
            this.lblOTotal.Name = "lblOTotal";
            this.lblOTotal.Size = new System.Drawing.Size(49, 16);
            this.lblOTotal.TabIndex = 15;
            this.lblOTotal.Text = "₱ 0.00";
            // 
            // lblLTotal
            // 
            this.lblLTotal.AutoSize = true;
            this.lblLTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLTotal.Location = new System.Drawing.Point(286, 201);
            this.lblLTotal.Name = "lblLTotal";
            this.lblLTotal.Size = new System.Drawing.Size(49, 16);
            this.lblLTotal.TabIndex = 14;
            this.lblLTotal.Text = "₱ 0.00";
            // 
            // lblHTotal
            // 
            this.lblHTotal.AutoSize = true;
            this.lblHTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTotal.Location = new System.Drawing.Point(286, 163);
            this.lblHTotal.Name = "lblHTotal";
            this.lblHTotal.Size = new System.Drawing.Size(49, 16);
            this.lblHTotal.TabIndex = 13;
            this.lblHTotal.Text = "₱ 0.00";
            // 
            // lblUTotal
            // 
            this.lblUTotal.AutoSize = true;
            this.lblUTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUTotal.Location = new System.Drawing.Point(286, 126);
            this.lblUTotal.Name = "lblUTotal";
            this.lblUTotal.Size = new System.Drawing.Size(49, 16);
            this.lblUTotal.TabIndex = 12;
            this.lblUTotal.Text = "₱ 0.00";
            // 
            // lblTTotal
            // 
            this.lblTTotal.AutoSize = true;
            this.lblTTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTotal.Location = new System.Drawing.Point(286, 85);
            this.lblTTotal.Name = "lblTTotal";
            this.lblTTotal.Size = new System.Drawing.Size(49, 16);
            this.lblTTotal.TabIndex = 11;
            this.lblTTotal.Text = "₱ 0.00";
            // 
            // lblFTotal
            // 
            this.lblFTotal.AutoSize = true;
            this.lblFTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTotal.Location = new System.Drawing.Point(286, 45);
            this.lblFTotal.Name = "lblFTotal";
            this.lblFTotal.Size = new System.Drawing.Size(49, 16);
            this.lblFTotal.TabIndex = 10;
            this.lblFTotal.Text = "₱ 0.00";
            // 
            // lblOthers
            // 
            this.lblOthers.AutoSize = true;
            this.lblOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.Location = new System.Drawing.Point(81, 238);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(52, 16);
            this.lblOthers.TabIndex = 9;
            this.lblOthers.Text = "Others";
            // 
            // lblLeisure
            // 
            this.lblLeisure.AutoSize = true;
            this.lblLeisure.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeisure.Location = new System.Drawing.Point(81, 201);
            this.lblLeisure.Name = "lblLeisure";
            this.lblLeisure.Size = new System.Drawing.Size(58, 16);
            this.lblLeisure.TabIndex = 8;
            this.lblLeisure.Text = "Leisure";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(81, 163);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(52, 16);
            this.lblHealth.TabIndex = 7;
            this.lblHealth.Text = "Health";
            // 
            // lblUtilities
            // 
            this.lblUtilities.AutoSize = true;
            this.lblUtilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilities.Location = new System.Drawing.Point(81, 123);
            this.lblUtilities.Name = "lblUtilities";
            this.lblUtilities.Size = new System.Drawing.Size(59, 16);
            this.lblUtilities.TabIndex = 6;
            this.lblUtilities.Text = "Utilities";
            // 
            // lblTransportation
            // 
            this.lblTransportation.AutoSize = true;
            this.lblTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransportation.Location = new System.Drawing.Point(81, 85);
            this.lblTransportation.Name = "lblTransportation";
            this.lblTransportation.Size = new System.Drawing.Size(89, 16);
            this.lblTransportation.TabIndex = 5;
            this.lblTransportation.Text = "Transaction";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(81, 45);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(43, 16);
            this.lblFood.TabIndex = 4;
            this.lblFood.Text = "Food";
            // 
            // pnlOthers
            // 
            this.pnlOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.pnlOthers.Location = new System.Drawing.Point(27, 231);
            this.pnlOthers.Name = "pnlOthers";
            this.pnlOthers.Size = new System.Drawing.Size(39, 33);
            this.pnlOthers.TabIndex = 3;
            // 
            // pnlLeisure
            // 
            this.pnlLeisure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.pnlLeisure.Location = new System.Drawing.Point(27, 192);
            this.pnlLeisure.Name = "pnlLeisure";
            this.pnlLeisure.Size = new System.Drawing.Size(39, 33);
            this.pnlLeisure.TabIndex = 2;
            // 
            // pnlHealth
            // 
            this.pnlHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(141)))), ((int)(((byte)(184)))));
            this.pnlHealth.Location = new System.Drawing.Point(27, 153);
            this.pnlHealth.Name = "pnlHealth";
            this.pnlHealth.Size = new System.Drawing.Size(39, 33);
            this.pnlHealth.TabIndex = 2;
            // 
            // pnlUtilities
            // 
            this.pnlUtilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.pnlUtilities.Location = new System.Drawing.Point(27, 114);
            this.pnlUtilities.Name = "pnlUtilities";
            this.pnlUtilities.Size = new System.Drawing.Size(39, 33);
            this.pnlUtilities.TabIndex = 2;
            // 
            // pnlTransportation
            // 
            this.pnlTransportation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.pnlTransportation.Location = new System.Drawing.Point(27, 75);
            this.pnlTransportation.Name = "pnlTransportation";
            this.pnlTransportation.Size = new System.Drawing.Size(39, 33);
            this.pnlTransportation.TabIndex = 2;
            // 
            // pnlFood
            // 
            this.pnlFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlFood.Location = new System.Drawing.Point(27, 36);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(39, 33);
            this.pnlFood.TabIndex = 1;
            // 
            // lblBreakdown
            // 
            this.lblBreakdown.AutoSize = true;
            this.lblBreakdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakdown.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBreakdown.Location = new System.Drawing.Point(14, 12);
            this.lblBreakdown.Name = "lblBreakdown";
            this.lblBreakdown.Size = new System.Drawing.Size(184, 20);
            this.lblBreakdown.TabIndex = 0;
            this.lblBreakdown.Text = "Spending Breakdown";
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.lblMSummary);
            this.pnlSummary.Controls.Add(this.lblReport);
            this.pnlSummary.Location = new System.Drawing.Point(215, 357);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(377, 130);
            this.pnlSummary.TabIndex = 7;
            // 
            // lblMSummary
            // 
            this.lblMSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSummary.Location = new System.Drawing.Point(24, 32);
            this.lblMSummary.Name = "lblMSummary";
            this.lblMSummary.Size = new System.Drawing.Size(335, 84);
            this.lblMSummary.TabIndex = 16;
            this.lblMSummary.Text = "Report";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblReport.Location = new System.Drawing.Point(14, 12);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(149, 20);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "Summary Report";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1035, 510);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlBreakdown);
            this.Controls.Add(this.chartSummary);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.SidebarLayout);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1053, 557);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1053, 557);
            this.Name = "SummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SummaryForm_FormClosing);
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.SidebarLayout.ResumeLayout(false);
            this.SidebarLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSummary)).EndInit();
            this.pnlBreakdown.ResumeLayout(false);
            this.pnlBreakdown.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
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
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSummary;
        private System.Windows.Forms.Panel pnlBreakdown;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblBreakdown;
        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Panel pnlOthers;
        private System.Windows.Forms.Panel pnlLeisure;
        private System.Windows.Forms.Panel pnlHealth;
        private System.Windows.Forms.Panel pnlUtilities;
        private System.Windows.Forms.Panel pnlTransportation;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Label lblLeisure;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblUtilities;
        private System.Windows.Forms.Label lblTransportation;
        private System.Windows.Forms.Label lblFTotal;
        private System.Windows.Forms.Label lblOTotal;
        private System.Windows.Forms.Label lblLTotal;
        private System.Windows.Forms.Label lblHTotal;
        private System.Windows.Forms.Label lblUTotal;
        private System.Windows.Forms.Label lblTTotal;
        private System.Windows.Forms.Label lblMSummary;
    }
}
