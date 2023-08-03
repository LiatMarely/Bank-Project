
namespace Bank_Project
{
    partial class Ucl_Admin
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
            this.cmoAdminchoise = new System.Windows.Forms.ComboBox();
            this.txtAdmin = new System.Windows.Forms.Label();
            this.txtadmin1 = new System.Windows.Forms.Label();
            this.dataGridViewAdmain = new System.Windows.Forms.DataGridView();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.musicButton1 = new Coraliat_Bank_Il.MusicButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmoAdminchoise
            // 
            this.cmoAdminchoise.FormattingEnabled = true;
            this.cmoAdminchoise.Items.AddRange(new object[] {
            "Workers",
            "Clients"});
            this.cmoAdminchoise.Location = new System.Drawing.Point(175, 176);
            this.cmoAdminchoise.Name = "cmoAdminchoise";
            this.cmoAdminchoise.Size = new System.Drawing.Size(144, 24);
            this.cmoAdminchoise.TabIndex = 0;
            this.cmoAdminchoise.SelectedIndexChanged += new System.EventHandler(this.cmoAdminchoise_SelectedIndexChanged);
            // 
            // txtAdmin
            // 
            this.txtAdmin.AutoSize = true;
            this.txtAdmin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAdmin.Location = new System.Drawing.Point(66, 34);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(214, 28);
            this.txtAdmin.TabIndex = 1;
            this.txtAdmin.Text = "Welcome Admin!";
            // 
            // txtadmin1
            // 
            this.txtadmin1.AutoSize = true;
            this.txtadmin1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmin1.Location = new System.Drawing.Point(171, 154);
            this.txtadmin1.Name = "txtadmin1";
            this.txtadmin1.Size = new System.Drawing.Size(102, 19);
            this.txtadmin1.TabIndex = 2;
            this.txtadmin1.Text = "Open data:";
            // 
            // dataGridViewAdmain
            // 
            this.dataGridViewAdmain.AllowUserToAddRows = false;
            this.dataGridViewAdmain.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridViewAdmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmain.Location = new System.Drawing.Point(337, 183);
            this.dataGridViewAdmain.Name = "dataGridViewAdmain";
            this.dataGridViewAdmain.RowHeadersWidth = 51;
            this.dataGridViewAdmain.RowTemplate.Height = 24;
            this.dataGridViewAdmain.Size = new System.Drawing.Size(453, 299);
            this.dataGridViewAdmain.TabIndex = 3;
            this.dataGridViewAdmain.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewAdmain_UserDeletingRow);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLogOut.Location = new System.Drawing.Point(633, 40);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(69, 20);
            this.lblLogOut.TabIndex = 6;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonAddWorker);
            this.panel1.Controls.Add(this.buttonAddClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 553);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.LOGO222;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-21, -30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 164);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddWorker.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.ADD;
            this.buttonAddWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddWorker.FlatAppearance.BorderSize = 0;
            this.buttonAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWorker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddWorker.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddWorker.Location = new System.Drawing.Point(14, 140);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(124, 122);
            this.buttonAddWorker.TabIndex = 4;
            this.buttonAddWorker.Text = "Add Worker";
            this.buttonAddWorker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddWorker.UseVisualStyleBackColor = false;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddClient.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.ADD;
            this.buttonAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddClient.FlatAppearance.BorderSize = 0;
            this.buttonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddClient.Location = new System.Drawing.Point(14, 268);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(124, 124);
            this.buttonAddClient.TabIndex = 5;
            this.buttonAddClient.Text = "Add Client";
            this.buttonAddClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddClient.UseVisualStyleBackColor = false;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.user2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-27, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 77);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.txtAdmin);
            this.panel2.Controls.Add(this.lblLogOut);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 82);
            this.panel2.TabIndex = 8;
            // 
            // musicButton1
            // 
            this.musicButton1.BackColor = System.Drawing.Color.Transparent;
            this.musicButton1.Location = new System.Drawing.Point(806, 490);
            this.musicButton1.Name = "musicButton1";
            this.musicButton1.Size = new System.Drawing.Size(73, 63);
            this.musicButton1.TabIndex = 9;
            // 
            // Ucl_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.WhatsApp_Image_2023_05_29_at_16_012;
            this.Controls.Add(this.musicButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewAdmain);
            this.Controls.Add(this.txtadmin1);
            this.Controls.Add(this.cmoAdminchoise);
            this.Name = "Ucl_Admin";
            this.Size = new System.Drawing.Size(869, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmain)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmoAdminchoise;
        private System.Windows.Forms.Label txtAdmin;
        private System.Windows.Forms.Label txtadmin1;
        private System.Windows.Forms.DataGridView dataGridViewAdmain;
        private System.Windows.Forms.Button buttonAddWorker;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MusicButton musicButton1;
    }
}
