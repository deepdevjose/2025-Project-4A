namespace JLaboratories.Presentation
{
    partial class ManagePCs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePCs));
            dgvPCList = new DataGridView();
            label6 = new Label();
            BtnDelete = new FontAwesome.Sharp.IconButton();
            BtnUpdate = new FontAwesome.Sharp.IconButton();
            TxtSerialNumber = new TextBox();
            TxtModel = new TextBox();
            label4 = new Label();
            label3 = new Label();
            LblDate = new Label();
            BtnClose = new FontAwesome.Sharp.IconPictureBox();
            roundedCard7 = new RoundedCard();
            roundedCard6 = new RoundedCard();
            roundedCard4 = new RoundedCard();
            roundedCard3 = new RoundedCard();
            label1 = new Label();
            roundedCard2 = new RoundedCard();
            roundedCard1 = new RoundedCard();
            label2 = new Label();
            CmbUser = new ComboBox();
            BtnRefresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvPCList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            SuspendLayout();
            // 
            // dgvPCList
            // 
            dgvPCList.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvPCList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPCList.Location = new Point(83, 200);
            dgvPCList.Name = "dgvPCList";
            dgvPCList.RowHeadersWidth = 51;
            dgvPCList.Size = new Size(342, 384);
            dgvPCList.TabIndex = 71;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 30, 30);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(215, 167);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 70;
            label6.Text = "PC list";
            // 
            // BtnDelete
            // 
            BtnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnDelete.IconColor = Color.Black;
            BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDelete.Location = new Point(676, 481);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 29);
            BtnDelete.TabIndex = 69;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click_1;
            // 
            // BtnUpdate
            // 
            BtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Memory;
            BtnUpdate.IconColor = Color.Black;
            BtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUpdate.IconSize = 20;
            BtnUpdate.Location = new Point(676, 446);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(94, 29);
            BtnUpdate.TabIndex = 68;
            BtnUpdate.Text = "Update";
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // TxtSerialNumber
            // 
            TxtSerialNumber.Location = new Point(457, 512);
            TxtSerialNumber.Name = "TxtSerialNumber";
            TxtSerialNumber.Size = new Size(199, 27);
            TxtSerialNumber.TabIndex = 66;
            // 
            // TxtModel
            // 
            TxtModel.Location = new Point(457, 428);
            TxtModel.Name = "TxtModel";
            TxtModel.Size = new Size(199, 27);
            TxtModel.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 30, 30);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(457, 485);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 62;
            label4.Text = "Serial number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(457, 401);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 61;
            label3.Text = "Model:";
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
            LblDate.TabIndex = 59;
            LblDate.Text = "Exit";
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
            BtnClose.TabIndex = 58;
            BtnClose.TabStop = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // roundedCard7
            // 
            roundedCard7.BackColor = Color.FromArgb(30, 30, 30);
            roundedCard7.CornerRadius = 15;
            roundedCard7.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard7.Location = new Point(815, 494);
            roundedCard7.Name = "roundedCard7";
            roundedCard7.Size = new Size(90, 90);
            roundedCard7.TabIndex = 57;
            // 
            // roundedCard6
            // 
            roundedCard6.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard6.CornerRadius = 15;
            roundedCard6.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard6.Location = new Point(58, 131);
            roundedCard6.Name = "roundedCard6";
            roundedCard6.Size = new Size(813, 486);
            roundedCard6.TabIndex = 56;
            // 
            // roundedCard4
            // 
            roundedCard4.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard4.CornerRadius = 15;
            roundedCard4.DividerColor = Color.FromArgb(20, 20, 20);
            roundedCard4.Location = new Point(18, 131);
            roundedCard4.Name = "roundedCard4";
            roundedCard4.Size = new Size(34, 486);
            roundedCard4.TabIndex = 55;
            // 
            // roundedCard3
            // 
            roundedCard3.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard3.CornerRadius = 15;
            roundedCard3.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard3.Location = new Point(18, 24);
            roundedCard3.Name = "roundedCard3";
            roundedCard3.Size = new Size(34, 75);
            roundedCard3.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 40, 40);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 41);
            label1.Name = "label1";
            label1.Size = new Size(190, 41);
            label1.TabIndex = 53;
            label1.Text = "Manage PCs";
            // 
            // roundedCard2
            // 
            roundedCard2.CornerRadius = 20;
            roundedCard2.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard2.Location = new Point(5, 117);
            roundedCard2.Name = "roundedCard2";
            roundedCard2.Size = new Size(883, 519);
            roundedCard2.TabIndex = 52;
            // 
            // roundedCard1
            // 
            roundedCard1.CornerRadius = 20;
            roundedCard1.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard1.Location = new Point(3, 12);
            roundedCard1.Name = "roundedCard1";
            roundedCard1.Size = new Size(885, 100);
            roundedCard1.TabIndex = 51;
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
            label2.TabIndex = 72;
            label2.Text = "Search per client:";
            // 
            // CmbUser
            // 
            CmbUser.FormattingEnabled = true;
            CmbUser.Location = new Point(457, 301);
            CmbUser.Name = "CmbUser";
            CmbUser.Size = new Size(199, 28);
            CmbUser.TabIndex = 73;
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
            BtnRefresh.TabIndex = 74;
            BtnRefresh.Text = "Search";
            BtnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // ManagePCs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(909, 648);
            Controls.Add(BtnRefresh);
            Controls.Add(CmbUser);
            Controls.Add(label2);
            Controls.Add(dgvPCList);
            Controls.Add(label6);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(TxtSerialNumber);
            Controls.Add(TxtModel);
            Controls.Add(label4);
            Controls.Add(label3);
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
            Name = "ManagePCs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage PCs";
            ((System.ComponentModel.ISupportInitialize)dgvPCList).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPCList;
        private Label label6;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnUpdate;
        private TextBox TxtSerialNumber;
        private TextBox TxtModel;
        private Label label4;
        private Label label3;
        private Label LblDate;
        private FontAwesome.Sharp.IconPictureBox BtnClose;
        private RoundedCard roundedCard7;
        private RoundedCard roundedCard6;
        private RoundedCard roundedCard4;
        private RoundedCard roundedCard3;
        private Label label1;
        private RoundedCard roundedCard2;
        private RoundedCard roundedCard1;
        private Label label2;
        private ComboBox CmbUser;
        private FontAwesome.Sharp.IconButton BtnRefresh;
    }
}