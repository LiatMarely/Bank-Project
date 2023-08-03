using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class FormGetLoan : Form
    {
        private Client client;
        Form2 form;

        public FormGetLoan(Client client, Form2 form)
        {
            InitializeComponent();
            this.form=form;
            btnGetLoan.Enabled = false;
            this.client = client;
        }

        private void cbAccept_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAccept.Checked)
            {
                btnGetLoan.Enabled = true;
            }
            else
                btnGetLoan.Enabled = false;
        }

        private void btnGetLoan_Click(object sender, EventArgs e)
        {
            if(VerifyNum())
            {
                int loanAm = Int32.Parse(txtNUm.Text);
                client.loans.Add(loanAm);
                client._balance += loanAm;
                MessageBox.Show("Confirned", "Confirned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        public bool VerifyNum()
        {
            int temp;
            if (txtNUm.Text.Length == 0)
            {
                MessageBox.Show("The text boxes is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (Int32.TryParse(txtNUm.Text, out temp) == false)
            {
                MessageBox.Show("Text box is empty or contain non numeric char", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(Int32.Parse(txtNUm.Text)>10000)
            {
                MessageBox.Show("Please enter a value up to 10,000 USD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNUm.Text = "";
                cbAccept.Checked = false;
                return false;

            }
            return true;
        }

        
    }
}
