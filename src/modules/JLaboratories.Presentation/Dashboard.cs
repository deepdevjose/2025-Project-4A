using JLaboratories.Entity;
using JLaboratories.Business;
using FontAwesome.Sharp;
using System.Windows.Forms;
namespace JLaboratories.Presentation
{
    public partial class Dashboard : Form
    {
        
        private readonly CB_Orders _orderService = new CB_Orders(); // Call to the service that manages orders

        public Dashboard()
        {
            InitializeComponent();
            // Set the event handlers for the buttons
            this.Load += Dashboard_Load;
            this.iconButton1.Click += iconButton1_Click;
        }

        // Setter for the date label
        public void SetDate(string date)
        {
            LblDate.Text = date;
        }

        // Setter for the user label
        public void SetUser(string user)
        {
            LblUser.Text = user;
        }

        // This method load the dashboard with the data
        private void Dashboard_Load(object? sender, EventArgs e)
        {
            // Generate the date 
            var summary = _orderService.GetOrderSummary();
            var recent = _orderService.ListRecentSimple();

            // Make the summary cards
            var pendingCard = new RoundedSummaryCard
            {
                Title = "Pending",
                Value = summary.PendingCount,
                Icon = IconChar.Clock,
                CornerRadius = 20,
                DividerColor = System.Drawing.Color.FromArgb(40, 40, 40),
                Margin = new Padding(10)
            };
            var urgentCard = new RoundedSummaryCard
            {
                Title = "Urgent",
                Value = summary.UrgentCount,
                Icon = IconChar.ExclamationTriangle,
                CornerRadius = 20,
                DividerColor = System.Drawing.Color.FromArgb(40, 40, 40),
                Margin = new Padding(10)
            };
            var completedCard = new RoundedSummaryCard
            {
                Title = "Completed",
                Value = summary.CompletedCount,
                Icon = IconChar.CheckCircle,
                CornerRadius = 20,
                DividerColor = System.Drawing.Color.FromArgb(40, 40, 40),
                Margin = new Padding(10)
            };

            // Clean the container and add the cards
            ContainerSummaryCards.Controls.Clear();
            ContainerSummaryCards.Controls.Add(pendingCard);
            ContainerSummaryCards.Controls.Add(urgentCard);
            ContainerSummaryCards.Controls.Add(completedCard);

            // Load the recent orders
            dgvRecentOrders.DataSource = recent;

            dgvRecentOrders.AllowUserToAddRows = false;
            dgvRecentOrders.AllowUserToDeleteRows = false;
            dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentOrders.RowHeadersVisible = false;

            // Adjust the columns if they exist
            if (dgvRecentOrders.Columns.Contains("Client"))
                dgvRecentOrders.Columns["Client"].HeaderText = "Client";
            if (dgvRecentOrders.Columns.Contains("PCModel"))
                dgvRecentOrders.Columns["PCModel"].HeaderText = "PC Model";
            if (dgvRecentOrders.Columns.Contains("Notes"))
                dgvRecentOrders.Columns["Notes"].HeaderText = "Notes";
            if (dgvRecentOrders.Columns.Contains("Status"))
                dgvRecentOrders.Columns["Status"].HeaderText = "Status";
        }

        // This method do the logout
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Show message for confirm logout
            DialogResult result = MessageBox.Show(
                "Are you sure to logout?",
                "Ok, i'm sure",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If user answer 'yes', close form
            if (result == DialogResult.Yes)
            {
                // Hide form
                this.Hide();

                // Show the login form
                Login login = new Login();
                login.Show();
            }
        }

        // This method refresh the dashboard
        public void RefreshDashboard()
        {
            // 1) Summary Cards
            var summary = _orderService.GetOrderSummary();

            // Clean the container and add the cards
            ContainerSummaryCards.Controls.Clear();

            var pendingCard = new RoundedSummaryCard
            {
                Title = "Pending",
                Value = summary.PendingCount,
                Icon = IconChar.Clock,
                CornerRadius = 20,
                DividerColor = System.Drawing.Color.FromArgb(40, 40, 40),
                Margin = new Padding(10)
            };
            var urgentCard = new RoundedSummaryCard
            {
                Title = "Urgent",
                Value = summary.UrgentCount,
                Icon = IconChar.ExclamationTriangle,
                CornerRadius = 20,
                DividerColor = System.Drawing.Color.FromArgb(40, 40, 40),
                Margin = new Padding(10)
            };
            var completedCard = new RoundedSummaryCard
            {
                Title = "Completed",
                Value = summary.CompletedCount,
                Icon = IconChar.CheckCircle,
                CornerRadius = 20,
                DividerColor = System.Drawing.Color.FromArgb(40, 40, 40),
                Margin = new Padding(10)
            };

            ContainerSummaryCards.Controls.Add(pendingCard);
            ContainerSummaryCards.Controls.Add(urgentCard);
            ContainerSummaryCards.Controls.Add(completedCard);

            var recent = _orderService.ListRecentSimple();
            dgvRecentOrders.DataSource = recent;

            dgvRecentOrders.AllowUserToAddRows = false;
            dgvRecentOrders.AllowUserToDeleteRows = false;
            dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentOrders.RowHeadersVisible = false;

            if (dgvRecentOrders.Columns.Contains("OrderID"))
                dgvRecentOrders.Columns["OrderID"].Visible = false;
            if (dgvRecentOrders.Columns.Contains("Client"))
                dgvRecentOrders.Columns["Client"].HeaderText = "Client";
            if (dgvRecentOrders.Columns.Contains("PCModel"))
                dgvRecentOrders.Columns["PCModel"].HeaderText = "PC Model";
            if (dgvRecentOrders.Columns.Contains("Notes"))
                dgvRecentOrders.Columns["Notes"].HeaderText = "Notes";
            if (dgvRecentOrders.Columns.Contains("Status"))
                dgvRecentOrders.Columns["Status"].HeaderText = "Status";
            if (dgvRecentOrders.Columns.Contains("CreatedAt"))
                dgvRecentOrders.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }


        private void BtnToClients_Click(object sender, EventArgs e)
        {

            ManageClients manageClients = new ManageClients();
            manageClients.Show(this);
        }

        private void BtnToOrders_Click(object sender, EventArgs e)
        {

            ManageOrders manageOrders = new ManageOrders();
            manageOrders.Show(this);
        }

        private void BtnToPCs_Click(object sender, EventArgs e)
        {

            ManagePCs managePCs = new ManagePCs();
            managePCs.Show(this);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {

            Settings settings = new Settings();
            settings.Show();
        }

        private void BtnNewClient_Click(object sender, EventArgs e)
        {

            NewClient newClient = new NewClient();
            newClient.Show();
        }

        private void BtnAddPC_Click(object sender, EventArgs e)
        {

            NewPC newPC = new NewPC();
            newPC.Show();
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {

            NewOrder newOrder = new NewOrder();
            newOrder.Show();
        }

        private void iconButton1_Click(object? sender, EventArgs e)
        {
            // First, check if the DataGridView is null
            if (dgvRecentOrders == null)
            {
                MessageBox.Show(
                    "The grid not exist",
                    "Intern error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                // Call the refresh method
                RefreshDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Has ocurred a error while we refresh the panel:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK
                );
            }
        }

    }
}
