using System;
using System.Windows.Forms;
using JLaboratories.Business;
using JLaboratories.Data;
using JLaboratories.Entity;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Fonts;

namespace JLaboratories.Presentation
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
         
            BtnSave.Enabled = false;
            CmbPCs.Enabled = false;
            BtnCancel.Click += (s, e) => Close();
            this.Load += NewOrder_Load;
            CmbClients.SelectedIndexChanged += CmbClients_SelectedIndexChanged;
            CmbPCs.SelectedIndexChanged += CmbPCs_SelectedIndexChanged;
        }

        private void NewOrder_Load(object? sender, EventArgs e)
        {
            // List all clients in the combo box
            var clients = new CB_Clients().ListAll();
            CmbClients.DataSource = clients;
            CmbClients.DisplayMember = "FullName";  
            CmbClients.ValueMember = "ClientID";
            CmbClients.SelectedIndex = -1;
        }

        private void CmbClients_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Initialize the PC combo box
            if (CmbClients.SelectedValue is int clientId && clientId > 0)
            {
                var pcs = new CB_PCs().ListByClient(clientId);
                CmbPCs.DataSource = pcs;
                CmbPCs.DisplayMember = "Model";
                CmbPCs.ValueMember = "PCID";
                CmbPCs.SelectedIndex = -1;
                CmbPCs.Enabled = true;
            }
            else
            {
                CmbPCs.DataSource = null;
                CmbPCs.Enabled = false;
            }

            BtnSave.Enabled = false;
        }

        private void CmbPCs_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Habilitar Save solo si hay PC seleccionado
            BtnSave.Enabled = CmbPCs.SelectedIndex >= 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 0) Protección absolutoria: verifica que los propios controles existan
            if (CmbClients == null || CmbPCs == null || RtxtNotes == null || ChkUrgent == null)
            {
                MessageBox.Show("Error interno: controles no inicializados.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1) Validar cliente
            if (!(CmbClients.SelectedValue is int clientId) || clientId <= 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Validar PC
            if (!(CmbPCs.SelectedValue is int pcId) || pcId <= 0)
            {
                MessageBox.Show("Por favor, selecciona un PC.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3) Leer notas y urgencia de forma segura
            string notes = RtxtNotes.Text?.Trim() ?? string.Empty;
            bool isUrgent = ChkUrgent.Checked;

            // 4) Construir la entidad
            var order = new Order
            {
                ClientID = clientId,
                PCID = pcId,
                Notes = notes,
                IsUrgent = isUrgent,
                // Asignar referencias completas para el PDF
                Client = CmbClients.SelectedItem as Client,
                PC = CmbPCs.SelectedItem as PC
            };

            try
            {
                // 5) Llamar al servicio
                var service = new CB_Orders();
                string msg = service.CreateWithTicket(order)
                                    ?? "Orden creada, pero no se recibió mensaje.";

                MessageBox.Show(msg,
                                "Resultado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // 6) Si tu Dashboard es el Owner, refresca el grid
                if (this.Owner is Dashboard dash)
                    dash.RefreshDashboard();
                // 7) Generar PDF del ticket
                GenerateTicketPdf(order, msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la orden:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static void GenerateTicketPdf(Order order, string ticketMessage)
        {
            using var sfd = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = $"Ticket_{order.ClientID}_{order.PCID}.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            var document = new PdfDocument();
            document.Info.Title = "Ticket de Orden";
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);

            var fontTitle = new XFont("Arial", 16);
            var fontBody = new XFont("Arial", 12);

            double y = 40;
            gfx.DrawString("JLaboratories - Ticket de Orden", fontTitle, XBrushes.Black, new XRect(0, y, page.Width.Point, 30), XStringFormats.TopCenter);
            y += 40;

            // Agregar datos del cliente y PC
            string clientName = order.Client != null ? $"{order.Client.FirstName} {order.Client.LastName}" : "N/A";
            string clientPhone = order.Client?.PhoneNumber ?? "N/A";
            string pcModel = order.PC?.Model ?? "N/A";

            gfx.DrawString($"Cliente: {clientName}", fontBody, XBrushes.Black, new XPoint(40, y));
            y += 25;
            gfx.DrawString($"Teléfono: {clientPhone}", fontBody, XBrushes.Black, new XPoint(40, y));
            y += 25;
            gfx.DrawString($"Modelo Laptop: {pcModel}", fontBody, XBrushes.Black, new XPoint(40, y));
            y += 25;

            gfx.DrawString($"Cliente ID: {order.ClientID}", fontBody, XBrushes.Black, new XPoint(40, y));
            y += 25;
            gfx.DrawString($"PC ID: {order.PCID}", fontBody, XBrushes.Black, new XPoint(40, y));
            y += 25;
            gfx.DrawString($"Notas: {order.Notes}", fontBody, XBrushes.Black, new XPoint(40, y));
            y += 25;
            gfx.DrawString($"Urgente: {(order.IsUrgent ? "Sí" : "No")}", fontBody, XBrushes.Black, new XPoint(40, y));
            y += 25;
            gfx.DrawString($"Mensaje: {ticketMessage}", fontBody, XBrushes.Black, new XPoint(40, y));
            y += 25;
            gfx.DrawString($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}", fontBody, XBrushes.Black, new XPoint(40, y));

            document.Save(sfd.FileName);
            MessageBox.Show($"PDF generado en:\n{sfd.FileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnToDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
