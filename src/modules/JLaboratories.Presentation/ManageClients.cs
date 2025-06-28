using System;
using System.Windows.Forms;
using JLaboratories.Business;
using JLaboratories.Entity;

namespace JLaboratories.Presentation
{
    public partial class ManageClients : Form
    {
        private readonly CB_Clients _clientService = new();

        public ManageClients()
        {
            InitializeComponent();

            // Events callbacks
            this.Load += ManageClients_Load;
            dgvClients.SelectionChanged += DgvClients_SelectionChanged;
            BtnUpdate.Click += BtnUpdate_Click;
            BtnDelete.Click += BtnDelete_Click;
        }

        private void ManageClients_Load(object? sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            var list = _clientService.ListAll();
            dgvClients.DataSource = list;

            // Only show the columns we need
            dgvClients.Columns["ClientID"].Visible = false;
            dgvClients.Columns["PhoneNumber"].Visible = false;
            dgvClients.Columns["Address"].Visible = false;
            dgvClients.Columns["CreatedAt"].Visible = false;

            dgvClients.Columns["FirstName"].HeaderText = "First Name";
            dgvClients.Columns["LastName"].HeaderText = "Last Name";
            dgvClients.AutoResizeColumns();
        }

        private void DgvClients_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;
            if (dgvClients.CurrentRow.DataBoundItem is Client client)
            {
                TxtCName.Text = client.FirstName;
                TxtCLastName.Text = client.LastName;
                TxtCPhoneNumber.Text = client.PhoneNumber;
                TxtCAddress.Text = client.Address;
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;
            if (!(dgvClients.CurrentRow.DataBoundItem is Client client)) return;

            // Read changes in the fields
            client.FirstName = TxtCName.Text.Trim();
            client.LastName = TxtCLastName.Text.Trim();
            client.PhoneNumber = string.IsNullOrWhiteSpace(TxtCPhoneNumber.Text)
                                 ? string.Empty
                                 : TxtCPhoneNumber.Text.Trim();
            client.Address = string.IsNullOrWhiteSpace(TxtCAddress.Text)
                                 ? string.Empty
                                 : TxtCAddress.Text.Trim();

            // Update client
            string msg = _clientService.Update(client);
            MessageBox.Show(msg, "Resultado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reload and clear fields
            LoadClients();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null) return;
            if (!(dgvClients.CurrentRow.DataBoundItem is Client client)) return;

            var result = MessageBox.Show(
                $"¿Eliminar a {client.FirstName} {client.LastName}?\n" +
                "Se eliminarán también sus PCs y órdenes.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            string msg = _clientService.Delete(client.ClientID);
            MessageBox.Show(msg, "Resultado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reload and clear fields
            LoadClients();
            ClearFields();
        }

        private void ClearFields()
        {
            TxtCName.Clear();
            TxtCLastName.Clear();
            TxtCPhoneNumber.Clear();
            TxtCAddress.Clear();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
