using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JLaboratories.Business;
using JLaboratories.Data;
using JLaboratories.Entity;

namespace JLaboratories.Presentation
{
    public partial class ManagePCs : Form
    {
        // Business logic
        private readonly CB_Clients _clientService = new CB_Clients();
        private readonly CB_PCs _pcService = new CB_PCs();

        public ManagePCs()
        {
            InitializeComponent();

            // Subscribe to events
            this.Load += ManagePCs_Load;
            BtnRefresh.Click += BtnRefresh_Click;
            dgvPCList.SelectionChanged += DgvPCs_SelectionChanged;
            BtnUpdate.Click += BtnUpdate_Click;
            BtnDelete.Click += BtnDelete_Click;

            // Initial state of buttons
            BtnRefresh.Enabled = true;
        }

        private void ManagePCs_Load(object? sender, EventArgs e)
        {
            // Load the combo box with clients
            var clients = _clientService.ListAll();
            CmbUser.DataSource = clients;
            CmbUser.DisplayMember = "FullName";
            CmbUser.ValueMember = "ClientID";
            CmbUser.SelectedIndex = -1;

            // Show all PCs
            LoadAllPCs(clients);
        }

        private void LoadAllPCs(IEnumerable<Client> clients)
        {
            // Refresh the DataGridView with all PCs
            var all = new List<PC>();
            foreach (var c in clients)
                all.AddRange(_pcService.ListByClient(c.ClientID));

            dgvPCList.DataSource = all;
            FormatGrid();
        }

        private void BtnRefresh_Click(object? sender, EventArgs? e)
        {
            try
            {
                if (CmbUser.SelectedValue is int cid && cid > 0)
                {
                    // Client selected, filter by client
                    var pcs = _pcService.ListByClient(cid);
                    dgvPCList.DataSource = pcs;
                }
                else
                {
                    // Refresh all if no client is selected
                    var clients = _clientService.ListAll();
                    LoadAllPCs(clients);
                }

                // Inhabilit the buttons
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar PCs:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPCs_SelectionChanged(object? sender, EventArgs e)
        {
            // allow only one row to be selected
            if (dgvPCList.CurrentRow == null)
                return;

            var row = dgvPCList.CurrentRow;
            TxtModel.Text = row.Cells["Model"].Value?.ToString() ?? "";
            TxtSerialNumber.Text = row.Cells["SerialNumber"].Value?.ToString() ?? "";

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvPCList.CurrentRow == null) return;

            int pcId = Convert.ToInt32(dgvPCList.CurrentRow.Cells["PCID"].Value);
            var pc = new PC
            {
                PCID = pcId,
                Model = TxtModel.Text.Trim(),
                SerialNumber = TxtSerialNumber.Text.Trim()
            };

            try
            {
                string msg = _pcService.Update(pc);
                MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnRefresh_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar PC:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvPCList.CurrentRow == null)
            {
                MessageBox.Show("Selecciona primero una PC.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedPCId = Convert.ToInt32(dgvPCList.CurrentRow.Cells["PCID"].Value);

            var service = new CB_PCs();
            string resultado = service.Delete(selectedPCId);

            MessageBox.Show(
                resultado,
                resultado.StartsWith("Error") ? "Error" : "Resultado",
                MessageBoxButtons.OK,
                resultado.StartsWith("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information
            );

            // If the result is successful, refresh the list
            if (resultado == "PC eliminada correctamente.")
                BtnRefresh_Click(null, null); // Refresh the list
        }


        private void FormatGrid()
        {
            dgvPCList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPCList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPCList.AllowUserToAddRows = false;
            dgvPCList.AllowUserToDeleteRows = false;
            dgvPCList.RowHeadersVisible = false;

            // Hide unnecessary columns
            if (dgvPCList.Columns.Contains("PCID"))
                dgvPCList.Columns["PCID"].Visible = false;
            if (dgvPCList.Columns.Contains("ClientID"))
                dgvPCList.Columns["ClientID"].Visible = false;
            if (dgvPCList.Columns.Contains("CreatedAt"))
                dgvPCList.Columns["CreatedAt"].Visible = false;

            // Friendly names for columns
            if (dgvPCList.Columns.Contains("Model"))
                dgvPCList.Columns["Model"].HeaderText = "Model";
            if (dgvPCList.Columns.Contains("SerialNumber"))
                dgvPCList.Columns["SerialNumber"].HeaderText = "Serial number";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
