
namespace Bank_Project
{
    partial class FormGetLoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAccept = new System.Windows.Forms.CheckBox();
            this.txtNUm = new System.Windows.Forms.TextBox();
            this.btnGetLoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the amount of money to loan, up to 10,000 USD";
            // 
            // cbAccept
            // 
            this.cbAccept.AutoSize = true;
            this.cbAccept.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccept.Location = new System.Drawing.Point(15, 125);
            this.cbAccept.Name = "cbAccept";
            this.cbAccept.Size = new System.Drawing.Size(198, 21);
            this.cbAccept.TabIndex = 1;
            this.cbAccept.Text = "I Accept terms of service";
            this.cbAccept.UseVisualStyleBackColor = true;
            this.cbAccept.CheckedChanged += new System.EventHandler(this.cbAccept_CheckedChanged);
            // 
            // txtNUm
            // 
            this.txtNUm.Location = new System.Drawing.Point(15, 84);
            this.txtNUm.Name = "txtNUm";
            this.txtNUm.Size = new System.Drawing.Size(154, 22);
            this.txtNUm.TabIndex = 2;
            // 
            // btnGetLoan
            // 
            this.btnGetLoan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetLoan.FlatAppearance.BorderSize = 0;
            this.btnGetLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLoan.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetLoan.Location = new System.Drawing.Point(299, 113);
            this.btnGetLoan.Name = "btnGetLoan";
            this.btnGetLoan.Size = new System.Drawing.Size(106, 33);
            this.btnGetLoan.TabIndex = 3;
            this.btnGetLoan.Text = "Get Loan";
            this.btnGetLoan.UseVisualStyleBackColor = false;
            this.btnGetLoan.Click += new System.EventHandler(this.btnGetLoan_Click);
            // 
            // FormGetLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(428, 183);
            this.Controls.Add(this.btnGetLoan);
            this.Controls.Add(this.txtNUm);
            this.Controls.Add(this.cbAccept);
            this.Controls.Add(this.label1);
            this.Name = "FormGetLoan";
            this.Text = "FormGetLoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAccept;
        private System.Windows.Forms.TextBox txtNUm;
        private System.Windows.Forms.Button btnGetLoan;
    }
}