
namespace Bank_Project
{
    partial class UCL_Client
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
            this.components = new System.ComponentModel.Container();
            this.lblHelloClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnPayLoan1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetLoan = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelINFO = new System.Windows.Forms.Panel();
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridLoans = new System.Windows.Forms.DataGridView();
            this.Loans = new System.Windows.Forms.Label();
            this.musicButton1 = new Bank_Project.MusicButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelINFO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloClient
            // 
            this.lblHelloClient.AutoSize = true;
            this.lblHelloClient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelloClient.Location = new System.Drawing.Point(235, 54);
            this.lblHelloClient.Name = "lblHelloClient";
            this.lblHelloClient.Size = new System.Drawing.Size(84, 28);
            this.lblHelloClient.TabIndex = 0;
            this.lblHelloClient.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lblHelloClient);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 108);
            this.panel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabel1.Location = new System.Drawing.Point(785, 62);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.UseMnemonic = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.LOGO222;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-15, -24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 164);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.user2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(138, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 77);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(121)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.btnFact);
            this.panel2.Controls.Add(this.btnPayLoan1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnGetLoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 445);
            this.panel2.TabIndex = 13;
            // 
            // btnFact
            // 
            this.btnFact.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFact.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.INFO3;
            this.btnFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFact.FlatAppearance.BorderSize = 0;
            this.btnFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFact.Location = new System.Drawing.Point(-11, 326);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(185, 119);
            this.btnFact.TabIndex = 11;
            this.btnFact.Text = "Fact";
            this.btnFact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFact.UseVisualStyleBackColor = false;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnPayLoan1
            // 
            this.btnPayLoan1.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPayLoan1.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.GETLOANNNNN;
            this.btnPayLoan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPayLoan1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayLoan1.FlatAppearance.BorderSize = 0;
            this.btnPayLoan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayLoan1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayLoan1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayLoan1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayLoan1.Location = new System.Drawing.Point(0, -16);
            this.btnPayLoan1.Name = "btnPayLoan1";
            this.btnPayLoan1.Size = new System.Drawing.Size(171, 123);
            this.btnPayLoan1.TabIndex = 2;
            this.btnPayLoan1.Text = "Pay loan";
            this.btnPayLoan1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayLoan1.UseVisualStyleBackColor = false;
            this.btnPayLoan1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.CREDITCARD1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(-15, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 109);
            this.button2.TabIndex = 3;
            this.button2.Text = "Credit Card";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGetLoan
            // 
            this.btnGetLoan.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGetLoan.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.GETTTTTTTTTTT;
            this.btnGetLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGetLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetLoan.FlatAppearance.BorderSize = 0;
            this.btnGetLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLoan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetLoan.Location = new System.Drawing.Point(-8, 103);
            this.btnGetLoan.Name = "btnGetLoan";
            this.btnGetLoan.Size = new System.Drawing.Size(179, 116);
            this.btnGetLoan.TabIndex = 9;
            this.btnGetLoan.Text = "Get loan";
            this.btnGetLoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGetLoan.UseVisualStyleBackColor = false;
            this.btnGetLoan.Click += new System.EventHandler(this.btnGetLoan_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panelINFO
            // 
            this.panelINFO.BackgroundImage = global::Coraliat_Bank_Il.Properties.Resources.WhatsApp_Image_2023_05_29_at_16_01_53;
            this.panelINFO.Controls.Add(this.musicButton1);
            this.panelINFO.Controls.Add(this.dataGridView12);
            this.panelINFO.Controls.Add(this.lblLogOut);
            this.panelINFO.Controls.Add(this.label1);
            this.panelINFO.Controls.Add(this.dataGridLoans);
            this.panelINFO.Controls.Add(this.Loans);
            this.panelINFO.Location = new System.Drawing.Point(166, 108);
            this.panelINFO.Name = "panelINFO";
            this.panelINFO.Size = new System.Drawing.Size(703, 442);
            this.panelINFO.TabIndex = 14;
            // 
            // dataGridView12
            // 
            this.dataGridView12.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView12.Location = new System.Drawing.Point(101, 92);
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.RowHeadersWidth = 51;
            this.dataGridView12.RowTemplate.Height = 24;
            this.dataGridView12.Size = new System.Drawing.Size(480, 83);
            this.dataGridView12.TabIndex = 5;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLogOut.Location = new System.Drawing.Point(1000, 7);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(61, 18);
            this.lblLogOut.TabIndex = 10;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account  information";
            // 
            // dataGridLoans
            // 
            this.dataGridLoans.AllowUserToAddRows = false;
            this.dataGridLoans.AllowUserToDeleteRows = false;
            this.dataGridLoans.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLoans.Location = new System.Drawing.Point(101, 232);
            this.dataGridLoans.Name = "dataGridLoans";
            this.dataGridLoans.ReadOnly = true;
            this.dataGridLoans.RowHeadersWidth = 51;
            this.dataGridLoans.RowTemplate.Height = 24;
            this.dataGridLoans.Size = new System.Drawing.Size(480, 184);
            this.dataGridLoans.TabIndex = 7;
            // 
            // Loans
            // 
            this.Loans.AutoSize = true;
            this.Loans.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loans.Location = new System.Drawing.Point(97, 210);
            this.Loans.Name = "Loans";
            this.Loans.Size = new System.Drawing.Size(56, 19);
            this.Loans.TabIndex = 8;
            this.Loans.Text = "Loans";
            // 
            // musicButton1
            // 
            this.musicButton1.BackColor = System.Drawing.Color.Transparent;
            this.musicButton1.Location = new System.Drawing.Point(640, 379);
            this.musicButton1.Name = "musicButton1";
            this.musicButton1.Size = new System.Drawing.Size(60, 60);
            this.musicButton1.TabIndex = 11;
            // 
            // UCL_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelINFO);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCL_Client";
            this.Size = new System.Drawing.Size(869, 553);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelINFO.ResumeLayout(false);
            this.panelINFO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblHelloClient;
        private System.Windows.Forms.Button btnPayLoan1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridLoans;
        private System.Windows.Forms.Label Loans;
        private System.Windows.Forms.Button btnGetLoan;
        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelINFO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MusicButton musicButton1;
    }
}
