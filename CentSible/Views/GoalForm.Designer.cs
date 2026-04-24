namespace CentSible.Views
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
            this.lblStatusMsg = new System.Windows.Forms.Label();
            this.lblPercentReached = new System.Windows.Forms.Label();
            this.pbGoalProgress = new System.Windows.Forms.ProgressBar();
            this.pbMilestone = new System.Windows.Forms.ProgressBar();
            this.TargetDateDropDownGoal = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateGoal = new System.Windows.Forms.Button();
            this.lblIndicatorSpent = new System.Windows.Forms.Label();
            this.lblIndicatorTarget = new System.Windows.Forms.Label();
            this.lblIndicatorDays = new System.Windows.Forms.Label();
            this.lblMilestoneDesc = new System.Windows.Forms.Label();
            this.lblMilestoneDays = new System.Windows.Forms.Label();
            this.DaysRemainingLabelGoal = new System.Windows.Forms.Label();
            this.lblRightHeader = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.cbSelectMonth = new System.Windows.Forms.ComboBox();
            this.numSelectYear = new System.Windows.Forms.NumericUpDown();
            this.lblGoalsHeader = new System.Windows.Forms.Label();
            this.HomeButtonGoal = new System.Windows.Forms.Button();
            this.SidebarTableLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.LogoutButtonGoal = new System.Windows.Forms.Button();
            this.PredButtonGoal = new System.Windows.Forms.Button();
            this.SumButtonGoal = new System.Windows.Forms.Button();
            this.TranButtonGoal = new System.Windows.Forms.Button();
            this.GoalButtonGoal = new System.Windows.Forms.Button();
            this.CentSibleLabelGoal = new System.Windows.Forms.Label();
            this.MainLayoutGoal = new System.Windows.Forms.TableLayoutPanel();
            this.SpendGoalIndiLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SpendingGoalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GoalHeader = new System.Windows.Forms.TableLayoutPanel();
            this.SpendingGoalLabelGoal = new System.Windows.Forms.Label();
            this.TargetAmountLabelGoal = new System.Windows.Forms.Label();
            this.CurrentAmountLabelGoal = new System.Windows.Forms.Label();
            this.TargetAmountTextGoal = new PlaceholderText.PlaceholderTextBox();
            this.CurrentAmountTextGoal = new PlaceholderText.PlaceholderTextBox();
            this.TargetDateLabelGoal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYear)).BeginInit();
            this.SidebarTableLayoutGoal.SuspendLayout();
            this.MainLayoutGoal.SuspendLayout();
            this.SpendGoalIndiLayout.SuspendLayout();
            this.SpendingGoalLayout.SuspendLayout();
            this.GoalHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpendingTab
            // 
            this.btnSpendingTab.Location = new System.Drawing.Point(409, 3);
            this.btnSpendingTab.Name = "btnSpendingTab";
            this.btnSpendingTab.Size = new System.Drawing.Size(88, 23);
            this.btnSpendingTab.TabIndex = 1;
            this.btnSpendingTab.Text = "Spending";
            this.btnSpendingTab.UseVisualStyleBackColor = true;
            this.btnSpendingTab.Click += new System.EventHandler(this.btnSpendingTab_Click);
            // 
            // btnSavingTab
            // 
            this.btnSavingTab.Location = new System.Drawing.Point(518, 3);
            this.btnSavingTab.Name = "btnSavingTab";
            this.btnSavingTab.Size = new System.Drawing.Size(75, 23);
            this.btnSavingTab.TabIndex = 2;
            this.btnSavingTab.Text = "Saving";
            this.btnSavingTab.UseVisualStyleBackColor = true;
            this.btnSavingTab.Click += new System.EventHandler(this.btnSavingTab_Click);
            // 
            // lblStatusMsg
            // 
            this.lblStatusMsg.AutoSize = true;
            this.lblStatusMsg.Location = new System.Drawing.Point(126, 69);
            this.lblStatusMsg.Name = "lblStatusMsg";
            this.lblStatusMsg.Size = new System.Drawing.Size(104, 16);
            this.lblStatusMsg.TabIndex = 7;
            this.lblStatusMsg.Text = "Status Message";
            // 
            // lblPercentReached
            // 
            this.lblPercentReached.AutoSize = true;
            this.lblPercentReached.Location = new System.Drawing.Point(53, 176);
            this.lblPercentReached.Name = "lblPercentReached";
            this.lblPercentReached.Size = new System.Drawing.Size(22, 16);
            this.lblPercentReached.TabIndex = 10;
            this.lblPercentReached.Text = "% ";
            // 
            // pbGoalProgress
            // 
            this.pbGoalProgress.Location = new System.Drawing.Point(47, 143);
            this.pbGoalProgress.Name = "pbGoalProgress";
            this.pbGoalProgress.Size = new System.Drawing.Size(242, 23);
            this.pbGoalProgress.TabIndex = 11;
            // 
            // pbMilestone
            // 
            this.pbMilestone.Location = new System.Drawing.Point(47, 284);
            this.pbMilestone.Name = "pbMilestone";
            this.pbMilestone.Size = new System.Drawing.Size(242, 23);
            this.pbMilestone.TabIndex = 13;
            // 
            // TargetDateDropDownGoal
            // 
            this.TargetDateDropDownGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TargetDateDropDownGoal.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.TargetDateDropDownGoal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(153)))), ((int)(((byte)(66)))));
            this.TargetDateDropDownGoal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.TargetDateDropDownGoal.Location = new System.Drawing.Point(164, 96);
            this.TargetDateDropDownGoal.Name = "TargetDateDropDownGoal";
            this.TargetDateDropDownGoal.Size = new System.Drawing.Size(94, 22);
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
            this.lblIndicatorSpent.AutoSize = true;
            this.lblIndicatorSpent.Location = new System.Drawing.Point(53, 113);
            this.lblIndicatorSpent.Name = "lblIndicatorSpent";
            this.lblIndicatorSpent.Size = new System.Drawing.Size(49, 16);
            this.lblIndicatorSpent.TabIndex = 18;
            this.lblIndicatorSpent.Text = "Current";
            // 
            // lblIndicatorTarget
            // 
            this.lblIndicatorTarget.AutoSize = true;
            this.lblIndicatorTarget.Location = new System.Drawing.Point(242, 113);
            this.lblIndicatorTarget.Name = "lblIndicatorTarget";
            this.lblIndicatorTarget.Size = new System.Drawing.Size(47, 16);
            this.lblIndicatorTarget.TabIndex = 19;
            this.lblIndicatorTarget.Text = "Target";
            // 
            // lblIndicatorDays
            // 
            this.lblIndicatorDays.AutoSize = true;
            this.lblIndicatorDays.Location = new System.Drawing.Point(196, 176);
            this.lblIndicatorDays.Name = "lblIndicatorDays";
            this.lblIndicatorDays.Size = new System.Drawing.Size(93, 16);
            this.lblIndicatorDays.TabIndex = 20;
            this.lblIndicatorDays.Text = "Indicator Days";
            // 
            // lblMilestoneDesc
            // 
            this.lblMilestoneDesc.AutoSize = true;
            this.lblMilestoneDesc.Location = new System.Drawing.Point(44, 265);
            this.lblMilestoneDesc.Name = "lblMilestoneDesc";
            this.lblMilestoneDesc.Size = new System.Drawing.Size(97, 16);
            this.lblMilestoneDesc.TabIndex = 21;
            this.lblMilestoneDesc.Text = "MilestoneDesc";
            // 
            // lblMilestoneDays
            // 
            this.lblMilestoneDays.AutoSize = true;
            this.lblMilestoneDays.Location = new System.Drawing.Point(215, 310);
            this.lblMilestoneDays.Name = "lblMilestoneDays";
            this.lblMilestoneDays.Size = new System.Drawing.Size(74, 16);
            this.lblMilestoneDays.TabIndex = 22;
            this.lblMilestoneDays.Text = "Days to Go";
            // 
            // DaysRemainingLabelGoal
            // 
            this.DaysRemainingLabelGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DaysRemainingLabelGoal.AutoSize = true;
            this.DaysRemainingLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.DaysRemainingLabelGoal.Location = new System.Drawing.Point(216, 133);
            this.DaysRemainingLabelGoal.Name = "DaysRemainingLabelGoal";
            this.DaysRemainingLabelGoal.Size = new System.Drawing.Size(42, 16);
            this.DaysRemainingLabelGoal.TabIndex = 24;
            this.DaysRemainingLabelGoal.Text = "Days ";
            // 
            // lblRightHeader
            // 
            this.lblRightHeader.AutoSize = true;
            this.lblRightHeader.Location = new System.Drawing.Point(140, 35);
            this.lblRightHeader.Name = "lblRightHeader";
            this.lblRightHeader.Size = new System.Drawing.Size(63, 16);
            this.lblRightHeader.TabIndex = 28;
            this.lblRightHeader.Text = "Header 2";
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.lblRightHeader);
            this.pnlResults.Controls.Add(this.lblMilestoneDesc);
            this.pnlResults.Controls.Add(this.lblMilestoneDays);
            this.pnlResults.Controls.Add(this.lblIndicatorDays);
            this.pnlResults.Controls.Add(this.lblIndicatorTarget);
            this.pnlResults.Controls.Add(this.lblIndicatorSpent);
            this.pnlResults.Controls.Add(this.pbMilestone);
            this.pnlResults.Controls.Add(this.pbGoalProgress);
            this.pnlResults.Controls.Add(this.lblPercentReached);
            this.pnlResults.Controls.Add(this.lblStatusMsg);
            this.pnlResults.Location = new System.Drawing.Point(270, 3);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(346, 261);
            this.pnlResults.TabIndex = 29;
            // 
            // cbSelectMonth
            // 
            this.cbSelectMonth.FormattingEnabled = true;
            this.cbSelectMonth.Items.AddRange(new object[] {
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
            this.cbSelectMonth.Location = new System.Drawing.Point(55, 3);
            this.cbSelectMonth.Name = "cbSelectMonth";
            this.cbSelectMonth.Size = new System.Drawing.Size(91, 24);
            this.cbSelectMonth.TabIndex = 30;
            this.cbSelectMonth.SelectedValueChanged += new System.EventHandler(this.cbSelectMonth_SelectedIndexChanged);
            // 
            // numSelectYear
            // 
            this.numSelectYear.Location = new System.Drawing.Point(260, 3);
            this.numSelectYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numSelectYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numSelectYear.Name = "numSelectYear";
            this.numSelectYear.Size = new System.Drawing.Size(91, 22);
            this.numSelectYear.TabIndex = 31;
            this.numSelectYear.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numSelectYear.ValueChanged += new System.EventHandler(this.numSelectYear_ValueChanged);
            // 
            // lblGoalsHeader
            // 
            this.lblGoalsHeader.AutoSize = true;
            this.lblGoalsHeader.Location = new System.Drawing.Point(3, 0);
            this.lblGoalsHeader.Name = "lblGoalsHeader";
            this.lblGoalsHeader.Size = new System.Drawing.Size(39, 32);
            this.lblGoalsHeader.TabIndex = 32;
            this.lblGoalsHeader.Text = "Goal Date";
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
            this.HomeButtonGoal.Click += new System.EventHandler(this.btnNavHome_Click);
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
            this.MainLayoutGoal.Controls.Add(this.SpendGoalIndiLayout, 0, 1);
            this.MainLayoutGoal.Controls.Add(this.GoalHeader, 0, 0);
            this.MainLayoutGoal.Location = new System.Drawing.Point(174, 50);
            this.MainLayoutGoal.Name = "MainLayoutGoal";
            this.MainLayoutGoal.RowCount = 2;
            this.MainLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.MainLayoutGoal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.MainLayoutGoal.Size = new System.Drawing.Size(625, 399);
            this.MainLayoutGoal.TabIndex = 36;
            // 
            // SpendGoalIndiLayout
            // 
            this.SpendGoalIndiLayout.ColumnCount = 2;
            this.SpendGoalIndiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.13409F));
            this.SpendGoalIndiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.86591F));
            this.SpendGoalIndiLayout.Controls.Add(this.SpendingGoalLayout, 0, 0);
            this.SpendGoalIndiLayout.Controls.Add(this.pnlResults, 1, 0);
            this.SpendGoalIndiLayout.Location = new System.Drawing.Point(3, 129);
            this.SpendGoalIndiLayout.Name = "SpendGoalIndiLayout";
            this.SpendGoalIndiLayout.RowCount = 1;
            this.SpendGoalIndiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SpendGoalIndiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SpendGoalIndiLayout.Size = new System.Drawing.Size(619, 267);
            this.SpendGoalIndiLayout.TabIndex = 0;
            // 
            // SpendingGoalLayout
            // 
            this.SpendingGoalLayout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SpendingGoalLayout.ColumnCount = 2;
            this.SpendingGoalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.40613F));
            this.SpendingGoalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.59387F));
            this.SpendingGoalLayout.Controls.Add(this.SpendingGoalLabelGoal, 0, 0);
            this.SpendingGoalLayout.Controls.Add(this.TargetDateDropDownGoal, 1, 3);
            this.SpendingGoalLayout.Controls.Add(this.DaysRemainingLabelGoal, 1, 4);
            this.SpendingGoalLayout.Controls.Add(this.TargetAmountLabelGoal, 0, 1);
            this.SpendingGoalLayout.Controls.Add(this.CurrentAmountLabelGoal, 0, 2);
            this.SpendingGoalLayout.Controls.Add(this.TargetAmountTextGoal, 1, 1);
            this.SpendingGoalLayout.Controls.Add(this.CurrentAmountTextGoal, 1, 2);
            this.SpendingGoalLayout.Controls.Add(this.TargetDateLabelGoal, 0, 3);
            this.SpendingGoalLayout.Controls.Add(this.label1, 0, 4);
            this.SpendingGoalLayout.Controls.Add(this.btnUpdateGoal, 0, 5);
            this.SpendingGoalLayout.Location = new System.Drawing.Point(3, 3);
            this.SpendingGoalLayout.Name = "SpendingGoalLayout";
            this.SpendingGoalLayout.RowCount = 6;
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SpendingGoalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SpendingGoalLayout.Size = new System.Drawing.Size(261, 261);
            this.SpendingGoalLayout.TabIndex = 37;
            // 
            // GoalHeader
            // 
            this.GoalHeader.ColumnCount = 5;
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.29251F));
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.7075F));
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.GoalHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.GoalHeader.Controls.Add(this.lblGoalsHeader, 0, 0);
            this.GoalHeader.Controls.Add(this.cbSelectMonth, 1, 0);
            this.GoalHeader.Controls.Add(this.btnSavingTab, 4, 0);
            this.GoalHeader.Controls.Add(this.numSelectYear, 2, 0);
            this.GoalHeader.Controls.Add(this.btnSpendingTab, 3, 0);
            this.GoalHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.GoalHeader.Location = new System.Drawing.Point(3, 3);
            this.GoalHeader.Name = "GoalHeader";
            this.GoalHeader.RowCount = 1;
            this.GoalHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GoalHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GoalHeader.Size = new System.Drawing.Size(619, 104);
            this.GoalHeader.TabIndex = 1;
            // 
            // SpendingGoalLabelGoal
            // 
            this.SpendingGoalLabelGoal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SpendingGoalLabelGoal.AutoSize = true;
            this.SpendingGoalLabelGoal.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpendingGoalLabelGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.SpendingGoalLabelGoal.Location = new System.Drawing.Point(3, 1);
            this.SpendingGoalLabelGoal.Name = "SpendingGoalLabelGoal";
            this.SpendingGoalLabelGoal.Size = new System.Drawing.Size(112, 24);
            this.SpendingGoalLabelGoal.TabIndex = 35;
            this.SpendingGoalLabelGoal.Text = "Spending Goal";
            this.SpendingGoalLabelGoal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SpendingGoalLabelGoal.UseWaitCursor = true;
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
            // TargetAmountTextGoal
            // 
            this.TargetAmountTextGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TargetAmountTextGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.TargetAmountTextGoal.Location = new System.Drawing.Point(158, 30);
            this.TargetAmountTextGoal.Name = "TargetAmountTextGoal";
            this.TargetAmountTextGoal.Placeholder = "₱-------";
            this.TargetAmountTextGoal.PlaceholderColor = System.Drawing.Color.Gray;
            this.TargetAmountTextGoal.Size = new System.Drawing.Size(100, 22);
            this.TargetAmountTextGoal.TabIndex = 38;
            // 
            // CurrentAmountTextGoal
            // 
            this.CurrentAmountTextGoal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CurrentAmountTextGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(94)))), ((int)(((byte)(36)))));
            this.CurrentAmountTextGoal.Location = new System.Drawing.Point(160, 61);
            this.CurrentAmountTextGoal.Name = "CurrentAmountTextGoal";
            this.CurrentAmountTextGoal.Placeholder = "₱-------";
            this.CurrentAmountTextGoal.PlaceholderColor = System.Drawing.Color.Gray;
            this.CurrentAmountTextGoal.Size = new System.Drawing.Size(98, 22);
            this.CurrentAmountTextGoal.TabIndex = 39;
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
            // GoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainLayoutGoal);
            this.Controls.Add(this.SidebarTableLayoutGoal);
            this.Name = "GoalForm";
            this.Text = "GoalForm";
            this.Load += new System.EventHandler(this.GoalForm_Load);
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYear)).EndInit();
            this.SidebarTableLayoutGoal.ResumeLayout(false);
            this.SidebarTableLayoutGoal.PerformLayout();
            this.MainLayoutGoal.ResumeLayout(false);
            this.SpendGoalIndiLayout.ResumeLayout(false);
            this.SpendingGoalLayout.ResumeLayout(false);
            this.SpendingGoalLayout.PerformLayout();
            this.GoalHeader.ResumeLayout(false);
            this.GoalHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSpendingTab;
        private System.Windows.Forms.Button btnSavingTab;
        private System.Windows.Forms.Label lblStatusMsg;
        private System.Windows.Forms.Label lblPercentReached;
        private System.Windows.Forms.ProgressBar pbGoalProgress;
        private System.Windows.Forms.ProgressBar pbMilestone;
        private System.Windows.Forms.DateTimePicker TargetDateDropDownGoal;
        private System.Windows.Forms.Button btnUpdateGoal;
        private System.Windows.Forms.Label lblIndicatorSpent;
        private System.Windows.Forms.Label lblIndicatorTarget;
        private System.Windows.Forms.Label lblIndicatorDays;
        private System.Windows.Forms.Label lblMilestoneDesc;
        private System.Windows.Forms.Label lblMilestoneDays;
        private System.Windows.Forms.Label DaysRemainingLabelGoal;
        private System.Windows.Forms.Label lblRightHeader;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.ComboBox cbSelectMonth;
        private System.Windows.Forms.NumericUpDown numSelectYear;
        private System.Windows.Forms.Label lblGoalsHeader;
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
        private System.Windows.Forms.Label SpendingGoalLabelGoal;
        private System.Windows.Forms.Label TargetAmountLabelGoal;
        private System.Windows.Forms.Label CurrentAmountLabelGoal;
        private PlaceholderText.PlaceholderTextBox TargetAmountTextGoal;
        private PlaceholderText.PlaceholderTextBox CurrentAmountTextGoal;
        private System.Windows.Forms.Label TargetDateLabelGoal;
        private System.Windows.Forms.Label label1;
    }
}