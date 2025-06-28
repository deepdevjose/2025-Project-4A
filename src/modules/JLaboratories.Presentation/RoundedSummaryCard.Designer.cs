using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace JLaboratories.Presentation
{
    partial class RoundedSummaryCard
    {
        private new IContainer components = null; // Agregado para evitar errores

        private IconPictureBox iconPicture;
        private Label lblTitle;
        private Label lblValue;


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
            iconPicture = new IconPictureBox();
            lblTitle = new Label();
            lblValue = new Label();
            ((ISupportInitialize)iconPicture).BeginInit();
            SuspendLayout();
            // 
            // iconPicture
            // 
            iconPicture.BackColor = Color.Transparent;
            iconPicture.IconChar = IconChar.None;
            iconPicture.IconColor = Color.White;
            iconPicture.IconFont = IconFont.Auto;
            iconPicture.Location = new Point(10, 10);
            iconPicture.Name = "iconPicture";
            iconPicture.Size = new Size(32, 32);
            iconPicture.TabIndex = 0;
            iconPicture.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(52, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(40, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValue.ForeColor = Color.White;
            lblValue.Location = new Point(52, 30);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(33, 37);
            lblValue.TabIndex = 2;
            lblValue.Text = "0";
            // 
            // RoundedSummaryCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(iconPicture);
            Controls.Add(lblTitle);
            Controls.Add(lblValue);
            Name = "RoundedSummaryCard";
            Size = new Size(150, 80);
            ((ISupportInitialize)iconPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
