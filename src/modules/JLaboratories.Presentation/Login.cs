using System;
using System.Windows.Forms;
using JLaboratories.Entity;
using JLaboratories.Business;
using JLaboratories.Data;

namespace JLaboratories.Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SetPasswordChar();
        }

        // This method sets the password character for the password textbox
        private void SetPasswordChar()
        {
            TxtPassword.UseSystemPasswordChar = true; // Hide password by default
        }

        // This method is called when the user clicks the "Exit" button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // This method is called when the user clicks the "OK" button
        private void BtnOk_Click(object sender, EventArgs e)
        {
            // Get username and password
            var username = CmbUser.SelectedItem?.ToString()?.Trim() ?? string.Empty;
            var password = TxtPassword.Text?.Trim() ?? string.Empty;

            // Basics validations
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please select a user or entry the correct password",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                // Recover the password encrypted from DB in AES
                var userService = new CB_Users();
                var cipherStored = new CD_Users().GetPasswordHash(username);
                if (cipherStored == null)
                {
                    MessageBox.Show(
                        "User not found.",
                        "Autentication error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // Decrypt the password
                string plainStored;
                try
                {
                    plainStored = AESCrypto.Decrypt(cipherStored);
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Decrypt password error",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }



                // Comparate the password at plain text
                bool isValid = plainStored == password;
                if (!isValid)
                {
                    MessageBox.Show(
                        "User or password incorrect",
                        "Autentication error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    TxtPassword.Clear();
                    TxtPassword.Focus();
                    return;
                }

                // If the password is correct, show the dashboard
                this.Hide();
                var dashboard = new Dashboard();
                dashboard.SetDate(DateTime.Now.ToString("dd/MM/yyyy"));
                dashboard.SetUser(username);
                dashboard.Show();
            }
            catch (Exception ex)
            {
                // Catch any error and show a message
                MessageBox.Show(
                    $"Error in something:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // This method is called when the user clicks the "Show/Hide" button
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        // This method is called when the form loads
        private void Login_Load(object sender, EventArgs e)
        {
            CB_Users userBusiness = new CB_Users();
            var usernames = userBusiness.GetUsernames();
            CmbUser.DataSource = usernames;
        }
    }
}
