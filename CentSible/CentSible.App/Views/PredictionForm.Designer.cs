namespace CentSible.Views
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.lblCentisble = new System.Windows.Forms.Label();
            this.btnNavLogout = new System.Windows.Forms.Button();
            this.btnNavPred = new System.Windows.Forms.Button();
            this.btnNavSum = new System.Windows.Forms.Button();
            this.btnNavTrans = new System.Windows.Forms.Button();
            this.btnNavGoal = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSidebar.TabIndex = 1;
            this.btnNavHome.Location = new System.Drawing.Point(66, 62);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(75, 23);
            this.btnNavHome.TabIndex = 8;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = true;
            this.btnNavHome.Click += new System.EventHandler(this.btnNavHome_Click);
            this.lblCentisble.AutoSize = true;
            this.lblCentisble.Location = new System.Drawing.Point(78, 9);
            this.lblCentisble.Name = "lblCentisble";
            this.lblCentisble.Size = new System.Drawing.Size(63, 16);
            this.lblCentisble.TabIndex = 8;
            this.lblCentisble.Text = "CentSible";
            this.btnNavLogout.Location = new System.Drawing.Point(62, 374);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(100, 23);
            this.btnNavLogout.TabIndex = 4;
            this.btnNavLogout.Text = "Log Out";
            this.btnNavLogout.UseVisualStyleBackColor = true;
            this.btnNavLogout.Click += new System.EventHandler(this.btnNavLogout_Click);
            this.btnNavPred.Location = new System.Drawing.Point(62, 309);
            this.btnNavPred.Name = "btnNavPred";
            this.btnNavPred.Size = new System.Drawing.Size(100, 23);
            this.btnNavPred.TabIndex = 3;
            this.btnNavPred.Text = "Prediction";
            this.btnNavPred.UseVisualStyleBackColor = true;
            this.btnNavPred.Click += new System.EventHandler(this.btnNavPred_Click);
            this.btnNavSum.Location = new System.Drawing.Point(62, 248);
            this.btnNavSum.Name = "btnNavSum";
            this.btnNavSum.Size = new System.Drawing.Size(100, 23);
            this.btnNavSum.TabIndex = 2;
            this.btnNavSum.Text = "Summary";
            this.btnNavSum.UseVisualStyleBackColor = true;
            this.btnNavSum.Click += new System.EventHandler(this.btnNavSum_Click);
            this.btnNavTrans.Location = new System.Drawing.Point(62, 181);
            this.btnNavTrans.Name = "btnNavTrans";
            this.btnNavTrans.Size = new System.Drawing.Size(100, 23);
            this.btnNavTrans.TabIndex = 1;
            this.btnNavTrans.Text = "Transaction";
            this.btnNavTrans.UseVisualStyleBackColor = true;
            this.btnNavTrans.Click += new System.EventHandler(this.btnNavTrans_Click);
            this.btnNavGoal.Location = new System.Drawing.Point(62, 116);
            this.btnNavGoal.Name = "btnNavGoal";
            this.btnNavGoal.Size = new System.Drawing.Size(100, 23);
            this.btnNavGoal.TabIndex = 0;
            this.btnNavGoal.Text = "Goal";
            this.btnNavGoal.UseVisualStyleBackColor = true;
            this.btnNavGoal.Click += new System.EventHandler(this.btnNavGoal_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "PredictionForm";
            this.Text = "PredictionForm";
            this.Load += new System.EventHandler(this.PredictionForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PredictionForm_FormClosing);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Label lblCentisble;
        private System.Windows.Forms.Button btnNavLogout;
        private System.Windows.Forms.Button btnNavPred;
        private System.Windows.Forms.Button btnNavSum;
        private System.Windows.Forms.Button btnNavTrans;
        private System.Windows.Forms.Button btnNavGoal;
    }
}