namespace JLaboratories.Presentation
{
    partial class ManageClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageClients));
            BtnDelete = new FontAwesome.Sharp.IconButton();
            BtnUpdate = new FontAwesome.Sharp.IconButton();
            TxtCAddress = new TextBox();
            TxtCPhoneNumber = new TextBox();
            TxtCLastName = new TextBox();
            TxtCName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            roundedCard6 = new RoundedCard();
            roundedCard4 = new RoundedCard();
            roundedCard3 = new RoundedCard();
            label1 = new Label();
            roundedCard2 = new RoundedCard();
            roundedCard1 = new RoundedCard();
            label6 = new Label();
            dgvClients = new DataGridView();
            LblDate = new Label();
            roundedCard7 = new RoundedCard();
            BtnClose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnDelete.IconColor = Color.Black;
            BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDelete.Location = new Point(730, 392);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 48;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Memory;
            BtnUpdate.IconColor = Color.Black;
            BtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUpdate.IconSize = 20;
            BtnUpdate.Location = new Point(730, 344);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 29);
            BtnUpdate.TabIndex = 47;
            BtnUpdate.Text = "Update";
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // TxtCAddress
            // 
            TxtCAddress.Location = new Point(464, 500);
            TxtCAddress.Name = "TxtCAddress";
            TxtCAddress.Size = new Size(199, 27);
            TxtCAddress.TabIndex = 46;
            // 
            // TxtCPhoneNumber
            // 
            TxtCPhoneNumber.Location = new Point(464, 419);
            TxtCPhoneNumber.Name = "TxtCPhoneNumber";
            TxtCPhoneNumber.Size = new Size(199, 27);
            TxtCPhoneNumber.TabIndex = 45;
            // 
            // TxtCLastName
            // 
            TxtCLastName.Location = new Point(464, 335);
            TxtCLastName.Name = "TxtCLastName";
            TxtCLastName.Size = new Size(199, 27);
            TxtCLastName.TabIndex = 44;
            // 
            // TxtCName
            // 
            TxtCName.Location = new Point(464, 251);
            TxtCName.Name = "TxtCName";
            TxtCName.Size = new Size(199, 27);
            TxtCName.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(30, 30, 30);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(464, 472);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 42;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 30, 30);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(464, 392);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 41;
            label4.Text = "Phone number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(464, 308);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 40;
            label3.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(460, 224);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 39;
            label2.Text = "Name(s):";
            // 
            // roundedCard6
            // 
            roundedCard6.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard6.CornerRadius = 15;
            roundedCard6.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard6.Location = new Point(67, 131);
            roundedCard6.Name = "roundedCard6";
            roundedCard6.Size = new Size(813, 486);
            roundedCard6.TabIndex = 35;
            // 
            // roundedCard4
            // 
            roundedCard4.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard4.CornerRadius = 15;
            roundedCard4.DividerColor = Color.FromArgb(20, 20, 20);
            roundedCard4.Location = new Point(27, 131);
            roundedCard4.Name = "roundedCard4";
            roundedCard4.Size = new Size(34, 486);
            roundedCard4.TabIndex = 34;
            // 
            // roundedCard3
            // 
            roundedCard3.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard3.CornerRadius = 15;
            roundedCard3.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard3.Location = new Point(27, 24);
            roundedCard3.Name = "roundedCard3";
            roundedCard3.Size = new Size(34, 75);
            roundedCard3.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 40, 40);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 41);
            label1.Name = "label1";
            label1.Size = new Size(236, 41);
            label1.TabIndex = 32;
            label1.Text = "Manage Clients";
            // 
            // roundedCard2
            // 
            roundedCard2.CornerRadius = 20;
            roundedCard2.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard2.Location = new Point(14, 117);
            roundedCard2.Name = "roundedCard2";
            roundedCard2.Size = new Size(883, 519);
            roundedCard2.TabIndex = 31;
            // 
            // roundedCard1
            // 
            roundedCard1.CornerRadius = 20;
            roundedCard1.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard1.Location = new Point(12, 12);
            roundedCard1.Name = "roundedCard1";
            roundedCard1.Size = new Size(885, 100);
            roundedCard1.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 30, 30);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(224, 167);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 49;
            label6.Text = "Client list";
            // 
            // dgvClients
            // 
            dgvClients.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(92, 200);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 51;
            dgvClients.Size = new Size(342, 384);
            dgvClients.TabIndex = 50;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.BackColor = Color.FromArgb(40, 40, 40);
            LblDate.Font = new Font("Segoe UI", 8F);
            LblDate.ForeColor = Color.White;
            LblDate.Location = new Point(856, 557);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(30, 19);
            LblDate.TabIndex = 38;
            LblDate.Text = "Exit";
            // 
            // roundedCard7
            // 
            roundedCard7.BackColor = Color.FromArgb(30, 30, 30);
            roundedCard7.CornerRadius = 15;
            roundedCard7.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard7.Location = new Point(824, 494);
            roundedCard7.Name = "roundedCard7";
            roundedCard7.Size = new Size(90, 90);
            roundedCard7.TabIndex = 36;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(40, 40, 40);
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.PersonRunning;
            BtnClose.IconColor = Color.White;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.IconSize = 50;
            BtnClose.Location = new Point(847, 507);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(50, 50);
            BtnClose.TabIndex = 37;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // ManageClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(909, 648);
            Controls.Add(dgvClients);
            Controls.Add(label6);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(TxtCAddress);
            Controls.Add(TxtCPhoneNumber);
            Controls.Add(TxtCLastName);
            Controls.Add(TxtCName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
            Name = "ManageClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Clients";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnUpdate;
        private TextBox TxtCAddress;
        private TextBox TxtCPhoneNumber;
        private TextBox TxtCLastName;
        private TextBox TxtCName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RoundedCard roundedCard6;
        private RoundedCard roundedCard4;
        private RoundedCard roundedCard3;
        private Label label1;
        private RoundedCard roundedCard2;
        private RoundedCard roundedCard1;
        private Label label6;
        private DataGridView dgvClients;
        private Label LblDate;
        private RoundedCard roundedCard7;
        private FontAwesome.Sharp.IconPictureBox BtnClose;
    }
}