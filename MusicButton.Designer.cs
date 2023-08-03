
namespace Bank_Project
{
    partial class MusicButton
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
            this.pictureBoxMusic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMusic
            // 
            this.pictureBoxMusic.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMusic.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.SOUNDON;
            this.pictureBoxMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMusic.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMusic.Name = "pictureBoxMusic";
            this.pictureBoxMusic.Size = new System.Drawing.Size(57, 57);
            this.pictureBoxMusic.TabIndex = 23;
            this.pictureBoxMusic.TabStop = false;
            this.pictureBoxMusic.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // MusicButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBoxMusic);
            this.Name = "MusicButton";
            this.Size = new System.Drawing.Size(60, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMusic;
    }
}
