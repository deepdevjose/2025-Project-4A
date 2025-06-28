using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using JLaboratories.Business;
using JLaboratories.Entity;

namespace JLaboratories.Presentation
{
    public partial class ManageOrders : Form
    {
        private readonly CB_Orders _orderService = new CB_Orders();
        private readonly CB_Clients _clientService = new CB_Clients();

        public ManageOrders()
        {
            InitializeComponent();

            // Events
            this.Load += ManageOrders_Load;
            BtnRefresh.Click += BtnRefresh_Click;
            dgvOrders.SelectionChanged += DgvOrders_SelectionChanged;
            BtnUpdate.Click += BtnUpdate_Click;
            BtnDelete.Click += BtnDelete_Click;

            // Initial state of buttons and checkbox
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void ManageOrders_Load(object? sender, EventArgs e)
        {
            // Load the combo box and the orders
            var clientes = _clientService.ListAll();
            CmbUser.DataSource = clientes;
            CmbUser.DisplayMember = "FullName";
            CmbUser.ValueMember = "ClientID";
            CmbUser.SelectedIndex = -1;

            // Load the orders
            LoadOrders();
        }

        private void LoadOrders(int? clientId = null)
        {
            // Catch the orders from the service
            List<Order> orders = _orderService.ListRecent();

            // Apply filter if needed
            if (clientId.HasValue)
                orders = orders.Where(o => o.ClientID == clientId.Value).ToList();

            // Empty the DataGridView and set the new data source
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = orders;

            // Hide unnecessary columns
            foreach (string col in new[] {
                "OrderID", "ClientID", "PCID", "Client", "PC", "Ticket", "CompletedAt", "IsUrgent"
            })
            {
                if (dgvOrders.Columns.Contains(col))
                    dgvOrders.Columns[col].Visible = false;
            }

            // Rename the columns to user-friendly names
            dgvOrders.Columns["Notes"].HeaderText = "Notes";
            dgvOrders.Columns["Status"].HeaderText = "Status";
            dgvOrders.Columns["CreatedAt"].HeaderText = "Date";
            dgvOrders.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Adjust the DataGridView properties
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.RowHeadersVisible = false;

            // Inhibit the buttons and checkbox
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            ChkUrgent.Enabled = false;
        }

        private void BtnRefresh_Click(object? sender, EventArgs? e)
        {
            int? filtro = CmbUser.SelectedIndex >= 0
                ? (int?)CmbUser.SelectedValue
                : null;
            LoadOrders(filtro);
        }

        private void DgvOrders_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is Order o)
            {
                // Reflex the selected order in the controls
                ChkUrgent.Checked = o.IsUrgent;
                ChkUrgent.Enabled = true;

                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is Order o)
            {
                string newStatus = ChkUrgent.Checked ? "Urgent" : "Pending";
                bool isUrg = ChkUrgent.Checked;

                string msg = _orderService.UpdateStatus(o.OrderID, newStatus, isUrg);
                MessageBox.Show(
                    msg,
                    msg.StartsWith("Error") ? "Error" : "Result",
                    MessageBoxButtons.OK,
                    msg.StartsWith("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information
                );

                // Refresh the grid
                BtnRefresh_Click(null, null);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is Order o)
            {
                var r = MessageBox.Show(
                    "¿Seguro que deseas eliminar esta orden?",
                    "Confirmar borrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (r != DialogResult.Yes) return;

                string msg = _orderService.Delete(o.OrderID);
                MessageBox.Show(
                    msg,
                    msg.StartsWith("Error") ? "Error" : "Result",
                    MessageBoxButtons.OK,
                    msg.StartsWith("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information
                );

                // Refres the grid
                BtnRefresh_Click(null, null);
            }
        }

        private void ChkCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is Order o)
            {
                if (chkCompleted.Checked)
                {
                    string msg = _orderService.UpdateStatus(o.OrderID, "Completed", o.IsUrgent);
                    MessageBox.Show(
                        msg,
                        msg.StartsWith("Error") ? "Error" : "Result",
                        MessageBoxButtons.OK,
                        msg.StartsWith("Error") ? MessageBoxIcon.Error : MessageBoxIcon.Information
                    );
                    BtnRefresh_Click(null, null);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
