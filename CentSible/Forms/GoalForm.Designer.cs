namespace CentSible.Forms
{
    partial class GoalForm
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
            this.btnSpendingTab = new System.Windows.Forms.Button();
            this.btnSavingTab = new System.Windows.Forms.Button();
            this.IndicatorPercentLabelGoal = new System.Windows.Forms.Label();
            this.pbGoalProgress = new System.Windows.Forms.ProgressBar();
            this.MilestoneBarGoal = new System.Windows.Forms.ProgressBar();
            this.TargetDateDropDownGoal = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateGoal = new System.Windows.Forms.Button();
            this.lblIndicatorSpent = new System.Windows.Forms.Label();
            this.lblIndicatorTarget = new System.Windows.Forms.Label();
            this.IndicatorDaysLabelGoal = new System.Windows.Forms.Label();
            this.MilestoneDescLabelGoal = new System.Windows.Forms.Label();
            this.DaysToGoLabelGoal = new System.Windows.Forms.Label();
            this.DaysRemainingLabelGoal = new System.Windows.Forms.Label();
            this.dynamicIndicatorLabel = new System.Windows.Forms.Label();
            this.SelectMonthDropGoal = new System.Windows.Forms.ComboBox();
            this.SelectYearDropGoal = new System.Windows.Forms.NumericUpDown();
            this.GoalDateLabelGoal = new System.Windows.Forms.Label();
            this.HomeButtonGoal = new System.Windows.Forms.Button();
            this.SidebarTableLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.LogoutButtonGoal = new System.Windows.Forms.Button();
            this.PredButtonGoal = new System.Windows.Forms.Button();
            this.SumButtonGoal = new System.Windows.Forms.Button();
            this.TranButtonGoal = new System.Windows.Forms.Button();
            this.GoalButtonGoal = new System.Windows.Forms.Button();
            this.CentSibleLabelGoal = new System.Windows.Forms.Label();
            this.MainLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.GoalHeader = new System.Windows.Forms.TableLayoutPanel();
            this.SpendGoalIndiLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SpendingGoalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dynamicGoalLabel = new System.Windows.Forms.Label();
            this.TargetAmountLabelGoal = new System.Windows.Forms.Label();
            this.CurrentAmountLabelGoal = new System.Windows.Forms.Label();
            this.TargetDateLabelGoal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpendIndicatorLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.tableLaIndicatorBarMainLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.IndicatorBarBottomLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.IndicatorBarTopLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.MilestoneLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.TargetAmountTextGoal = new PlaceholderText.PlaceholderTextBox();
            this.CurrentAmountTextGoal = new PlaceholderText.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectYearDropGoal)).BeginInit();
            this.SidebarTableLayoutGoal.SuspendLayout();
            this.MainLayoutGoal.SuspendLayout();
            this.GoalHeader.SuspendLayout();
            this.SpendGoalIndiLayout.SuspendLayout();
            this.SpendingGoalLayout.SuspendLayout();
            this.SpendIndicatorLayoutGoal.SuspendLayout();
            this.tableLaIndicatorBarMainLayoutGoal.SuspendLayout();
            this.IndicatorBarBottomLayoutGoal.SuspendLayout();
            this.IndicatorBarTopLayoutGoal.SuspendLayout();
            this.MilestoneLayoutGoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpendingTab
            // 
            this.btnSpendingTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpendingTab.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.btnSpendingTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.btnSpendingTab.Location = new System.Drawing.Point(379, 3);
            this.btnSpendingTab.Name = "btnSpendingTab";
            this.btnSpendingTab.Size = new System.Drawing.Size(109, 32);
            this.btnSpendingTab.TabIndex = 1;
            this.btnSpendingTab.Text = "Spending";
            this.btnSpendingTab.UseVisualStyleBackColor = true;
            this.btnSpendingTab.Click += new System.EventHandler(this.btnSpendingTab_Click);
            // 
            // btnSavingTab
            // 
            this.btnSavingTab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSavingTab.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.btnSavingTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.btnSavingTab.Location = new System.Drawing.Point(515, 3);
            this.btnSavingTab.Name = "btnSavingTab";
            this.btnSavingTab.Size = new System.Drawing.Size(85, 32);
            this.btnSavingTab.TabIndex = 2;
            this.btnSavingTab.Text = "Saving";
            this.btnSavingTab.UseVisualStyleBackColor = true;
            this.btnSavingTab.Click += new System.EventHandler(this.btnSavingTab_Click);
            // 
            // IndicatorPercentLabelGoal
            // 
            this.IndicatorPercentLabelGoal.AutoSize = true;
            this.IndicatorPercentLabelGoal.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.IndicatorPercentLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.IndicatorPercentLabelGoal.Location = new System.Drawing.Point(3, 0);
            this.IndicatorPercentLabelGoal.Name = "IndicatorPercentLabelGoal";
            this.IndicatorPercentLabelGoal.Size = new System.Drawing.Size(32, 24);
            this.IndicatorPercentLabelGoal.TabIndex = 10;
            this.IndicatorPercentLabelGoal.Text = "% ";
            // 
            // pbGoalProgress
            // 
            this.pbGoalProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbGoalProgress.Location = new System.Drawing.Point(20, 98);
            this.pbGoalProgress.Name = "pbGoalProgress";
            this.pbGoalProgress.Size = new System.Drawing.Size(263, 17);
            this.pbGoalProgress.TabIndex = 11;
            // 
            // MilestoneBarGoal
            // 
            this.MilestoneBarGoal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MilestoneBarGoal.Location = new System.Drawing.Point(20, 46);
            this.MilestoneBarGoal.Name = "MilestoneBarGoal";
            this.MilestoneBarGoal.Size = new System.Drawing.Size(263, 17);
            this.MilestoneBarGoal.TabIndex = 13;
            // 
            // TargetDateDropDownGoal
            // 
            this.TargetDateDropDownGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TargetDateDropDownGoal.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.TargetDateDropDownGoal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.TargetDateDropDownGoal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.TargetDateDropDownGoal.Location = new System.Drawing.Point(160, 96);
            this.TargetDateDropDownGoal.Name = "TargetDateDropDownGoal";
            this.TargetDateDropDownGoal.Size = new System.Drawing.Size(126, 22);
            this.TargetDateDropDownGoal.TabIndex = 16;
            this.TargetDateDropDownGoal.ValueChanged += new System.EventHandler(this.dtpTargetDate_ValueChanged);
            // 
            // btnUpdateGoal
            // 
            this.btnUpdateGoal.Location = new System.Drawing.Point(3, 160);
            this.btnUpdateGoal.Name = "btnUpdateGoal";
            this.btnUpdateGoal.Size = new System.Drawing.Size(75, 29);
            this.btnUpdateGoal.TabIndex = 17;
            this.btnUpdateGoal.Text = "Save";
            this.btnUpdateGoal.UseVisualStyleBackColor = true;
            this.btnUpdateGoal.Click += new System.EventHandler(this.btnUpdateGoal_Click);
            // 
            // lblIndicatorSpent
            // 
            this.lblIndicatorSpent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIndicatorSpent.AutoSize = true;
            this.lblIndicatorSpent.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.lblIndicatorSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.lblIndicatorSpent.Location = new System.Drawing.Point(3, 65);
            this.lblIndicatorSpent.Name = "lblIndicatorSpent";
            this.lblIndicatorSpent.Size = new System.Drawing.Size(72, 24);
            this.lblIndicatorSpent.TabIndex = 18;
            this.lblIndicatorSpent.Text = "Current";
            // 
            // lblIndicatorTarget
            // 
            this.lblIndicatorTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIndicatorTarget.AutoSize = true;
            this.lblIndicatorTarget.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.lblIndicatorTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.lblIndicatorTarget.Location = new System.Drawing.Point(233, 65);
            this.lblIndicatorTarget.Name = "lblIndicatorTarget";
            this.lblIndicatorTarget.Size = new System.Drawing.Size(61, 24);
            this.lblIndicatorTarget.TabIndex = 19;
            this.lblIndicatorTarget.Text = "Target";
            // 
            // IndicatorDaysLabelGoal
            // 
            this.IndicatorDaysLabelGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IndicatorDaysLabelGoal.AutoSize = true;
            this.IndicatorDaysLabelGoal.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.IndicatorDaysLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.IndicatorDaysLabelGoal.Location = new System.Drawing.Point(169, 0);
            this.IndicatorDaysLabelGoal.Name = "IndicatorDaysLabelGoal";
            this.IndicatorDaysLabelGoal.Size = new System.Drawing.Size(125, 24);
            this.IndicatorDaysLabelGoal.TabIndex = 20;
            this.IndicatorDaysLabelGoal.Text = "Indicator Days";
            // 
            // MilestoneDescLabelGoal
            // 
            this.MilestoneDescLabelGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MilestoneDescLabelGoal.AutoSize = true;
            this.MilestoneDescLabelGoal.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.MilestoneDescLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.MilestoneDescLabelGoal.Location = new System.Drawing.Point(3, 19);
            this.MilestoneDescLabelGoal.Name = "MilestoneDescLabelGoal";
            this.MilestoneDescLabelGoal.Size = new System.Drawing.Size(124, 24);
            this.MilestoneDescLabelGoal.TabIndex = 21;
            this.MilestoneDescLabelGoal.Text = "MilestoneDesc";
            // 
            // DaysToGoLabelGoal
            // 
            this.DaysToGoLabelGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DaysToGoLabelGoal.AutoSize = true;
            this.DaysToGoLabelGoal.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.DaysToGoLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.DaysToGoLabelGoal.Location = new System.Drawing.Point(206, 67);
            this.DaysToGoLabelGoal.Name = "DaysToGoLabelGoal";
            this.DaysToGoLabelGoal.Size = new System.Drawing.Size(94, 24);
            this.DaysToGoLabelGoal.TabIndex = 22;
            this.DaysToGoLabelGoal.Text = "Days to Go";
            // 
            // DaysRemainingLabelGoal
            // 
            this.DaysRemainingLabelGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DaysRemainingLabelGoal.AutoSize = true;
            this.DaysRemainingLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.DaysRemainingLabelGoal.Location = new System.Drawing.Point(244, 133);
            this.DaysRemainingLabelGoal.Name = "DaysRemainingLabelGoal";
            this.DaysRemainingLabelGoal.Size = new System.Drawing.Size(42, 16);
            this.DaysRemainingLabelGoal.TabIndex = 24;
            this.DaysRemainingLabelGoal.Text = "Days ";
            // 
            // dynamicIndicatorLabel
            // 
            this.dynamicIndicatorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dynamicIndicatorLabel.AutoSize = true;
            this.dynamicIndicatorLabel.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicIndicatorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.dynamicIndicatorLabel.Location = new System.Drawing.Point(3, 2);
            this.dynamicIndicatorLabel.Name = "dynamicIndicatorLabel";
            this.dynamicIndicatorLabel.Size = new System.Drawing.Size(144, 24);
            this.dynamicIndicatorLabel.TabIndex = 28;
            this.dynamicIndicatorLabel.Text = "Spending Indicator";
            // 
            // SelectMonthDropGoal
            // 
            this.SelectMonthDropGoal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectMonthDropGoal.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.SelectMonthDropGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.SelectMonthDropGoal.FormattingEnabled = true;
            this.SelectMonthDropGoal.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.SelectMonthDropGoal.Location = new System.Drawing.Point(139, 3);
            this.SelectMonthDropGoal.Name = "SelectMonthDropGoal";
            this.SelectMonthDropGoal.Size = new System.Drawing.Size(93, 32);
            this.SelectMonthDropGoal.TabIndex = 30;
            this.SelectMonthDropGoal.Text = "Month";
            this.SelectMonthDropGoal.SelectedValueChanged += new System.EventHandler(this.cbSelectMonth_SelectedIndexChanged);
            // 
            // SelectYearDropGoal
            // 
            this.SelectYearDropGoal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectYearDropGoal.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.SelectYearDropGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.SelectYearDropGoal.Location = new System.Drawing.Point(263, 3);
            this.SelectYearDropGoal.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.SelectYearDropGoal.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SelectYearDropGoal.Name = "SelectYearDropGoal";
            this.SelectYearDropGoal.Size = new System.Drawing.Size(94, 29);
            this.SelectYearDropGoal.TabIndex = 31;
            this.SelectYearDropGoal.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.SelectYearDropGoal.ValueChanged += new System.EventHandler(this.numSelectYear_ValueChanged);
            // 
            // GoalDateLabelGoal
            // 
            this.GoalDateLabelGoal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GoalDateLabelGoal.AutoSize = true;
            this.GoalDateLabelGoal.Font = new System.Drawing.Font("Sitka Text", 10.2F);
            this.GoalDateLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.GoalDateLabelGoal.Location = new System.Drawing.Point(19, 0);
            this.GoalDateLabelGoal.Name = "GoalDateLabelGoal";
            this.GoalDateLabelGoal.Size = new System.Drawing.Size(86, 24);
            this.GoalDateLabelGoal.TabIndex = 32;
            this.GoalDateLabelGoal.Text = "Goal Date";
            // 
            // HomeButtonGoal
            // 
            this.HomeButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.HomeButtonGoal.FlatAppearance.BorderSize = 0;
            this.HomeButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.HomeButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButtonGoal.ForeColor = System.Drawing.Color.White;
            this.HomeButtonGoal.Location = new System.Drawing.Point(3, 68);
            this.HomeButtonGoal.Name = "HomeButtonGoal";
            this.HomeButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.HomeButtonGoal.TabIndex = 8;
            this.HomeButtonGoal.Text = "Home";
            this.HomeButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButtonGoal.UseVisualStyleBackColor = false;
            this.HomeButtonGoal.Click += new System.EventHandler(this.HomeButtonGoal_Click);
            // 
            // SidebarTableLayoutGoal
            // 
            this.SidebarTableLayoutGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SidebarTableLayoutGoal.ColumnCount = 1;
            this.SidebarTableLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SidebarTableLayoutGoal.Controls.Add(this.LogoutButtonGoal, 0, 6);
            this.SidebarTableLayoutGoal.Controls.Add(this.PredButtonGoal, 0, 5);
            this.SidebarTableLayoutGoal.Controls.Add(this.SumButtonGoal, 0, 4);
            this.SidebarTableLayoutGoal.Controls.Add(this.TranButtonGoal, 0, 3);
            this.SidebarTableLayoutGoal.Controls.Add(this.GoalButtonGoal, 0, 2);
            this.SidebarTableLayoutGoal.Controls.Add(this.CentSibleLabelGoal, 0, 0);
            this.SidebarTableLayoutGoal.Controls.Add(this.HomeButtonGoal, 0, 1);
            this.SidebarTableLayoutGoal.Location = new System.Drawing.Point(1, -2);
            this.SidebarTableLayoutGoal.Name = "SidebarTableLayoutGoal";
            this.SidebarTableLayoutGoal.RowCount = 7;
            this.SidebarTableLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.48166F));
            this.SidebarTableLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13716F));
            this.SidebarTableLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13716F));
            this.SidebarTableLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13716F));
            this.SidebarTableLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13716F));
            this.SidebarTableLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13716F));
            this.SidebarTableLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83254F));
            this.SidebarTableLayoutGoal.Size = new System.Drawing.Size(170, 454);
            this.SidebarTableLayoutGoal.TabIndex = 35;
            // 
            // LogoutButtonGoal
            // 
            this.LogoutButtonGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.LogoutButtonGoal.FlatAppearance.BorderSize = 0;
            this.LogoutButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.LogoutButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButtonGoal.ForeColor = System.Drawing.Color.White;
            this.LogoutButtonGoal.Location = new System.Drawing.Point(3, 411);
            this.LogoutButtonGoal.Name = "LogoutButtonGoal";
            this.LogoutButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.LogoutButtonGoal.TabIndex = 15;
            this.LogoutButtonGoal.Text = "Logout";
            this.LogoutButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButtonGoal.UseVisualStyleBackColor = false;
            this.LogoutButtonGoal.Click += new System.EventHandler(this.LogoutButtonGoal_Click);
            // 
            // PredButtonGoal
            // 
            this.PredButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.PredButtonGoal.FlatAppearance.BorderSize = 0;
            this.PredButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.PredButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PredButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PredButtonGoal.ForeColor = System.Drawing.Color.White;
            this.PredButtonGoal.Location = new System.Drawing.Point(3, 252);
            this.PredButtonGoal.Name = "PredButtonGoal";
            this.PredButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.PredButtonGoal.TabIndex = 14;
            this.PredButtonGoal.Text = "Prediction";
            this.PredButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PredButtonGoal.UseVisualStyleBackColor = false;
            this.PredButtonGoal.Click += new System.EventHandler(this.PredButtonGoal_Click);
            // 
            // SumButtonGoal
            // 
            this.SumButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.SumButtonGoal.FlatAppearance.BorderSize = 0;
            this.SumButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.SumButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SumButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumButtonGoal.ForeColor = System.Drawing.Color.White;
            this.SumButtonGoal.Location = new System.Drawing.Point(3, 206);
            this.SumButtonGoal.Name = "SumButtonGoal";
            this.SumButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.SumButtonGoal.TabIndex = 13;
            this.SumButtonGoal.Text = "Summary";
            this.SumButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SumButtonGoal.UseVisualStyleBackColor = false;
            this.SumButtonGoal.Click += new System.EventHandler(this.SumButtonGoal_Click);
            // 
            // TranButtonGoal
            // 
            this.TranButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.TranButtonGoal.FlatAppearance.BorderSize = 0;
            this.TranButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.TranButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranButtonGoal.ForeColor = System.Drawing.Color.White;
            this.TranButtonGoal.Location = new System.Drawing.Point(3, 160);
            this.TranButtonGoal.Name = "TranButtonGoal";
            this.TranButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.TranButtonGoal.TabIndex = 12;
            this.TranButtonGoal.Text = "Transactions";
            this.TranButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TranButtonGoal.UseVisualStyleBackColor = false;
            this.TranButtonGoal.Click += new System.EventHandler(this.TranButtonGoal_Click);
            // 
            // GoalButtonGoal
            // 
            this.GoalButtonGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.GoalButtonGoal.FlatAppearance.BorderSize = 0;
            this.GoalButtonGoal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(242)))), ((int)(((byte)(209)))));
            this.GoalButtonGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoalButtonGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalButtonGoal.ForeColor = System.Drawing.Color.White;
            this.GoalButtonGoal.Location = new System.Drawing.Point(3, 114);
            this.GoalButtonGoal.Name = "GoalButtonGoal";
            this.GoalButtonGoal.Size = new System.Drawing.Size(164, 40);
            this.GoalButtonGoal.TabIndex = 11;
            this.GoalButtonGoal.Text = "Goal";
            this.GoalButtonGoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoalButtonGoal.UseVisualStyleBackColor = false;
            this.GoalButtonGoal.Click += new System.EventHandler(this.GoalButtonGoal_Click);
            // 
            // CentSibleLabelGoal
            // 
            this.CentSibleLabelGoal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CentSibleLabelGoal.AutoSize = true;
            this.CentSibleLabelGoal.Font = new System.Drawing.Font("Brush Script MT", 23F, System.Drawing.FontStyle.Italic);
            this.CentSibleLabelGoal.ForeColor = System.Drawing.Color.White;
            this.CentSibleLabelGoal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CentSibleLabelGoal.Location = new System.Drawing.Point(12, 8);
            this.CentSibleLabelGoal.Name = "CentSibleLabelGoal";
            this.CentSibleLabelGoal.Size = new System.Drawing.Size(146, 48);
            this.CentSibleLabelGoal.TabIndex = 10;
            this.CentSibleLabelGoal.Text = "CentSible";
            this.CentSibleLabelGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainLayoutGoal
            // 
            this.MainLayoutGoal.ColumnCount = 1;
            this.MainLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutGoal.Controls.Add(this.GoalHeader, 0, 0);
            this.MainLayoutGoal.Controls.Add(this.SpendGoalIndiLayout, 0, 1);
            this.MainLayoutGoal.Location = new System.Drawing.Point(174, -2);
            this.MainLayoutGoal.Name = "MainLayoutGoal";
            this.MainLayoutGoal.RowCount = 2;
            this.MainLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.8337F));
            this.MainLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.1663F));
            this.MainLayoutGoal.Size = new System.Drawing.Size(626, 451);
            this.MainLayoutGoal.TabIndex = 36;
            // 
            // GoalHeader
            // 
            this.GoalHeader.ColumnCount = 5;
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.GoalHeader.Controls.Add(this.GoalDateLabelGoal, 0, 0);
            this.GoalHeader.Controls.Add(this.SelectMonthDropGoal, 1, 0);
            this.GoalHeader.Controls.Add(this.btnSavingTab, 4, 0);
            this.GoalHeader.Controls.Add(this.btnSpendingTab, 3, 0);
            this.GoalHeader.Controls.Add(this.SelectYearDropGoal, 2, 0);
            this.GoalHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.GoalHeader.Location = new System.Drawing.Point(3, 3);
            this.GoalHeader.Name = "GoalHeader";
            this.GoalHeader.RowCount = 1;
            this.GoalHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GoalHeader.Size = new System.Drawing.Size(620, 104);
            this.GoalHeader.TabIndex = 1;
            // 
            // SpendGoalIndiLayout
            // 
            this.SpendGoalIndiLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.SpendGoalIndiLayout.ColumnCount = 2;
            this.SpendGoalIndiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.29822F));
            this.SpendGoalIndiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.70178F));
            this.SpendGoalIndiLayout.Controls.Add(this.SpendingGoalLayout, 0, 0);
            this.SpendGoalIndiLayout.Controls.Add(this.SpendIndicatorLayoutGoal, 1, 0);
            this.SpendGoalIndiLayout.Location = new System.Drawing.Point(3, 114);
            this.SpendGoalIndiLayout.Name = "SpendGoalIndiLayout";
            this.SpendGoalIndiLayout.RowCount = 1;
            this.SpendGoalIndiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SpendGoalIndiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SpendGoalIndiLayout.Size = new System.Drawing.Size(620, 333);
            this.SpendGoalIndiLayout.TabIndex = 0;
            // 
            // SpendingGoalLayout
            // 
            this.SpendingGoalLayout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SpendingGoalLayout.ColumnCount = 2;
            this.SpendingGoalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.40613F));
            this.SpendingGoalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.59387F));
            this.SpendingGoalLayout.Controls.Add(this.dynamicGoalLabel, 0, 0);
            this.SpendingGoalLayout.Controls.Add(this.TargetDateDropDownGoal, 1, 3);
            this.SpendingGoalLayout.Controls.Add(this.DaysRemainingLabelGoal, 1, 4);
            this.SpendingGoalLayout.Controls.Add(this.TargetAmountLabelGoal, 0, 1);
            this.SpendingGoalLayout.Controls.Add(this.CurrentAmountLabelGoal, 0, 2);
            this.SpendingGoalLayout.Controls.Add(this.TargetAmountTextGoal, 1, 1);
            this.SpendingGoalLayout.Controls.Add(this.CurrentAmountTextGoal, 1, 2);
            this.SpendingGoalLayout.Controls.Add(this.TargetDateLabelGoal, 0, 3);
            this.SpendingGoalLayout.Controls.Add(this.label1, 0, 4);
            this.SpendingGoalLayout.Controls.Add(this.btnUpdateGoal, 0, 5);
            this.SpendingGoalLayout.Location = new System.Drawing.Point(6, 7);
            this.SpendingGoalLayout.Name = "SpendingGoalLayout";
            this.SpendingGoalLayout.RowCount = 6;
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SpendingGoalLayout.Size = new System.Drawing.Size(289, 320);
            this.SpendingGoalLayout.TabIndex = 37;
            // 
            // dynamicGoalLabel
            // 
            this.dynamicGoalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dynamicGoalLabel.AutoSize = true;
            this.dynamicGoalLabel.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicGoalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.dynamicGoalLabel.Location = new System.Drawing.Point(3, 1);
            this.dynamicGoalLabel.Name = "dynamicGoalLabel";
            this.dynamicGoalLabel.Size = new System.Drawing.Size(112, 24);
            this.dynamicGoalLabel.TabIndex = 35;
            this.dynamicGoalLabel.Text = "Spending Goal";
            this.dynamicGoalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dynamicGoalLabel.UseWaitCursor = true;
            // 
            // TargetAmountLabelGoal
            // 
            this.TargetAmountLabelGoal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TargetAmountLabelGoal.AutoSize = true;
            this.TargetAmountLabelGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetAmountLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.TargetAmountLabelGoal.Location = new System.Drawing.Point(3, 29);
            this.TargetAmountLabelGoal.Name = "TargetAmountLabelGoal";
            this.TargetAmountLabelGoal.Size = new System.Drawing.Size(121, 24);
            this.TargetAmountLabelGoal.TabIndex = 36;
            this.TargetAmountLabelGoal.Text = "Target Amount:";
            this.TargetAmountLabelGoal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TargetAmountLabelGoal.UseWaitCursor = true;
            // 
            // CurrentAmountLabelGoal
            // 
            this.CurrentAmountLabelGoal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CurrentAmountLabelGoal.AutoSize = true;
            this.CurrentAmountLabelGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentAmountLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.CurrentAmountLabelGoal.Location = new System.Drawing.Point(3, 60);
            this.CurrentAmountLabelGoal.Name = "CurrentAmountLabelGoal";
            this.CurrentAmountLabelGoal.Size = new System.Drawing.Size(130, 24);
            this.CurrentAmountLabelGoal.TabIndex = 37;
            this.CurrentAmountLabelGoal.Text = "Current Amount:";
            this.CurrentAmountLabelGoal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CurrentAmountLabelGoal.UseWaitCursor = true;
            // 
            // TargetDateLabelGoal
            // 
            this.TargetDateLabelGoal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TargetDateLabelGoal.AutoSize = true;
            this.TargetDateLabelGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetDateLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.TargetDateLabelGoal.Location = new System.Drawing.Point(3, 95);
            this.TargetDateLabelGoal.Name = "TargetDateLabelGoal";
            this.TargetDateLabelGoal.Size = new System.Drawing.Size(98, 24);
            this.TargetDateLabelGoal.TabIndex = 40;
            this.TargetDateLabelGoal.Text = "Target Date:";
            this.TargetDateLabelGoal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TargetDateLabelGoal.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(3, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Remaining Days:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            // 
            // SpendIndicatorLayoutGoal
            // 
            this.SpendIndicatorLayoutGoal.ColumnCount = 1;
            this.SpendIndicatorLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SpendIndicatorLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SpendIndicatorLayoutGoal.Controls.Add(this.tableLaIndicatorBarMainLayoutGoal, 0, 0);
            this.SpendIndicatorLayoutGoal.Controls.Add(this.MilestoneLayoutGoal, 0, 1);
            this.SpendIndicatorLayoutGoal.Location = new System.Drawing.Point(304, 6);
            this.SpendIndicatorLayoutGoal.Name = "SpendIndicatorLayoutGoal";
            this.SpendIndicatorLayoutGoal.RowCount = 2;
            this.SpendIndicatorLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.SpendIndicatorLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.SpendIndicatorLayoutGoal.Size = new System.Drawing.Size(310, 321);
            this.SpendIndicatorLayoutGoal.TabIndex = 37;
            // 
            // tableLaIndicatorBarMainLayoutGoal
            // 
            this.tableLaIndicatorBarMainLayoutGoal.ColumnCount = 1;
            this.tableLaIndicatorBarMainLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLaIndicatorBarMainLayoutGoal.Controls.Add(this.IndicatorBarBottomLayoutGoal, 0, 2);
            this.tableLaIndicatorBarMainLayoutGoal.Controls.Add(this.IndicatorBarTopLayoutGoal, 0, 0);
            this.tableLaIndicatorBarMainLayoutGoal.Controls.Add(this.pbGoalProgress, 0, 1);
            this.tableLaIndicatorBarMainLayoutGoal.Location = new System.Drawing.Point(3, 3);
            this.tableLaIndicatorBarMainLayoutGoal.Name = "tableLaIndicatorBarMainLayoutGoal";
            this.tableLaIndicatorBarMainLayoutGoal.RowCount = 3;
            this.tableLaIndicatorBarMainLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLaIndicatorBarMainLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLaIndicatorBarMainLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLaIndicatorBarMainLayoutGoal.Size = new System.Drawing.Size(303, 150);
            this.tableLaIndicatorBarMainLayoutGoal.TabIndex = 40;
            // 
            // IndicatorBarBottomLayoutGoal
            // 
            this.IndicatorBarBottomLayoutGoal.ColumnCount = 2;
            this.IndicatorBarBottomLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.17845F));
            this.IndicatorBarBottomLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.82155F));
            this.IndicatorBarBottomLayoutGoal.Controls.Add(this.IndicatorPercentLabelGoal, 0, 0);
            this.IndicatorBarBottomLayoutGoal.Controls.Add(this.IndicatorDaysLabelGoal, 1, 0);
            this.IndicatorBarBottomLayoutGoal.Location = new System.Drawing.Point(3, 121);
            this.IndicatorBarBottomLayoutGoal.Name = "IndicatorBarBottomLayoutGoal";
            this.IndicatorBarBottomLayoutGoal.RowCount = 1;
            this.IndicatorBarBottomLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IndicatorBarBottomLayoutGoal.Size = new System.Drawing.Size(297, 26);
            this.IndicatorBarBottomLayoutGoal.TabIndex = 39;
            // 
            // IndicatorBarTopLayoutGoal
            // 
            this.IndicatorBarTopLayoutGoal.ColumnCount = 2;
            this.IndicatorBarTopLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.97306F));
            this.IndicatorBarTopLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.02694F));
            this.IndicatorBarTopLayoutGoal.Controls.Add(this.dynamicIndicatorLabel, 0, 0);
            this.IndicatorBarTopLayoutGoal.Controls.Add(this.lblIndicatorSpent, 0, 2);
            this.IndicatorBarTopLayoutGoal.Controls.Add(this.lblIndicatorTarget, 1, 2);
            this.IndicatorBarTopLayoutGoal.Location = new System.Drawing.Point(3, 3);
            this.IndicatorBarTopLayoutGoal.Name = "IndicatorBarTopLayoutGoal";
            this.IndicatorBarTopLayoutGoal.RowCount = 3;
            this.IndicatorBarTopLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.IndicatorBarTopLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.IndicatorBarTopLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.IndicatorBarTopLayoutGoal.Size = new System.Drawing.Size(297, 89);
            this.IndicatorBarTopLayoutGoal.TabIndex = 38;
            // 
            // MilestoneLayoutGoal
            // 
            this.MilestoneLayoutGoal.ColumnCount = 1;
            this.MilestoneLayoutGoal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MilestoneLayoutGoal.Controls.Add(this.DaysToGoLabelGoal, 0, 2);
            this.MilestoneLayoutGoal.Controls.Add(this.MilestoneBarGoal, 0, 1);
            this.MilestoneLayoutGoal.Controls.Add(this.MilestoneDescLabelGoal, 0, 0);
            this.MilestoneLayoutGoal.Location = new System.Drawing.Point(3, 181);
            this.MilestoneLayoutGoal.Name = "MilestoneLayoutGoal";
            this.MilestoneLayoutGoal.RowCount = 3;
            this.MilestoneLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.MilestoneLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.MilestoneLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.MilestoneLayoutGoal.Size = new System.Drawing.Size(303, 137);
            this.MilestoneLayoutGoal.TabIndex = 38;
            // 
            // TargetAmountTextGoal
            // 
            this.TargetAmountTextGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TargetAmountTextGoal.ForeColor = System.Drawing.Color.Gray;
            this.TargetAmountTextGoal.Location = new System.Drawing.Point(197, 30);
            this.TargetAmountTextGoal.Name = "TargetAmountTextGoal";
            this.TargetAmountTextGoal.Placeholder = "₱-------";
            this.TargetAmountTextGoal.PlaceholderColor = System.Drawing.Color.Gray;
            this.TargetAmountTextGoal.Size = new System.Drawing.Size(89, 22);
            this.TargetAmountTextGoal.TabIndex = 38;
            // 
            // CurrentAmountTextGoal
            // 
            this.CurrentAmountTextGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CurrentAmountTextGoal.ForeColor = System.Drawing.Color.Gray;
            this.CurrentAmountTextGoal.Location = new System.Drawing.Point(197, 61);
            this.CurrentAmountTextGoal.Name = "CurrentAmountTextGoal";
            this.CurrentAmountTextGoal.Placeholder = "₱-------";
            this.CurrentAmountTextGoal.PlaceholderColor = System.Drawing.Color.Gray;
            this.CurrentAmountTextGoal.Size = new System.Drawing.Size(89, 22);
            this.CurrentAmountTextGoal.TabIndex = 39;
            // 
            // GoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainLayoutGoal);
            this.Controls.Add(this.SidebarTableLayoutGoal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "GoalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goal";
            this.Load += new System.EventHandler(this.GoalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectYearDropGoal)).EndInit();
            this.SidebarTableLayoutGoal.ResumeLayout(false);
            this.SidebarTableLayoutGoal.PerformLayout();
            this.MainLayoutGoal.ResumeLayout(false);
            this.GoalHeader.ResumeLayout(false);
            this.GoalHeader.PerformLayout();
            this.SpendGoalIndiLayout.ResumeLayout(false);
            this.SpendingGoalLayout.ResumeLayout(false);
            this.SpendingGoalLayout.PerformLayout();
            this.SpendIndicatorLayoutGoal.ResumeLayout(false);
            this.tableLaIndicatorBarMainLayoutGoal.ResumeLayout(false);
            this.IndicatorBarBottomLayoutGoal.ResumeLayout(false);
            this.IndicatorBarBottomLayoutGoal.PerformLayout();
            this.IndicatorBarTopLayoutGoal.ResumeLayout(false);
            this.IndicatorBarTopLayoutGoal.PerformLayout();
            this.MilestoneLayoutGoal.ResumeLayout(false);
            this.MilestoneLayoutGoal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSpendingTab;
        private System.Windows.Forms.Button btnSavingTab;
        private System.Windows.Forms.Label IndicatorPercentLabelGoal;
        private System.Windows.Forms.ProgressBar pbGoalProgress;
        private System.Windows.Forms.ProgressBar MilestoneBarGoal;
        private System.Windows.Forms.DateTimePicker TargetDateDropDownGoal;
        private System.Windows.Forms.Button btnUpdateGoal;
        private System.Windows.Forms.Label lblIndicatorSpent;
        private System.Windows.Forms.Label lblIndicatorTarget;
        private System.Windows.Forms.Label IndicatorDaysLabelGoal;
        private System.Windows.Forms.Label MilestoneDescLabelGoal;
        private System.Windows.Forms.Label DaysToGoLabelGoal;
        private System.Windows.Forms.Label DaysRemainingLabelGoal;
        private System.Windows.Forms.Label dynamicIndicatorLabel;
        private System.Windows.Forms.ComboBox SelectMonthDropGoal;
        private System.Windows.Forms.NumericUpDown SelectYearDropGoal;
        private System.Windows.Forms.Label GoalDateLabelGoal;
        private System.Windows.Forms.Button HomeButtonGoal;
        private System.Windows.Forms.TableLayoutPanel SidebarTableLayoutGoal;
        private System.Windows.Forms.Label CentSibleLabelGoal;
        private System.Windows.Forms.Button GoalButtonGoal;
        private System.Windows.Forms.Button SumButtonGoal;
        private System.Windows.Forms.Button TranButtonGoal;
        private System.Windows.Forms.Button PredButtonGoal;
        private System.Windows.Forms.Button LogoutButtonGoal;
        private System.Windows.Forms.TableLayoutPanel MainLayoutGoal;
        private System.Windows.Forms.TableLayoutPanel SpendGoalIndiLayout;
        private System.Windows.Forms.TableLayoutPanel GoalHeader;
        private System.Windows.Forms.TableLayoutPanel SpendingGoalLayout;
        private System.Windows.Forms.Label dynamicGoalLabel;
        private System.Windows.Forms.Label TargetAmountLabelGoal;
        private System.Windows.Forms.Label CurrentAmountLabelGoal;
        private PlaceholderText.PlaceholderTextBox TargetAmountTextGoal;
        private PlaceholderText.PlaceholderTextBox CurrentAmountTextGoal;
        private System.Windows.Forms.Label TargetDateLabelGoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel SpendIndicatorLayoutGoal;
        private System.Windows.Forms.TableLayoutPanel MilestoneLayoutGoal;
        private System.Windows.Forms.TableLayoutPanel IndicatorBarTopLayoutGoal;
        private System.Windows.Forms.TableLayoutPanel IndicatorBarBottomLayoutGoal;
        private System.Windows.Forms.TableLayoutPanel tableLaIndicatorBarMainLayoutGoal;
    }
}