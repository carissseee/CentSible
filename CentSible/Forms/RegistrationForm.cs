using System;
using System.Windows.Forms;
using CentSible.Logic;


namespace CentSible.Forms
{
    public partial class RegistrationForm : Form
    {
        private AccountLogic accountLogic = new AccountLogic();

        public RegistrationForm()
        {
            InitializeComponent();
            CreatePassTextRegis.PasswordChar = '\0';
            ConfirmPassTextRegis.PasswordChar = '\0';
            CreatePassTextRegis.TextChanged += CreatePassTextRegis_TextChanged;
            ConfirmPassTextRegis.TextChanged += ConfirmPassTextRegis_TextChanged;
        }

        private void RegistrationForm_Load(object sender, EventArgs e) { }

        private void CreatePassTextRegis_TextChanged(object sender, EventArgs e)
        {
            bool isPlaceholder = CreatePassTextRegis.Text == CreatePassTextRegis.Placeholder || string.IsNullOrWhiteSpace(CreatePassTextRegis.Text);

            CreatePassTextRegis.PasswordChar = isPlaceholder ? '\0' : '*';
        }

        private void ConfirmPassTextRegis_TextChanged(object sender, EventArgs e)
        {
            bool isPlaceholder = ConfirmPassTextRegis.Text == ConfirmPassTextRegis.Placeholder
                                 || string.IsNullOrWhiteSpace(ConfirmPassTextRegis.Text);

            ConfirmPassTextRegis.PasswordChar = isPlaceholder ? '\0' : '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                accountLogic.RegisterUser(CreateUserTextRegis.Text, CreatePassTextRegis.Text, ConfirmPassTextRegis.Text);
                MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void CreateAccountLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}