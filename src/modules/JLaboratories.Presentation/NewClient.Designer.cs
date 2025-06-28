namespace JLaboratories.Presentation
{
    partial class NewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewClient));
            roundedCard1 = new RoundedCard();
            roundedCard2 = new RoundedCard();
            label1 = new Label();
            roundedCard3 = new RoundedCard();
            roundedCard4 = new RoundedCard();
            roundedCard6 = new RoundedCard();
            BtnToAddPC = new FontAwesome.Sharp.IconPictureBox();
            roundedCard7 = new RoundedCard();
            LblDate = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtCName = new TextBox();
            TxtCLastName = new TextBox();
            TxtCPhoneNumber = new TextBox();
            TxtCAddress = new TextBox();
            BtnSave = new FontAwesome.Sharp.IconButton();
            BtnCancel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)BtnToAddPC).BeginInit();
            SuspendLayout();
            // 
            // roundedCard1
            // 
            roundedCard1.CornerRadius = 20;
            roundedCard1.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard1.Location = new Point(12, 12);
            roundedCard1.Name = "roundedCard1";
            roundedCard1.Size = new Size(708, 100);
            roundedCard1.TabIndex = 0;
            // 
            // roundedCard2
            // 
            roundedCard2.CornerRadius = 20;
            roundedCard2.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard2.Location = new Point(12, 118);
            roundedCard2.Name = "roundedCard2";
            roundedCard2.Size = new Size(708, 519);
            roundedCard2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(40, 40, 40);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 42);
            label1.Name = "label1";
            label1.Size = new Size(299, 41);
            label1.TabIndex = 11;
            label1.Text = "Adding a new client";
            // 
            // roundedCard3
            // 
            roundedCard3.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard3.CornerRadius = 15;
            roundedCard3.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard3.Location = new Point(25, 24);
            roundedCard3.Name = "roundedCard3";
            roundedCard3.Size = new Size(34, 75);
            roundedCard3.TabIndex = 12;
            // 
            // roundedCard4
            // 
            roundedCard4.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard4.CornerRadius = 15;
            roundedCard4.DividerColor = Color.FromArgb(20, 20, 20);
            roundedCard4.Location = new Point(25, 132);
            roundedCard4.Name = "roundedCard4";
            roundedCard4.Size = new Size(34, 486);
            roundedCard4.TabIndex = 13;
            // 
            // roundedCard6
            // 
            roundedCard6.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard6.CornerRadius = 15;
            roundedCard6.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard6.Location = new Point(65, 132);
            roundedCard6.Name = "roundedCard6";
            roundedCard6.Size = new Size(641, 486);
            roundedCard6.TabIndex = 16;
            // 
            // BtnToAddPC
            // 
            BtnToAddPC.BackColor = Color.FromArgb(40, 40, 40);
            BtnToAddPC.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            BtnToAddPC.IconColor = Color.White;
            BtnToAddPC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnToAddPC.IconSize = 50;
            BtnToAddPC.Location = new Point(670, 509);
            BtnToAddPC.Name = "BtnToAddPC";
            BtnToAddPC.Size = new Size(50, 50);
            BtnToAddPC.TabIndex = 18;
            BtnToAddPC.TabStop = false;
            BtnToAddPC.Click += BtnToAddPC_Click;
            // 
            // roundedCard7
            // 
            roundedCard7.BackColor = Color.FromArgb(30, 30, 30);
            roundedCard7.CornerRadius = 15;
            roundedCard7.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard7.Location = new Point(647, 496);
            roundedCard7.Name = "roundedCard7";
            roundedCard7.Size = new Size(90, 90);
            roundedCard7.TabIndex = 17;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.BackColor = Color.FromArgb(40, 40, 40);
            LblDate.Font = new Font("Segoe UI", 8F);
            LblDate.ForeColor = Color.White;
            LblDate.Location = new Point(666, 556);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(55, 19);
            LblDate.TabIndex = 19;
            LblDate.Text = "Add PC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 222);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 20;
            label2.Text = "Name(s):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(165, 306);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 21;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 30, 30);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(165, 390);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 22;
            label4.Text = "Phone number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(30, 30, 30);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(165, 470);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 23;
            label5.Text = "Address:";
            // 
            // TxtCName
            // 
            TxtCName.Location = new Point(165, 249);
            TxtCName.Name = "TxtCName";
            TxtCName.Size = new Size(199, 27);
            TxtCName.TabIndex = 24;
            // 
            // TxtCLastName
            // 
            TxtCLastName.Location = new Point(165, 333);
            TxtCLastName.Name = "TxtCLastName";
            TxtCLastName.Size = new Size(199, 27);
            TxtCLastName.TabIndex = 25;
            // 
            // TxtCPhoneNumber
            // 
            TxtCPhoneNumber.Location = new Point(165, 417);
            TxtCPhoneNumber.Name = "TxtCPhoneNumber";
            TxtCPhoneNumber.Size = new Size(199, 27);
            TxtCPhoneNumber.TabIndex = 26;
            // 
            // TxtCAddress
            // 
            TxtCAddress.Location = new Point(165, 498);
            TxtCAddress.Name = "TxtCAddress";
            TxtCAddress.Size = new Size(199, 27);
            TxtCAddress.TabIndex = 27;
            // 
            // BtnSave
            // 
            BtnSave.IconChar = FontAwesome.Sharp.IconChar.Memory;
            BtnSave.IconColor = Color.Black;
            BtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSave.IconSize = 20;
            BtnSave.Location = new Point(431, 342);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 29);
            BtnSave.TabIndex = 28;
            BtnSave.Text = "Save";
            BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnCancel.IconColor = Color.Black;
            BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancel.Location = new Point(431, 390);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 29;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // NewClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(732, 649);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(TxtCAddress);
            Controls.Add(TxtCPhoneNumber);
            Controls.Add(TxtCLastName);
            Controls.Add(TxtCName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblDate);
            Controls.Add(BtnToAddPC);
            Controls.Add(roundedCard7);
            Controls.Add(roundedCard6);
            Controls.Add(roundedCard4);
            Controls.Add(roundedCard3);
            Controls.Add(label1);
            Controls.Add(roundedCard2);
            Controls.Add(roundedCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adding a new Client";
            ((System.ComponentModel.ISupportInitialize)BtnToAddPC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedCard roundedCard1;
        private RoundedCard roundedCard2;
        private Label label1;
        private RoundedCard roundedCard3;
        private RoundedCard roundedCard4;
        private RoundedCard roundedCard6;
        private FontAwesome.Sharp.IconPictureBox BtnToAddPC;
        private RoundedCard roundedCard7;
        private Label LblDate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtCName;
        private TextBox TxtCLastName;
        private TextBox TxtCPhoneNumber;
        private TextBox TxtCAddress;
        private FontAwesome.Sharp.IconButton BtnSave;
        private FontAwesome.Sharp.IconButton BtnCancel;
    }
}