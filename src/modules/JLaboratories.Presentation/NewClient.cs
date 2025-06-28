using System;
using System.Windows.Forms;
using JLaboratories.Business;
using JLaboratories.Entity;

namespace JLaboratories.Presentation
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();

            // when the form loads only the cancel button is enabled
            BtnSave.Enabled = true;
            BtnToAddPC.Enabled = false;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Fields validation obligatory
            var fn = TxtCName.Text.Trim();
            var ln = TxtCLastName.Text.Trim();
            if (string.IsNullOrWhiteSpace(fn) || string.IsNullOrWhiteSpace(ln))
            {
                MessageBox.Show(
                    "Nombre y apellido son obligatorios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Build the client object
            var client = new Client
            {
                FirstName = fn,
                LastName = ln,
                PhoneNumber = string.IsNullOrWhiteSpace(TxtCPhoneNumber.Text)
                              ? string.Empty
                              : TxtCPhoneNumber.Text.Trim(),
                Address = string.IsNullOrWhiteSpace(TxtCAddress.Text)
                              ? string.Empty
                              : TxtCAddress.Text.Trim()
            };

            try
            {
                // Insert the client
                var service = new CB_Clients();
                int newId = service.Add(client);

                MessageBox.Show(
                    $"Cliente creado con ID {newId}.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Inhabilit the buttons
                BtnSave.Enabled = false;
                BtnToAddPC.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al agregar cliente:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnToAddPC_Click(object? sender, EventArgs e)
        {
            this.Hide();
            var addPcForm = new NewPC();
            addPcForm.Show();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
