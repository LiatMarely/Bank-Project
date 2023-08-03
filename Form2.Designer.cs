
namespace Bank_Project
{
    partial class Form2
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
            this.panelMainSreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMainSreen
            // 
            this.panelMainSreen.BackColor = System.Drawing.SystemColors.Control;
            this.panelMainSreen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelMainSreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainSreen.Location = new System.Drawing.Point(0, 0);
            this.panelMainSreen.Name = "panelMainSreen";
            this.panelMainSreen.Size = new System.Drawing.Size(869, 553);
            this.panelMainSreen.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 553);
            this.Controls.Add(this.panelMainSreen);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainSreen;
    }
}