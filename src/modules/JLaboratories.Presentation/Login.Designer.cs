namespace JLaboratories.Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            roundedCard1 = new RoundedCard();
            roundedCard2 = new RoundedCard();
            label1 = new Label();
            roundedCard3 = new RoundedCard();
            roundedCard4 = new RoundedCard();
            label2 = new Label();
            label3 = new Label();
            TxtPassword = new TextBox();
            CmbUser = new ComboBox();
            BtnExit = new FontAwesome.Sharp.IconButton();
            BtnOk = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedCard1
            // 
            roundedCard1.CornerRadius = 25;
            roundedCard1.DividerColor = Color.FromArgb(40, 40, 40);
            roundedCard1.Location = new Point(10, 12);
            roundedCard1.Name = "roundedCard1";
            roundedCard1.Size = new Size(462, 429);
            roundedCard1.TabIndex = 0;
            // 
            // roundedCard2
            // 
            roundedCard2.BackColor = Color.FromArgb(40, 40, 40);
            roundedCard2.CornerRadius = 25;
            roundedCard2.DividerColor = Color.FromArgb(30, 30, 30);
            roundedCard2.Location = new Point(28, 26);
            roundedCard2.Name = "roundedCard2";
            roundedCard2.Size = new Size(427, 400);
            roundedCard2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(179, 90);
            label1.Name = "label1";
            label1.Size = new Size(130, 46);
            label1.TabIndex = 2;
            label1.Text = "Log in!";
            // 
            // roundedCard3
            // 
            roundedCard3.BackColor = Color.FromArgb(30, 30, 30);
            roundedCard3.CornerRadius = 20;
            roundedCard3.DividerColor = Color.FromArgb(20, 20, 20);
            roundedCard3.Location = new Point(36, 36);
            roundedCard3.Name = "roundedCard3";
            roundedCard3.Size = new Size(42, 379);
            roundedCard3.TabIndex = 3;
            // 
            // roundedCard4
            // 
            roundedCard4.BackColor = Color.FromArgb(30, 30, 30);
            roundedCard4.CornerRadius = 20;
            roundedCard4.DividerColor = Color.FromArgb(20, 20, 20);
            roundedCard4.Location = new Point(385, 180);
            roundedCard4.Name = "roundedCard4";
            roundedCard4.Size = new Size(99, 103);
            roundedCard4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.ForeColor = Color.White;
            label2.Location = new Point(121, 165);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "User:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.ForeColor = Color.White;
            label3.Location = new Point(121, 242);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(135, 274);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(151, 27);
            TxtPassword.TabIndex = 7;
            // 
            // CmbUser
            // 
            CmbUser.FormattingEnabled = true;
            CmbUser.Location = new Point(135, 196);
            CmbUser.Name = "CmbUser";
            CmbUser.Size = new Size(151, 28);
            CmbUser.TabIndex = 8;
            // 
            // BtnExit
            // 
            BtnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnExit.IconColor = Color.Black;
            BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnExit.Location = new Point(141, 339);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(53, 29);
            BtnExit.TabIndex = 9;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnOk
            // 
            BtnOk.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            BtnOk.IconColor = Color.Black;
            BtnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnOk.IconSize = 20;
            BtnOk.ImageAlign = ContentAlignment.BottomLeft;
            BtnOk.Location = new Point(218, 339);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(68, 29);
            BtnOk.TabIndex = 10;
            BtnOk.Text = "Ok";
            BtnOk.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(20, 20, 20);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 70;
            iconPictureBox1.Location = new Point(402, 195);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(70, 74);
            iconPictureBox1.TabIndex = 11;
            iconPictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(292, 274);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(26, 27);
            iconButton1.TabIndex = 12;
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(482, 453);
            Controls.Add(iconButton1);
            Controls.Add(iconPictureBox1);
            Controls.Add(BtnOk);
            Controls.Add(BtnExit);
            Controls.Add(CmbUser);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(roundedCard4);
            Controls.Add(roundedCard3);
            Controls.Add(label1);
            Controls.Add(roundedCard2);
            Controls.Add(roundedCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in!";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedCard roundedCard1;
        private RoundedCard roundedCard2;
        private Label label1;
        private RoundedCard roundedCard3;
        private RoundedCard roundedCard4;
        private Label label2;
        private Label label3;
        private TextBox TxtPassword;
        private ComboBox CmbUser;
        private FontAwesome.Sharp.IconButton BtnExit;
        private FontAwesome.Sharp.IconButton BtnOk;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}