namespace JLaboratories.Presentation
{
    partial class NewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            CmbClients = new ComboBox();
            BtnCancel = new FontAwesome.Sharp.IconButton();
            BtnSave = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BtnToDashboard = new FontAwesome.Sharp.IconPictureBox();
            roundedCard7 = new RoundedCard();
            roundedCard6 = new RoundedCard();
            roundedCard4 = new RoundedCard();
            roundedCard3 = new RoundedCard();
            label1 = new Label();
            roundedCard2 = new RoundedCard();
            roundedCard1 = new RoundedCard();
            LblDate = new Label();
            CmbPCs = new ComboBox();
            RtxtNotes = new RichTextBox();
            ChkUrgent = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)BtnToDashboard).BeginInit();
            SuspendLayout();
            // 
            // CmbClients
            // 
            CmbClients.FormattingEnabled = true;
            CmbClients.Location = new Point(151, 254);
            CmbClients.Name = "CmbClients";
            CmbClients.Size = new Size(199, 28);
            CmbClients.TabIndex = 66;
            // 
            // BtnCancel
            // 
            BtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnCancel.IconColor = Color.Black;
            BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancel.Location = new Point(437, 332);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 65;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.IconChar = FontAwesome.Sharp.IconChar.Memory;
            BtnSave.IconColor = Color.Black;
            BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSave.IconSize = 20;
            BtnSave.Location = new Point(437, 277);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 29);
            BtnSave.TabIndex = 64;
            BtnSave.Text = "Save";
            BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 30, 30);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(151, 389);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 61;
            label4.Text = "Notes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(151, 305);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 60;
            label3.Text = "PC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(147, 221);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 59;
            label2.Text = "Client:";
            // 
            // BtnToDashboard
            // 
            BtnToDashboard.BackColor = Color.FromArgb(40, 40, 40);
            BtnToDashboard.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            BtnToDashboard.IconColor = Color.White;
            BtnToDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnToDashboard.IconSize = 50;
            BtnToDashboard.Location = new Point(661, 509);
            BtnToDashboard.Name = "BtnToDashboard";
            BtnToDashboard.Size = new Size(50, 50);
            BtnToDashboard.TabIndex = 57;
            BtnToDashboard.TabStop = false;
            BtnToDashboard.Click += BtnToDashboard_Click;
            // 
            // roundedCard7
            // 
            roundedCard7.BackColor = Color.FromArgb(30, 30, 30);
            roundedCard7.CornerRadius = 15;
            roundedCard7.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard7.Location = new Point(638, 496);
            roundedCard7.Name = "roundedCard7";
            roundedCard7.Size = new Size(90, 90);
            roundedCard7.TabIndex = 56;
            // 
            // roundedCard6
            // 
            roundedCard6.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard6.CornerRadius = 15;
            roundedCard6.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard6.Location = new Point(56, 132);
            roundedCard6.Name = "roundedCard6";
            roundedCard6.Size = new Size(641, 486);
            roundedCard6.TabIndex = 55;
            // 
            // roundedCard4
            // 
            roundedCard4.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard4.CornerRadius = 15;
            roundedCard4.DividerColor = Color.FromArgb(20, 20, 20);
            roundedCard4.Location = new Point(16, 132);
            roundedCard4.Name = "roundedCard4";
            roundedCard4.Size = new Size(34, 486);
            roundedCard4.TabIndex = 54;
            // 
            // roundedCard3
            // 
            roundedCard3.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard3.CornerRadius = 15;
            roundedCard3.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard3.Location = new Point(16, 24);
            roundedCard3.Name = "roundedCard3";
            roundedCard3.Size = new Size(34, 75);
            roundedCard3.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 40, 40);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(237, 41);
            label1.TabIndex = 52;
            label1.Text = "Adding a Order";
            // 
            // roundedCard2
            // 
            roundedCard2.CornerRadius = 20;
            roundedCard2.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard2.Location = new Point(3, 118);
            roundedCard2.Name = "roundedCard2";
            roundedCard2.Size = new Size(708, 519);
            roundedCard2.TabIndex = 51;
            // 
            // roundedCard1
            // 
            roundedCard1.CornerRadius = 20;
            roundedCard1.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard1.Location = new Point(3, 12);
            roundedCard1.Name = "roundedCard1";
            roundedCard1.Size = new Size(708, 100);
            roundedCard1.TabIndex = 50;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.BackColor = Color.FromArgb(40, 40, 40);
            LblDate.Font = new Font("Segoe UI", 8F);
            LblDate.ForeColor = Color.White;
            LblDate.Location = new Point(654, 562);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(66, 19);
            LblDate.TabIndex = 58;
            LblDate.Text = "Go home";
            // 
            // CmbPCs
            // 
            CmbPCs.FormattingEnabled = true;
            CmbPCs.Location = new Point(151, 333);
            CmbPCs.Name = "CmbPCs";
            CmbPCs.Size = new Size(199, 28);
            CmbPCs.TabIndex = 67;
            // 
            // RtxtNotes
            // 
            RtxtNotes.Location = new Point(151, 419);
            RtxtNotes.Name = "RtxtNotes";
            RtxtNotes.Size = new Size(199, 120);
            RtxtNotes.TabIndex = 68;
            RtxtNotes.Text = "";
            // 
            // ChkUrgent
            // 
            ChkUrgent.AutoSize = true;
            ChkUrgent.BackColor = Color.FromArgb(30, 30, 30);
            ChkUrgent.ForeColor = Color.White;
            ChkUrgent.Location = new Point(389, 469);
            ChkUrgent.Name = "ChkUrgent";
            ChkUrgent.Size = new Size(108, 24);
            ChkUrgent.TabIndex = 69;
            ChkUrgent.Text = "Is it urgent?";
            ChkUrgent.UseVisualStyleBackColor = false;
            // 
            // NewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(732, 649);
            Controls.Add(ChkUrgent);
            Controls.Add(RtxtNotes);
            Controls.Add(CmbPCs);
            Controls.Add(CmbClients);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblDate);
            Controls.Add(BtnToDashboard);
            Controls.Add(roundedCard7);
            Controls.Add(roundedCard6);
            Controls.Add(roundedCard4);
            Controls.Add(roundedCard3);
            Controls.Add(label1);
            Controls.Add(roundedCard2);
            Controls.Add(roundedCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adding a Order";
            ((System.ComponentModel.ISupportInitialize)BtnToDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbClients;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private FontAwesome.Sharp.IconButton BtnSave;
        private Label label4;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox BtnToDashboard;
        private RoundedCard roundedCard7;
        private RoundedCard roundedCard6;
        private RoundedCard roundedCard4;
        private RoundedCard roundedCard3;
        private Label label1;
        private RoundedCard roundedCard2;
        private RoundedCard roundedCard1;
        private Label LblDate;
        private ComboBox CmbPCs;
        private RichTextBox RtxtNotes;
        private CheckBox ChkUrgent;
    }
}