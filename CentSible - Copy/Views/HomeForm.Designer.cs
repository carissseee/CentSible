namespace CentSible.Views
{
    partial class HomeForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.lblCentisble = new System.Windows.Forms.Label();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.btnNavPred = new System.Windows.Forms.Button();
            this.btnNavSum = new System.Windows.Forms.Button();
            this.btnNavTrans = new System.Windows.Forms.Button();
            this.btnNavGoal = new System.Windows.Forms.Button();
            this.lblCurrentStreak = new System.Windows.Forms.Label();
            this.lblStreakTitle = new System.Windows.Forms.Label();
            this.pnlMon = new System.Windows.Forms.Panel();
            this.pnlTue = new System.Windows.Forms.Panel();
            this.pnlWed = new System.Windows.Forms.Panel();
            this.pnlThu = new System.Windows.Forms.Panel();
            this.pnlFri = new System.Windows.Forms.Panel();
            this.pnlSat = new System.Windows.Forms.Panel();
            this.pnlSun = new System.Windows.Forms.Panel();
            this.lblLongestStreak = new System.Windows.Forms.Label();
            this.pbMilestone = new System.Windows.Forms.ProgressBar();
            this.pbSpendingHome = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pbSavingHome = new System.Windows.Forms.ProgressBar();
            this.lblSpendingStatus = new System.Windows.Forms.Label();
            this.lblSavingStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnNavHome
            // 
            this.btnNavHome.Location = new System.Drawing.Point(66, 62);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(75, 23);
            this.btnNavHome.TabIndex = 8;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = true;
            this.btnNavHome.Click += new System.EventHandler(this.btnNavHome_Click);
            // 
            // lblCentisble
            // 
            this.lblCentisble.AutoSize = true;
            this.lblCentisble.Location = new System.Drawing.Point(78, 9);
            this.lblCentisble.Name = "lblCentisble";
            this.lblCentisble.Size = new System.Drawing.Size(63, 16);
            this.lblCentisble.TabIndex = 8;
            this.lblCentisble.Text = "Centsible";
            // 
            // btnNavLogout
            // 
            this.btnNavLogout.Location = new System.Drawing.Point(62, 374);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(100, 23);
            this.btnNavLogout.TabIndex = 4;
            this.btnNavLogout.Text = "Log Out";
            this.btnNavLogout.UseVisualStyleBackColor = true;
            this.btnNavLogout.Click += new System.EventHandler(this.btnNavLogout_Click);
            // 
            // btnNavPred
            // 
            this.btnNavPred.Location = new System.Drawing.Point(62, 309);
            this.btnNavPred.Name = "btnNavPred";
            this.btnNavPred.Size = new System.Drawing.Size(100, 23);
            this.btnNavPred.TabIndex = 3;
            this.btnNavPred.Text = "Prediction";
            this.btnNavPred.UseVisualStyleBackColor = true;
            this.btnNavPred.Click += new System.EventHandler(this.btnNavPred_Click);
            // 
            // btnNavSum
            // 
            this.btnNavSum.Location = new System.Drawing.Point(62, 248);
            this.btnNavSum.Name = "btnNavSum";
            this.btnNavSum.Size = new System.Drawing.Size(100, 23);
            this.btnNavSum.TabIndex = 2;
            this.btnNavSum.Text = "Summary";
            this.btnNavSum.UseVisualStyleBackColor = true;
            this.btnNavSum.Click += new System.EventHandler(this.btnNavSum_Click);
            // 
            // btnNavTrans
            // 
            this.btnNavTrans.Location = new System.Drawing.Point(62, 181);
            this.btnNavTrans.Name = "btnNavTrans";
            this.btnNavTrans.Size = new System.Drawing.Size(100, 23);
            this.btnNavTrans.TabIndex = 1;
            this.btnNavTrans.Text = "Transaction";
            this.btnNavTrans.UseVisualStyleBackColor = true;
            this.btnNavTrans.Click += new System.EventHandler(this.btnNavTrans_Click);
            // 
            // btnNavGoal
            // 
            this.btnNavGoal.Location = new System.Drawing.Point(62, 116);
            this.btnNavGoal.Name = "btnNavGoal";
            this.btnNavGoal.Size = new System.Drawing.Size(100, 23);
            this.btnNavGoal.TabIndex = 0;
            this.btnNavGoal.Text = "Goal";
            this.btnNavGoal.UseVisualStyleBackColor = true;
            this.btnNavGoal.Click += new System.EventHandler(this.btnNavGoal_Click);
            // 
            // lblCurrentStreak
            // 
            this.lblCurrentStreak.AutoSize = true;
            this.lblCurrentStreak.Location = new System.Drawing.Point(246, 116);
            this.lblCurrentStreak.Name = "lblCurrentStreak";
            this.lblCurrentStreak.Size = new System.Drawing.Size(93, 16);
            this.lblCurrentStreak.TabIndex = 1;
            this.lblCurrentStreak.Text = "count of streak";
            // 
            // lblStreakTitle
            // 
            this.lblStreakTitle.AutoSize = true;
            this.lblStreakTitle.Location = new System.Drawing.Point(248, 75);
            this.lblStreakTitle.Name = "lblStreakTitle";
            this.lblStreakTitle.Size = new System.Drawing.Size(91, 16);
            this.lblStreakTitle.TabIndex = 2;
            this.lblStreakTitle.Text = "Current Streak";
            // 
            // pnlMon
            // 
            this.pnlMon.Location = new System.Drawing.Point(400, 75);
            this.pnlMon.Name = "pnlMon";
            this.pnlMon.Size = new System.Drawing.Size(45, 32);
            this.pnlMon.TabIndex = 3;
            // 
            // pnlTue
            // 
            this.pnlTue.Location = new System.Drawing.Point(451, 75);
            this.pnlTue.Name = "pnlTue";
            this.pnlTue.Size = new System.Drawing.Size(45, 32);
            this.pnlTue.TabIndex = 4;
            // 
            // pnlWed
            // 
            this.pnlWed.Location = new System.Drawing.Point(502, 75);
            this.pnlWed.Name = "pnlWed";
            this.pnlWed.Size = new System.Drawing.Size(45, 32);
            this.pnlWed.TabIndex = 5;
            // 
            // pnlThu
            // 
            this.pnlThu.Location = new System.Drawing.Point(553, 75);
            this.pnlThu.Name = "pnlThu";
            this.pnlThu.Size = new System.Drawing.Size(45, 32);
            this.pnlThu.TabIndex = 4;
            // 
            // pnlFri
            // 
            this.pnlFri.Location = new System.Drawing.Point(604, 75);
            this.pnlFri.Name = "pnlFri";
            this.pnlFri.Size = new System.Drawing.Size(45, 32);
            this.pnlFri.TabIndex = 4;
            // 
            // pnlSat
            // 
            this.pnlSat.Location = new System.Drawing.Point(655, 75);
            this.pnlSat.Name = "pnlSat";
            this.pnlSat.Size = new System.Drawing.Size(45, 32);
            this.pnlSat.TabIndex = 4;
            // 
            // pnlSun
            // 
            this.pnlSun.Location = new System.Drawing.Point(706, 75);
            this.pnlSun.Name = "pnlSun";
            this.pnlSun.Size = new System.Drawing.Size(45, 32);
            this.pnlSun.TabIndex = 4;
            // 
            // lblLongestStreak
            // 
            this.lblLongestStreak.AutoSize = true;
            this.lblLongestStreak.Location = new System.Drawing.Point(399, 141);
            this.lblLongestStreak.Name = "lblLongestStreak";
            this.lblLongestStreak.Size = new System.Drawing.Size(97, 16);
            this.lblLongestStreak.TabIndex = 6;
            this.lblLongestStreak.Text = "Longest Streak";
            // 
            // pbMilestone
            // 
            this.pbMilestone.Location = new System.Drawing.Point(400, 160);
            this.pbMilestone.Name = "pbMilestone";
            this.pbMilestone.Size = new System.Drawing.Size(351, 27);
            this.pbMilestone.TabIndex = 7;
            // 
            // pbSpendingHome
            // 
            this.pbSpendingHome.Location = new System.Drawing.Point(468, 288);
            this.pbSpendingHome.Name = "pbSpendingHome";
            this.pbSpendingHome.Size = new System.Drawing.Size(253, 29);
            this.pbSpendingHome.TabIndex = 8;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(627, 323);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(8, 8);
            this.progressBar2.TabIndex = 9;
            // 
            // pbSavingHome
            // 
            this.pbSavingHome.Location = new System.Drawing.Point(468, 356);
            this.pbSavingHome.Name = "pbSavingHome";
            this.pbSavingHome.Size = new System.Drawing.Size(253, 29);
            this.pbSavingHome.TabIndex = 10;
            // 
            // lblSpendingStatus
            // 
            this.lblSpendingStatus.AutoSize = true;
            this.lblSpendingStatus.Location = new System.Drawing.Point(658, 269);
            this.lblSpendingStatus.Name = "lblSpendingStatus";
            this.lblSpendingStatus.Size = new System.Drawing.Size(63, 16);
            this.lblSpendingStatus.TabIndex = 11;
            this.lblSpendingStatus.Text = "spending";
            // 
            // lblSavingStatus
            // 
            this.lblSavingStatus.AutoSize = true;
            this.lblSavingStatus.Location = new System.Drawing.Point(674, 337);
            this.lblSavingStatus.Name = "lblSavingStatus";
            this.lblSavingStatus.Size = new System.Drawing.Size(47, 16);
            this.lblSavingStatus.TabIndex = 12;
            this.lblSavingStatus.Text = "saving";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Spending Goal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Saving Goal";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSavingStatus);
            this.Controls.Add(this.lblSpendingStatus);
            this.Controls.Add(this.pbSavingHome);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pbSpendingHome);
            this.Controls.Add(this.pbMilestone);
            this.Controls.Add(this.lblLongestStreak);
            this.Controls.Add(this.pnlSun);
            this.Controls.Add(this.pnlSat);
            this.Controls.Add(this.pnlFri);
            this.Controls.Add(this.pnlThu);
            this.Controls.Add(this.pnlWed);
            this.Controls.Add(this.pnlTue);
            this.Controls.Add(this.pnlMon);
            this.Controls.Add(this.lblStreakTitle);
            this.Controls.Add(this.lblCurrentStreak);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Activated += new System.EventHandler(this.HomeForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Activated);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Button btnNavPred;
        private System.Windows.Forms.Button btnNavSum;
        private System.Windows.Forms.Button btnNavTrans;
        private System.Windows.Forms.Button btnNavGoal;
        private System.Windows.Forms.Label lblCurrentStreak;
        private System.Windows.Forms.Label lblStreakTitle;
        private System.Windows.Forms.Panel pnlMon;
        private System.Windows.Forms.Panel pnlTue;
        private System.Windows.Forms.Panel pnlWed;
        private System.Windows.Forms.Panel pnlThu;
        private System.Windows.Forms.Panel pnlFri;
        private System.Windows.Forms.Panel pnlSat;
        private System.Windows.Forms.Panel pnlSun;
        private System.Windows.Forms.Label lblLongestStreak;
        private System.Windows.Forms.ProgressBar pbMilestone;
        private System.Windows.Forms.Label lblCentisble;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.ProgressBar pbSpendingHome;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar pbSavingHome;
        private System.Windows.Forms.Label lblSpendingStatus;
        private System.Windows.Forms.Label lblSavingStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}