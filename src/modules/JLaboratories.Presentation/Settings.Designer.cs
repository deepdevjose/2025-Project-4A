namespace JLaboratories.Presentation
{
    partial class Settings
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
            roundedCard1 = new RoundedCard();
            roundedCard2 = new RoundedCard();
            label1 = new Label();
            label2 = new Label();
            txtCadena = new TextBox();
            LblDate = new Label();
            BtnClose = new FontAwesome.Sharp.IconPictureBox();
            roundedCard7 = new RoundedCard();
            ((System.ComponentModel.ISupportInitialize)BtnClose).BeginInit();
            SuspendLayout();
            // 
            // roundedCard1
            // 
            roundedCard1.CornerRadius = 20;
            roundedCard1.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard1.Location = new Point(12, 12);
            roundedCard1.Name = "roundedCard1";
            roundedCard1.Size = new Size(560, 432);
            roundedCard1.TabIndex = 0;
            // 
            // roundedCard2
            // 
            roundedCard2.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard2.CornerRadius = 20;
            roundedCard2.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard2.Location = new Point(28, 31);
            roundedCard2.Name = "roundedCard2";
            roundedCard2.Size = new Size(527, 394);
            roundedCard2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(209, 107);
            label1.Name = "label1";
            label1.Size = new Size(150, 46);
            label1.TabIndex = 3;
            label1.Text = "Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.ForeColor = Color.White;
            label2.Location = new Point(209, 214);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 6;
            label2.Text = "Cadena de conexión:";
            // 
            // txtCadena
            // 
            txtCadena.Location = new Point(135, 258);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(304, 27);
            txtCadena.TabIndex = 7;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.BackColor = Color.FromArgb(40, 40, 40);
            LblDate.Font = new Font("Segoe UI", 8F);
            LblDate.ForeColor = Color.White;
            LblDate.Location = new Point(533, 393);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(30, 19);
            LblDate.TabIndex = 86;
            LblDate.Text = "Exit";
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.FromArgb(40, 40, 40);
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.PersonRunning;
            BtnClose.IconColor = Color.White;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnClose.IconSize = 50;
            BtnClose.Location = new Point(524, 345);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(50, 50);
            BtnClose.TabIndex = 85;
            BtnClose.TabStop = false;
            // 
            // roundedCard7
            // 
            roundedCard7.BackColor = Color.FromArgb(30, 30, 30);
            roundedCard7.CornerRadius = 15;
            roundedCard7.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard7.Location = new Point(501, 330);
            roundedCard7.Name = "roundedCard7";
            roundedCard7.Size = new Size(90, 90);
            roundedCard7.TabIndex = 84;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(584, 456);
            Controls.Add(LblDate);
            Controls.Add(BtnClose);
            Controls.Add(roundedCard7);
            Controls.Add(txtCadena);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roundedCard2);
            Controls.Add(roundedCard1);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)BtnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedCard roundedCard1;
        private RoundedCard roundedCard2;
        private Label label1;
        private Label label2;
        private TextBox txtCadena;
        private Label LblDate;
        private FontAwesome.Sharp.IconPictureBox BtnClose;
        private RoundedCard roundedCard7;
    }
}