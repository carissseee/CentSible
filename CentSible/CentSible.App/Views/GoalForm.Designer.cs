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
            this.lblPercentReached = new System.Windows.Forms.Label();
            this.pbGoalProgress = new System.Windows.Forms.ProgressBar();
            this.pbMilestone = new System.Windows.Forms.ProgressBar();
            this.txtTargetAmount = new System.Windows.Forms.TextBox();
            this.txtCurrentAmount = new System.Windows.Forms.TextBox();
            this.dtpTargetDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateGoal = new System.Windows.Forms.Button();
            this.lblIndicatorSpent = new System.Windows.Forms.Label();
            this.lblIndicatorTarget = new System.Windows.Forms.Label();
            this.lblIndicatorDays = new System.Windows.Forms.Label();
            this.lblMilestoneDesc = new System.Windows.Forms.Label();
            this.lblMilestoneDays = new System.Windows.Forms.Label();
            this.lblLeftHeader = new System.Windows.Forms.Label();
            this.lblDaysRemaining = new System.Windows.Forms.Label();
            this.lblStaticTarget = new System.Windows.Forms.Label();
            this.lblStaticCurrent = new System.Windows.Forms.Label();
            this.lblStaticDate = new System.Windows.Forms.Label();
            this.lblRightHeader = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.cbSelectMonth = new System.Windows.Forms.ComboBox();
            this.numSelectYear = new System.Windows.Forms.NumericUpDown();
            this.lblGoalsHeader = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.lblCentisble = new System.Windows.Forms.Label();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.btnNavPred = new System.Windows.Forms.Button();
            this.btnNavSum = new System.Windows.Forms.Button();
            this.btnNavTrans = new System.Windows.Forms.Button();
            this.btnNavGoal = new System.Windows.Forms.Button();
            this.lblRemainingDays = new System.Windows.Forms.Label();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYear)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpendingTab
            // 
            this.btnSpendingTab.Location = new System.Drawing.Point(590, 34);
            this.btnSpendingTab.Name = "btnSpendingTab";
            this.btnSpendingTab.Size = new System.Drawing.Size(88, 23);
            this.btnSpendingTab.TabIndex = 1;
            this.btnSpendingTab.Text = "Spending";
            this.btnSpendingTab.UseVisualStyleBackColor = true;
            this.btnSpendingTab.Click += new System.EventHandler(this.btnSpendingTab_Click);
            // 
            // btnSavingTab
            // 
            this.btnSavingTab.Location = new System.Drawing.Point(684, 35);
            this.btnSavingTab.Name = "btnSavingTab";
            this.btnSavingTab.Size = new System.Drawing.Size(75, 23);
            this.btnSavingTab.TabIndex = 2;
            this.btnSavingTab.Text = "Saving";
            this.btnSavingTab.UseVisualStyleBackColor = true;
            this.btnSavingTab.Click += new System.EventHandler(this.btnSavingTab_Click);
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
            // txtTargetAmount
            // 
            this.txtTargetAmount.Location = new System.Drawing.Point(310, 129);
            this.txtTargetAmount.Name = "txtTargetAmount";
            this.txtTargetAmount.Size = new System.Drawing.Size(94, 22);
            this.txtTargetAmount.TabIndex = 14;
            // 
            // txtCurrentAmount
            // 
            this.txtCurrentAmount.Location = new System.Drawing.Point(314, 182);
            this.txtCurrentAmount.Name = "txtCurrentAmount";
            this.txtCurrentAmount.Size = new System.Drawing.Size(90, 22);
            this.txtCurrentAmount.TabIndex = 15;
            // 
            // dtpTargetDate
            // 
            this.dtpTargetDate.Location = new System.Drawing.Point(309, 245);
            this.dtpTargetDate.Name = "dtpTargetDate";
            this.dtpTargetDate.Size = new System.Drawing.Size(95, 22);
            this.dtpTargetDate.TabIndex = 16;
            this.dtpTargetDate.ValueChanged += new System.EventHandler(this.dtpTargetDate_ValueChanged);
            // 
            // btnUpdateGoal
            // 
            this.btnUpdateGoal.Location = new System.Drawing.Point(266, 375);
            this.btnUpdateGoal.Name = "btnUpdateGoal";
            this.btnUpdateGoal.Size = new System.Drawing.Size(75, 23);
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
            // lblLeftHeader
            // 
            this.lblLeftHeader.AutoSize = true;
            this.lblLeftHeader.Location = new System.Drawing.Point(225, 91);
            this.lblLeftHeader.Name = "lblLeftHeader";
            this.lblLeftHeader.Size = new System.Drawing.Size(53, 16);
            this.lblLeftHeader.TabIndex = 23;
            this.lblLeftHeader.Text = "Header";
            // 
            // lblDaysRemaining
            // 
            this.lblDaysRemaining.AutoSize = true;
            this.lblDaysRemaining.Location = new System.Drawing.Point(349, 298);
            this.lblDaysRemaining.Name = "lblDaysRemaining";
            this.lblDaysRemaining.Size = new System.Drawing.Size(42, 16);
            this.lblDaysRemaining.TabIndex = 24;
            this.lblDaysRemaining.Text = "Days ";
            // 
            // lblStaticTarget
            // 
            this.lblStaticTarget.AutoSize = true;
            this.lblStaticTarget.Location = new System.Drawing.Point(209, 132);
            this.lblStaticTarget.Name = "lblStaticTarget";
            this.lblStaticTarget.Size = new System.Drawing.Size(95, 16);
            this.lblStaticTarget.TabIndex = 25;
            this.lblStaticTarget.Text = "Target Amount";
            // 
            // lblStaticCurrent
            // 
            this.lblStaticCurrent.AutoSize = true;
            this.lblStaticCurrent.Location = new System.Drawing.Point(214, 188);
            this.lblStaticCurrent.Name = "lblStaticCurrent";
            this.lblStaticCurrent.Size = new System.Drawing.Size(97, 16);
            this.lblStaticCurrent.TabIndex = 26;
            this.lblStaticCurrent.Text = "Current Amount";
            // 
            // lblStaticDate
            // 
            this.lblStaticDate.AutoSize = true;
            this.lblStaticDate.Location = new System.Drawing.Point(214, 250);
            this.lblStaticDate.Name = "lblStaticDate";
            this.lblStaticDate.Size = new System.Drawing.Size(79, 16);
            this.lblStaticDate.TabIndex = 27;
            this.lblStaticDate.Text = "Target Date";
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
            this.pnlResults.Location = new System.Drawing.Point(414, 91);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(345, 347);
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
            this.cbSelectMonth.Location = new System.Drawing.Point(374, 32);
            this.cbSelectMonth.Name = "cbSelectMonth";
            this.cbSelectMonth.Size = new System.Drawing.Size(91, 24);
            this.cbSelectMonth.TabIndex = 30;
            this.cbSelectMonth.SelectedValueChanged += new System.EventHandler(this.cbSelectMonth_SelectedIndexChanged);
            // 
            // numSelectYear
            // 
            this.numSelectYear.Location = new System.Drawing.Point(483, 32);
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
            this.lblGoalsHeader.Location = new System.Drawing.Point(225, 40);
            this.lblGoalsHeader.Name = "lblGoalsHeader";
            this.lblGoalsHeader.Size = new System.Drawing.Size(68, 16);
            this.lblGoalsHeader.TabIndex = 32;
            this.lblGoalsHeader.Text = "Goal Date";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnNavHome);
            this.pnlSidebar.Controls.Add(this.lblCentisble);
            this.pnlSidebar.Controls.Add(this.btnNavLogout);
            this.pnlSidebar.Controls.Add(this.btnNavPred);
            this.pnlSidebar.Controls.Add(this.btnNavSum);
            this.pnlSidebar.Controls.Add(this.btnNavTrans);
            this.pnlSidebar.Controls.Add(this.btnNavGoal);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(207, 450);
            this.pnlSidebar.TabIndex = 33;
            // 
            // btnNavHome
            // 
            this.btnNavHome.Location = new System.Drawing.Point(28, 56);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(100, 23);
            this.btnNavHome.TabIndex = 8;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = true;
            this.btnNavHome.Click += new System.EventHandler(this.btnNavHome_Click);
            // 
            // lblCentisble
            // 
            this.lblCentisble.AutoSize = true;
            this.lblCentisble.Location = new System.Drawing.Point(65, 9);
            this.lblCentisble.Name = "lblCentisble";
            this.lblCentisble.Size = new System.Drawing.Size(63, 16);
            this.lblCentisble.TabIndex = 8;
            this.lblCentisble.Text = "CentSible";
            // 
            // btnNavLogout
            // 
            this.btnNavLogout.Location = new System.Drawing.Point(28, 375);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(100, 23);
            this.btnNavLogout.TabIndex = 4;
            this.btnNavLogout.Text = "Log Out";
            this.btnNavLogout.UseVisualStyleBackColor = true;
            this.btnNavLogout.Click += new System.EventHandler(this.btnNavLogout_Click);
            // 
            // btnNavPred
            // 
            this.btnNavPred.Location = new System.Drawing.Point(28, 308);
            this.btnNavPred.Name = "btnNavPred";
            this.btnNavPred.Size = new System.Drawing.Size(100, 23);
            this.btnNavPred.TabIndex = 3;
            this.btnNavPred.Text = "Prediction";
            this.btnNavPred.UseVisualStyleBackColor = true;
            this.btnNavPred.Click += new System.EventHandler(this.btnNavPred_Click);
            // 
            // btnNavSum
            // 
            this.btnNavSum.Location = new System.Drawing.Point(28, 243);
            this.btnNavSum.Name = "btnNavSum";
            this.btnNavSum.Size = new System.Drawing.Size(100, 23);
            this.btnNavSum.TabIndex = 2;
            this.btnNavSum.Text = "Summary";
            this.btnNavSum.UseVisualStyleBackColor = true;
            this.btnNavSum.Click += new System.EventHandler(this.btnNavSum_Click);
            // 
            // btnNavTrans
            // 
            this.btnNavTrans.Location = new System.Drawing.Point(28, 181);
            this.btnNavTrans.Name = "btnNavTrans";
            this.btnNavTrans.Size = new System.Drawing.Size(100, 23);
            this.btnNavTrans.TabIndex = 1;
            this.btnNavTrans.Text = "Transaction";
            this.btnNavTrans.UseVisualStyleBackColor = true;
            this.btnNavTrans.Click += new System.EventHandler(this.btnNavTrans_Click);
            // 
            // btnNavGoal
            // 
            this.btnNavGoal.Location = new System.Drawing.Point(28, 110);
            this.btnNavGoal.Name = "btnNavGoal";
            this.btnNavGoal.Size = new System.Drawing.Size(100, 23);
            this.btnNavGoal.TabIndex = 0;
            this.btnNavGoal.Text = "Goal";
            this.btnNavGoal.UseVisualStyleBackColor = true;
            this.btnNavGoal.Click += new System.EventHandler(this.btnNavGoal_Click);
            // 
            // lblRemainingDays
            // 
            this.lblRemainingDays.AutoSize = true;
            this.lblRemainingDays.Location = new System.Drawing.Point(213, 298);
            this.lblRemainingDays.Name = "lblRemainingDays";
            this.lblRemainingDays.Size = new System.Drawing.Size(110, 16);
            this.lblRemainingDays.TabIndex = 34;
            this.lblRemainingDays.Text = "Remaining Days:";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRemainingDays);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.lblGoalsHeader);
            this.Controls.Add(this.numSelectYear);
            this.Controls.Add(this.cbSelectMonth);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.lblStaticDate);
            this.Controls.Add(this.lblStaticCurrent);
            this.Controls.Add(this.lblStaticTarget);
            this.Controls.Add(this.lblDaysRemaining);
            this.Controls.Add(this.lblLeftHeader);
            this.Controls.Add(this.btnUpdateGoal);
            this.Controls.Add(this.dtpTargetDate);
            this.Controls.Add(this.txtCurrentAmount);
            this.Controls.Add(this.txtTargetAmount);
            this.Controls.Add(this.btnSavingTab);
            this.Controls.Add(this.btnSpendingTab);
            this.Name = "GoalForm";
            this.Text = "GoalForm";
            this.Load += new System.EventHandler(this.GoalForm_Load);
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSelectYear)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSpendingTab;
        private System.Windows.Forms.Button btnSavingTab;
        private System.Windows.Forms.Label lblPercentReached;
        private System.Windows.Forms.ProgressBar pbGoalProgress;
        private System.Windows.Forms.ProgressBar pbMilestone;
        private System.Windows.Forms.TextBox txtTargetAmount;
        private System.Windows.Forms.TextBox txtCurrentAmount;
        private System.Windows.Forms.DateTimePicker dtpTargetDate;
        private System.Windows.Forms.Button btnUpdateGoal;
        private System.Windows.Forms.Label lblIndicatorSpent;
        private System.Windows.Forms.Label lblIndicatorTarget;
        private System.Windows.Forms.Label lblIndicatorDays;
        private System.Windows.Forms.Label lblMilestoneDesc;
        private System.Windows.Forms.Label lblMilestoneDays;
        private System.Windows.Forms.Label lblLeftHeader;
        private System.Windows.Forms.Label lblDaysRemaining;
        private System.Windows.Forms.Label lblStaticTarget;
        private System.Windows.Forms.Label lblStaticCurrent;
        private System.Windows.Forms.Label lblStaticDate;
        private System.Windows.Forms.Label lblRightHeader;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.ComboBox cbSelectMonth;
        private System.Windows.Forms.NumericUpDown numSelectYear;
        private System.Windows.Forms.Label lblGoalsHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Label lblCentisble;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Button btnNavPred;
        private System.Windows.Forms.Button btnNavSum;
        private System.Windows.Forms.Button btnNavTrans;
        private System.Windows.Forms.Button btnNavGoal;
        private System.Windows.Forms.Label lblRemainingDays;

    }
}