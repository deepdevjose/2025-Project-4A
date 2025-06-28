namespace JLaboratories.Presentation
{
    partial class SummaryCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCard = new System.Windows.Forms.Panel();
            iconPicture = new FontAwesome.Sharp.IconPictureBox();
            labelValue = new System.Windows.Forms.Label();
            labelTitle = new System.Windows.Forms.Label();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPicture).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCard.Controls.Add(iconPicture);
            panelCard.Controls.Add(labelValue);
            panelCard.Controls.Add(labelTitle);
            panelCard.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCard.Location = new System.Drawing.Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.Padding = new System.Windows.Forms.Padding(10);
            panelCard.Size = new System.Drawing.Size(200, 120);
            panelCard.TabIndex = 0;
            panelCard.Paint += panelCard_Paint;
            // 
            // iconPicture
            // 
            iconPicture.BackColor = System.Drawing.Color.Transparent;
            iconPicture.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPicture.IconColor = System.Drawing.Color.White;
            iconPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPicture.Location = new System.Drawing.Point(10, 10);
            iconPicture.Name = "iconPicture";
            iconPicture.Size = new System.Drawing.Size(32, 32);
            iconPicture.TabIndex = 0;
            iconPicture.TabStop = false;
            // 
            // labelValue
            // 
            labelValue.Dock = System.Windows.Forms.DockStyle.Top;
            labelValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            labelValue.ForeColor = System.Drawing.Color.White;
            labelValue.Location = new System.Drawing.Point(10, 10);
            labelValue.Name = "labelValue";
            labelValue.Size = new System.Drawing.Size(178, 50);
            labelValue.TabIndex = 1;
            labelValue.Text = "0";
            labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            labelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelTitle.Location = new System.Drawing.Point(10, 83);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(178, 25);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Title";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryCardControl
            // 
            Controls.Add(panelCard);
            Name = "SummaryCardControl";
            Size = new System.Drawing.Size(200, 120);
            panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private FontAwesome.Sharp.IconPictureBox iconPicture;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelTitle;
    }
}
