namespace JLaboratories.Presentation
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            BtnRefresh = new FontAwesome.Sharp.IconButton();
            CmbUser = new ComboBox();
            label2 = new Label();
            dgvOrders = new DataGridView();
            label6 = new Label();
            BtnDelete = new FontAwesome.Sharp.IconButton();
            BtnUpdate = new FontAwesome.Sharp.IconButton();
            roundedCard6 = new RoundedCard();
            roundedCard4 = new RoundedCard();
            roundedCard3 = new RoundedCard();
            label1 = new Label();
            roundedCard2 = new RoundedCard();
            roundedCard1 = new RoundedCard();
            ChkUrgent = new CheckBox();
            LblDate = new Label();
            roundedCard7 = new RoundedCard();
            BtnClose = new FontAwesome.Sharp.IconPictureBox();
            chkCompleted = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            SuspendLayout();
            // 
            // BtnRefresh
            // 
            BtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Message;
            BtnRefresh.IconColor = Color.Black;
            BtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRefresh.IconSize = 20;
            BtnRefresh.Location = new Point(676, 301);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(94, 29);
            BtnRefresh.TabIndex = 94;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // CmbUser
            // 
            CmbUser.FormattingEnabled = true;
            CmbUser.Location = new Point(457, 301);
            CmbUser.Name = "CmbUser";
            CmbUser.Size = new Size(199, 28);
            CmbUser.TabIndex = 93;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(457, 267);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 92;
            label2.Text = "Search per client:";
            // 
            // dgvOrders
            // 
            dgvOrders.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(83, 200);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(342, 384);
            dgvOrders.TabIndex = 91;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 30, 30);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(215, 167);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 90;
            label6.Text = "Order list";
            // 
            // BtnDelete
            // 
            BtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnDelete.IconColor = Color.Black;
            BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDelete.Location = new Point(491, 494);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 89;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Memory;
            BtnUpdate.IconColor = Color.Black;
            BtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUpdate.IconSize = 20;
            BtnUpdate.Location = new Point(610, 494);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 29);
            BtnUpdate.TabIndex = 88;
            BtnUpdate.Text = "Update";
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // roundedCard6
            // 
            roundedCard6.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard6.CornerRadius = 15;
            roundedCard6.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard6.Location = new Point(58, 131);
            roundedCard6.Name = "roundedCard6";
            roundedCard6.Size = new Size(813, 486);
            roundedCard6.TabIndex = 80;
            // 
            // roundedCard4
            // 
            roundedCard4.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard4.CornerRadius = 15;
            roundedCard4.DividerColor = Color.FromArgb(20, 20, 20);
            roundedCard4.Location = new Point(18, 131);
            roundedCard4.Name = "roundedCard4";
            roundedCard4.Size = new Size(34, 486);
            roundedCard4.TabIndex = 79;
            // 
            // roundedCard3
            // 
            roundedCard3.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard3.CornerRadius = 15;
            roundedCard3.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard3.Location = new Point(18, 24);
            roundedCard3.Name = "roundedCard3";
            roundedCard3.Size = new Size(34, 75);
            roundedCard3.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 40, 40);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 41);
            label1.Name = "label1";
            label1.Size = new Size(235, 41);
            label1.TabIndex = 77;
            label1.Text = "Manage Orders";
            // 
            // roundedCard2
            // 
            roundedCard2.CornerRadius = 20;
            roundedCard2.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard2.Location = new Point(5, 117);
            roundedCard2.Name = "roundedCard2";
            roundedCard2.Size = new Size(883, 519);
            roundedCard2.TabIndex = 76;
            // 
            // roundedCard1
            // 
            roundedCard1.CornerRadius = 20;
            roundedCard1.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard1.Location = new Point(3, 12);
            roundedCard1.Name = "roundedCard1";
            roundedCard1.Size = new Size(885, 100);
            roundedCard1.TabIndex = 75;
            // 
            // ChkUrgent
            // 
            ChkUrgent.AutoSize = true;
            ChkUrgent.BackColor = Color.FromArgb(30, 30, 30);
            ChkUrgent.ForeColor = Color.White;
            ChkUrgent.Location = new Point(551, 420);
            ChkUrgent.Name = "ChkUrgent";
            ChkUrgent.Size = new Size(108, 24);
            ChkUrgent.TabIndex = 95;
            ChkUrgent.Text = "Is it urgent?";
            ChkUrgent.UseVisualStyleBackColor = false;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.BackColor = Color.FromArgb(40, 40, 40);
            LblDate.Font = new Font("Segoe UI", 8F);
            LblDate.ForeColor = Color.White;
            LblDate.Location = new Point(847, 557);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(30, 19);
            LblDate.TabIndex = 83;
            LblDate.Text = "Exit";
            // 
            // roundedCard7
            // 
            roundedCard7.BackColor = Color.FromArgb(30, 30, 30);
            roundedCard7.CornerRadius = 15;
            roundedCard7.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard7.Location = new Point(815, 494);
            roundedCard7.Name = "roundedCard7";
            roundedCard7.Size = new Size(90, 90);
            roundedCard7.TabIndex = 81;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(40, 40, 40);
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.PersonRunning;
            BtnClose.IconColor = Color.White;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.IconSize = 50;
            BtnClose.Location = new Point(838, 507);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(50, 50);
            BtnClose.TabIndex = 82;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // chkCompleted
            // 
            chkCompleted.AutoSize = true;
            chkCompleted.BackColor = Color.FromArgb(30, 30, 30);
            chkCompleted.ForeColor = Color.White;
            chkCompleted.Location = new Point(551, 379);
            chkCompleted.Name = "chkCompleted";
            chkCompleted.Size = new Size(105, 24);
            chkCompleted.TabIndex = 96;
            chkCompleted.Text = "Completed";
            chkCompleted.UseVisualStyleBackColor = false;
            chkCompleted.CheckedChanged += ChkCompleted_CheckedChanged;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(909, 648);
            Controls.Add(chkCompleted);
            Controls.Add(ChkUrgent);
            Controls.Add(BtnRefresh);
            Controls.Add(CmbUser);
            Controls.Add(label2);
            Controls.Add(dgvOrders);
            Controls.Add(label6);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(LblDate);
            Controls.Add(BtnClose);
            Controls.Add(roundedCard7);
            Controls.Add(roundedCard6);
            Controls.Add(roundedCard4);
            Controls.Add(roundedCard3);
            Controls.Add(label1);
            Controls.Add(roundedCard2);
            Controls.Add(roundedCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Orders";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRefresh;
        private ComboBox CmbUser;
        private Label label2;
        private DataGridView dgvOrders;
        private Label label6;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnUpdate;
        private RoundedCard roundedCard6;
        private RoundedCard roundedCard4;
        private RoundedCard roundedCard3;
        private Label label1;
        private RoundedCard roundedCard2;
        private RoundedCard roundedCard1;
        private CheckBox ChkUrgent;
        private Label LblDate;
        private RoundedCard roundedCard7;
        private FontAwesome.Sharp.IconPictureBox BtnClose;
        private CheckBox chkCompleted;
    }
}