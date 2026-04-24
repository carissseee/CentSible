namespace CentSible.Forms
{
    partial class RegistrationForm
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
            this.CreateUserLabel = new System.Windows.Forms.Label();
            this.CreatePassLabel = new System.Windows.Forms.Label();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.MainRegisLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.CentSibleLabelRegistration = new System.Windows.Forms.Label();
            this.RegisBtnRegis = new System.Windows.Forms.Button();
            this.RegisLabelLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.ConfirmPassTextRegis = new PlaceholderText.PlaceholderTextBox();
            this.CreatePassTextRegis = new PlaceholderText.PlaceholderTextBox();
            this.CreateUserTextRegis = new PlaceholderText.PlaceholderTextBox();
            this.BackToLoginBtn = new System.Windows.Forms.Label();
            this.LoginLabelRegistration = new System.Windows.Forms.LinkLabel();
            this.MainRegisLayoutTable.SuspendLayout();
            this.RegisLabelLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateUserLabel
            // 
            this.CreateUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CreateUserLabel.AutoSize = true;
            this.CreateUserLabel.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserLabel.Location = new System.Drawing.Point(158, 7);
            this.CreateUserLabel.Name = "CreateUserLabel";
            this.CreateUserLabel.Size = new System.Drawing.Size(137, 24);
            this.CreateUserLabel.TabIndex = 4;
            this.CreateUserLabel.Text = "Create Username:";
            // 
            // CreatePassLabel
            // 
            this.CreatePassLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CreatePassLabel.AutoSize = true;
            this.CreatePassLabel.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePassLabel.Location = new System.Drawing.Point(163, 46);
            this.CreatePassLabel.Name = "CreatePassLabel";
            this.CreatePassLabel.Size = new System.Drawing.Size(132, 24);
            this.CreatePassLabel.TabIndex = 5;
            this.CreatePassLabel.Text = "Create Password:";
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(152, 86);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(143, 24);
            this.ConfirmPassLabel.TabIndex = 6;
            this.ConfirmPassLabel.Text = "Confirm Password:";
            // 
            // MainRegisLayoutTable
            // 
            this.MainRegisLayoutTable.ColumnCount = 1;
            this.MainRegisLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainRegisLayoutTable.Controls.Add(this.CentSibleLabelRegistration, 0, 0);
            this.MainRegisLayoutTable.Controls.Add(this.RegisBtnRegis, 0, 2);
            this.MainRegisLayoutTable.Controls.Add(this.RegisLabelLayoutTable, 0, 1);
            this.MainRegisLayoutTable.Controls.Add(this.BackToLoginBtn, 0, 3);
            this.MainRegisLayoutTable.Controls.Add(this.LoginLabelRegistration, 0, 4);
            this.MainRegisLayoutTable.Location = new System.Drawing.Point(12, 12);
            this.MainRegisLayoutTable.Name = "MainRegisLayoutTable";
            this.MainRegisLayoutTable.RowCount = 5;
            this.MainRegisLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.MainRegisLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.MainRegisLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.MainRegisLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.MainRegisLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.MainRegisLayoutTable.Size = new System.Drawing.Size(776, 426);
            this.MainRegisLayoutTable.TabIndex = 7;
            // 
            // CentSibleLabelRegistration
            // 
            this.CentSibleLabelRegistration.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CentSibleLabelRegistration.AutoSize = true;
            this.CentSibleLabelRegistration.Font = new System.Drawing.Font("Brush Script MT", 65F, System.Drawing.FontStyle.Italic);
            this.CentSibleLabelRegistration.Location = new System.Drawing.Point(183, 31);
            this.CentSibleLabelRegistration.Name = "CentSibleLabelRegistration";
            this.CentSibleLabelRegistration.Size = new System.Drawing.Size(409, 134);
            this.CentSibleLabelRegistration.TabIndex = 10;
            this.CentSibleLabelRegistration.Text = "CentSible";
            this.CentSibleLabelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisBtnRegis
            // 
            this.RegisBtnRegis.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RegisBtnRegis.Location = new System.Drawing.Point(337, 304);
            this.RegisBtnRegis.Name = "RegisBtnRegis";
            this.RegisBtnRegis.Size = new System.Drawing.Size(101, 34);
            this.RegisBtnRegis.TabIndex = 3;
            this.RegisBtnRegis.Text = "Register";
            this.RegisBtnRegis.UseVisualStyleBackColor = true;
            this.RegisBtnRegis.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisLabelLayoutTable
            // 
            this.RegisLabelLayoutTable.ColumnCount = 2;
            this.RegisLabelLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.7013F));
            this.RegisLabelLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.2987F));
            this.RegisLabelLayoutTable.Controls.Add(this.ConfirmPassTextRegis, 1, 2);
            this.RegisLabelLayoutTable.Controls.Add(this.CreatePassTextRegis, 1, 1);
            this.RegisLabelLayoutTable.Controls.Add(this.ConfirmPassLabel, 0, 2);
            this.RegisLabelLayoutTable.Controls.Add(this.CreatePassLabel, 0, 1);
            this.RegisLabelLayoutTable.Controls.Add(this.CreateUserLabel, 0, 0);
            this.RegisLabelLayoutTable.Controls.Add(this.CreateUserTextRegis, 1, 0);
            this.RegisLabelLayoutTable.Location = new System.Drawing.Point(3, 168);
            this.RegisLabelLayoutTable.Name = "RegisLabelLayoutTable";
            this.RegisLabelLayoutTable.RowCount = 3;
            this.RegisLabelLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.RegisLabelLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.RegisLabelLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33556F));
            this.RegisLabelLayoutTable.Size = new System.Drawing.Size(770, 119);
            this.RegisLabelLayoutTable.TabIndex = 8;
            // 
            // ConfirmPassTextRegis
            // 
            this.ConfirmPassTextRegis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConfirmPassTextRegis.ForeColor = System.Drawing.Color.Gray;
            this.ConfirmPassTextRegis.Location = new System.Drawing.Point(301, 87);
            this.ConfirmPassTextRegis.Name = "ConfirmPassTextRegis";
            this.ConfirmPassTextRegis.PasswordChar = '*';
            this.ConfirmPassTextRegis.Placeholder = "Enter password";
            this.ConfirmPassTextRegis.PlaceholderColor = System.Drawing.Color.Gray;
            this.ConfirmPassTextRegis.Size = new System.Drawing.Size(308, 22);
            this.ConfirmPassTextRegis.TabIndex = 1;
            // 
            // CreatePassTextRegis
            // 
            this.CreatePassTextRegis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatePassTextRegis.ForeColor = System.Drawing.Color.Gray;
            this.CreatePassTextRegis.Location = new System.Drawing.Point(301, 47);
            this.CreatePassTextRegis.Name = "CreatePassTextRegis";
            this.CreatePassTextRegis.PasswordChar = '*';
            this.CreatePassTextRegis.Placeholder = "Enter password";
            this.CreatePassTextRegis.PlaceholderColor = System.Drawing.Color.Gray;
            this.CreatePassTextRegis.Size = new System.Drawing.Size(308, 22);
            this.CreatePassTextRegis.TabIndex = 1;
            // 
            // CreateUserTextRegis
            // 
            this.CreateUserTextRegis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreateUserTextRegis.ForeColor = System.Drawing.Color.Gray;
            this.CreateUserTextRegis.Location = new System.Drawing.Point(301, 8);
            this.CreateUserTextRegis.Name = "CreateUserTextRegis";
            this.CreateUserTextRegis.Placeholder = "Enter username";
            this.CreateUserTextRegis.PlaceholderColor = System.Drawing.Color.Gray;
            this.CreateUserTextRegis.Size = new System.Drawing.Size(308, 22);
            this.CreateUserTextRegis.TabIndex = 8;
            // 
            // BackToLoginBtn
            // 
            this.BackToLoginBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackToLoginBtn.AutoSize = true;
            this.BackToLoginBtn.Font = new System.Drawing.Font("Sitka Text", 7.8F);
            this.BackToLoginBtn.Location = new System.Drawing.Point(305, 389);
            this.BackToLoginBtn.Name = "BackToLoginBtn";
            this.BackToLoginBtn.Size = new System.Drawing.Size(165, 19);
            this.BackToLoginBtn.TabIndex = 11;
            this.BackToLoginBtn.Text = "Already have an account?";
            // 
            // LoginLabelRegistration
            // 
            this.LoginLabelRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabelRegistration.AutoSize = true;
            this.LoginLabelRegistration.Font = new System.Drawing.Font("Sitka Text", 7.8F);
            this.LoginLabelRegistration.Location = new System.Drawing.Point(364, 408);
            this.LoginLabelRegistration.Name = "LoginLabelRegistration";
            this.LoginLabelRegistration.Size = new System.Drawing.Size(48, 18);
            this.LoginLabelRegistration.TabIndex = 12;
            this.LoginLabelRegistration.TabStop = true;
            this.LoginLabelRegistration.Text = "Log In";
            this.LoginLabelRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountLogin_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainRegisLayoutTable);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.MainRegisLayoutTable.ResumeLayout(false);
            this.MainRegisLayoutTable.PerformLayout();
            this.RegisLabelLayoutTable.ResumeLayout(false);
            this.RegisLabelLayoutTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CreateUserLabel;
        private System.Windows.Forms.Label CreatePassLabel;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.TableLayoutPanel MainRegisLayoutTable;
        private System.Windows.Forms.TableLayoutPanel RegisLabelLayoutTable;
        private System.Windows.Forms.Button RegisBtnRegis;
        private System.Windows.Forms.Label CentSibleLabelRegistration;
        private System.Windows.Forms.Label BackToLoginBtn;
        private System.Windows.Forms.LinkLabel LoginLabelRegistration;
        private PlaceholderText.PlaceholderTextBox CreateUserTextRegis;
        private PlaceholderText.PlaceholderTextBox ConfirmPassTextRegis;
        private PlaceholderText.PlaceholderTextBox CreatePassTextRegis;
    }
}