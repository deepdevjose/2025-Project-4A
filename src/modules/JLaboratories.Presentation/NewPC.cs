using System;
using System.Windows.Forms;
using JLaboratories.Business;
using JLaboratories.Data;
using JLaboratories.Entity;

namespace JLaboratories.Presentation
{
    public partial class NewPC : Form
    {

        public NewPC()
        {
            InitializeComponent();

            // 1) Disable buttons at the start
            BtnSave.Enabled = false;
            BtnToCreateOrder.Enabled = false;

            // 2) Subscribe to events (only once)
            this.Load += NewPC_Load;
            CmbClients.SelectedIndexChanged += CmbClients_SelectedIndexChanged;
            BtnSave.Click += BtnSave_Click;
            BtnToCreateOrder.Click += BtnToCreateOrder_Click;
            BtnCancel.Click += (s, e) => this.Close();
        }

        private void NewPC_Load(object? sender, EventArgs e)
        {
            // Load all clients
            var clients = new CB_Clients().ListAll();
            CmbClients.DataSource = clients;
            CmbClients.DisplayMember = "FullName";  // Ensure your Client entity has this property
            CmbClients.ValueMember = "ClientID";
            CmbClients.SelectedIndex = -1;

            // Disable inputs until a client is selected
            TxtModel.Enabled = false;
            TxtSerialN.Enabled = false;
        }

        private void CmbClients_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Enable textboxes and Save button when a client is selected
            bool hasClient = CmbClients.SelectedIndex >= 0;
            TxtModel.Enabled = hasClient;
            TxtSerialN.Enabled = hasClient;
            BtnSave.Enabled = hasClient;

            // Keep btnToCreateOrder disabled until Save is clicked
            BtnToCreateOrder.Enabled = false;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Validate client
            if (!(CmbClients.SelectedValue is int clientId) || clientId <= 0)
            {
                MessageBox.Show("Select a client.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate model
            var model = TxtModel.Text.Trim();
            if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Model is required.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build PC
            var pc = new PC
            {
                ClientID = clientId,
                Model = model,
                SerialNumber = string.IsNullOrWhiteSpace(TxtSerialN.Text)
                               ? string.Empty
                               : TxtSerialN.Text.Trim()
            };

            try
            {
                // Insert
                var service = new CB_PCs();
                string msg = service.Add(pc);

                MessageBox.Show(msg, "Result",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 1) Disable Save and clear inputs
                BtnSave.Enabled = false;
                TxtModel.Clear();
                TxtSerialN.Clear();
                CmbClients.SelectedIndex = -1;

                // 2) Enable Create Order
                BtnToCreateOrder.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding PC:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnToCreateOrder_Click(object? sender, EventArgs e)
        {
            // Open order creation form
            this.Hide();
            var orderForm = new NewOrder();
            orderForm.Show();
            ;
        }
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "¿Are you sure to cancel?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
