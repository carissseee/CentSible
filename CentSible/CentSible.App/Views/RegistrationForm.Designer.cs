namespace CentSible.Views
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
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegisterSumbit = new System.Windows.Forms.Button();
            this.createusername = new System.Windows.Forms.Label();
            this.createpassword = new System.Windows.Forms.Label();
            this.confirmpassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(289, 144);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(223, 22);
            this.txtRegUsername.TabIndex = 0;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(289, 195);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(223, 22);
            this.txtRegPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(289, 240);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(223, 22);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // btnRegisterSumbit
            // 
            this.btnRegisterSumbit.Location = new System.Drawing.Point(349, 326);
            this.btnRegisterSumbit.Name = "btnRegisterSumbit";
            this.btnRegisterSumbit.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterSumbit.TabIndex = 3;
            this.btnRegisterSumbit.Text = "Register";
            this.btnRegisterSumbit.UseVisualStyleBackColor = true;
            this.btnRegisterSumbit.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // createusername
            // 
            this.createusername.AutoSize = true;
            this.createusername.Location = new System.Drawing.Point(170, 144);
            this.createusername.Name = "createusername";
            this.createusername.Size = new System.Drawing.Size(113, 16);
            this.createusername.TabIndex = 4;
            this.createusername.Text = "Create Username";
            // 
            // createpassword
            // 
            this.createpassword.AutoSize = true;
            this.createpassword.Location = new System.Drawing.Point(170, 195);
            this.createpassword.Name = "createpassword";
            this.createpassword.Size = new System.Drawing.Size(110, 16);
            this.createpassword.TabIndex = 5;
            this.createpassword.Text = "Create Password";
            // 
            // confirmpassword
            // 
            this.confirmpassword.AutoSize = true;
            this.confirmpassword.Location = new System.Drawing.Point(165, 243);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(115, 16);
            this.confirmpassword.TabIndex = 6;
            this.confirmpassword.Text = "Confirm Password";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.createpassword);
            this.Controls.Add(this.createusername);
            this.Controls.Add(this.btnRegisterSumbit);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegUsername);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegisterSumbit;
        private System.Windows.Forms.Label createusername;
        private System.Windows.Forms.Label createpassword;
        private System.Windows.Forms.Label confirmpassword;
    }
}