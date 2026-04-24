namespace CentSible.Views
{
    partial class LoginForms
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.CreateAccountLogin = new System.Windows.Forms.LinkLabel();
            this.UserLabelLogin = new System.Windows.Forms.Label();
            this.PassLabelLogin = new System.Windows.Forms.Label();
            this.MainLayoutLogin = new System.Windows.Forms.TableLayoutPanel();
            this.UserPassLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UserTextLogin = new PlaceholderText.PlaceholderTextBox();
            this.PassTextLogin = new PlaceholderText.PlaceholderTextBox();
            this.DontHaveAccLabelLogin = new System.Windows.Forms.Label();
            this.CentSibleLabelLogin = new System.Windows.Forms.Label();
            this.MainLayoutLogin.SuspendLayout();
            this.UserPassLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.btnLogin.Location = new System.Drawing.Point(334, 294);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 41);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // CreateAccountLogin
            // 
            this.CreateAccountLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateAccountLogin.AutoSize = true;
            this.CreateAccountLogin.Font = new System.Drawing.Font("Sitka Text", 7.8F);
            this.CreateAccountLogin.Location = new System.Drawing.Point(337, 407);
            this.CreateAccountLogin.Name = "CreateAccountLogin";
            this.CreateAccountLogin.Size = new System.Drawing.Size(101, 19);
            this.CreateAccountLogin.TabIndex = 4;
            this.CreateAccountLogin.TabStop = true;
            this.CreateAccountLogin.Text = "Create Account";
            this.CreateAccountLogin.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // UserLabelLogin
            // 
            this.UserLabelLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserLabelLogin.AutoSize = true;
            this.UserLabelLogin.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabelLogin.Location = new System.Drawing.Point(166, 13);
            this.UserLabelLogin.Name = "UserLabelLogin";
            this.UserLabelLogin.Size = new System.Drawing.Size(91, 24);
            this.UserLabelLogin.TabIndex = 5;
            this.UserLabelLogin.Text = "Username: ";
            // 
            // PassLabelLogin
            // 
            this.PassLabelLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PassLabelLogin.AutoSize = true;
            this.PassLabelLogin.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabelLogin.Location = new System.Drawing.Point(171, 63);
            this.PassLabelLogin.Name = "PassLabelLogin";
            this.PassLabelLogin.Size = new System.Drawing.Size(86, 24);
            this.PassLabelLogin.TabIndex = 6;
            this.PassLabelLogin.Text = "Password: ";
            // 
            // MainLayoutLogin
            // 
            this.MainLayoutLogin.ColumnCount = 1;
            this.MainLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutLogin.Controls.Add(this.UserPassLayout, 0, 1);
            this.MainLayoutLogin.Controls.Add(this.btnLogin, 0, 2);
            this.MainLayoutLogin.Controls.Add(this.CreateAccountLogin, 0, 4);
            this.MainLayoutLogin.Controls.Add(this.DontHaveAccLabelLogin, 0, 3);
            this.MainLayoutLogin.Controls.Add(this.CentSibleLabelLogin, 0, 0);
            this.MainLayoutLogin.Location = new System.Drawing.Point(12, 12);
            this.MainLayoutLogin.Name = "MainLayoutLogin";
            this.MainLayoutLogin.RowCount = 5;
            this.MainLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.MainLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.MainLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.MainLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutLogin.Size = new System.Drawing.Size(776, 426);
            this.MainLayoutLogin.TabIndex = 7;
            // 
            // UserPassLayout
            // 
            this.UserPassLayout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UserPassLayout.ColumnCount = 2;
            this.UserPassLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.76624F));
            this.UserPassLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.23376F));
            this.UserPassLayout.Controls.Add(this.UserLabelLogin, 0, 0);
            this.UserPassLayout.Controls.Add(this.PassLabelLogin, 0, 1);
            this.UserPassLayout.Controls.Add(this.UserTextLogin, 1, 0);
            this.UserPassLayout.Controls.Add(this.PassTextLogin, 1, 1);
            this.UserPassLayout.Location = new System.Drawing.Point(3, 168);
            this.UserPassLayout.Name = "UserPassLayout";
            this.UserPassLayout.RowCount = 2;
            this.UserPassLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserPassLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UserPassLayout.Size = new System.Drawing.Size(770, 101);
            this.UserPassLayout.TabIndex = 8;
            // 
            // UserTextLogin
            // 
            this.UserTextLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserTextLogin.ForeColor = System.Drawing.Color.Gray;
            this.UserTextLogin.Location = new System.Drawing.Point(263, 14);
            this.UserTextLogin.Name = "UserTextLogin";
            this.UserTextLogin.Placeholder = "Enter username";
            this.UserTextLogin.PlaceholderColor = System.Drawing.Color.Gray;
            this.UserTextLogin.Size = new System.Drawing.Size(338, 22);
            this.UserTextLogin.TabIndex = 7;
            // 
            // PassTextLogin
            // 
            this.PassTextLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PassTextLogin.ForeColor = System.Drawing.Color.Gray;
            this.PassTextLogin.Location = new System.Drawing.Point(263, 64);
            this.PassTextLogin.Name = "PassTextLogin";
            this.PassTextLogin.Placeholder = "Enter password";
            this.PassTextLogin.PlaceholderColor = System.Drawing.Color.Gray;
            this.PassTextLogin.Size = new System.Drawing.Size(338, 22);
            this.PassTextLogin.TabIndex = 8;
            // 
            // DontHaveAccLabelLogin
            // 
            this.DontHaveAccLabelLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DontHaveAccLabelLogin.AutoSize = true;
            this.DontHaveAccLabelLogin.Font = new System.Drawing.Font("Sitka Text", 7.8F);
            this.DontHaveAccLabelLogin.Location = new System.Drawing.Point(312, 387);
            this.DontHaveAccLabelLogin.Name = "DontHaveAccLabelLogin";
            this.DontHaveAccLabelLogin.Size = new System.Drawing.Size(151, 19);
            this.DontHaveAccLabelLogin.TabIndex = 10;
            this.DontHaveAccLabelLogin.Text = "Don\'t have an account?";
            // 
            // CentSibleLabelLogin
            // 
            this.CentSibleLabelLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CentSibleLabelLogin.AutoSize = true;
            this.CentSibleLabelLogin.Font = new System.Drawing.Font("Brush Script MT", 65F, System.Drawing.FontStyle.Italic);
            this.CentSibleLabelLogin.Location = new System.Drawing.Point(183, 31);
            this.CentSibleLabelLogin.Name = "CentSibleLabelLogin";
            this.CentSibleLabelLogin.Size = new System.Drawing.Size(409, 134);
            this.CentSibleLabelLogin.TabIndex = 9;
            this.CentSibleLabelLogin.Text = "CentSible";
            this.CentSibleLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainLayoutLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "LoginForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForms_Load);
            this.MainLayoutLogin.ResumeLayout(false);
            this.MainLayoutLogin.PerformLayout();
            this.UserPassLayout.ResumeLayout(false);
            this.UserPassLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel CreateAccountLogin;
        private System.Windows.Forms.Label UserLabelLogin;
        private System.Windows.Forms.Label PassLabelLogin;
        private System.Windows.Forms.TableLayoutPanel MainLayoutLogin;
        private System.Windows.Forms.TableLayoutPanel UserPassLayout;
        private System.Windows.Forms.Label CentSibleLabelLogin;
        private System.Windows.Forms.Label DontHaveAccLabelLogin;
        private PlaceholderText.PlaceholderTextBox UserTextLogin;
        private PlaceholderText.PlaceholderTextBox PassTextLogin;
    }
}