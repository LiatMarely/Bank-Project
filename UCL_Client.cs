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
    public partial class UCL_Client : UserControl
    {
        private Client client;
        private Form2 frm;
        public UCL_Client(int clientId, ePersonsType clientType, Form2 frm)
        {
            this.frm = frm;
            InitializeComponent();
            if (clientType == ePersonsType.RegularClient)
            {
                this.client = PersonManager.GetPerson<RegularClient>(clientId);
                lblHelloClient.Text = "Welcome " + client.Name;
            } else
            {
                this.client = PersonManager.GetPerson<BuisnessClient>(clientId);
                lblHelloClient.Text = "Welcome buisness client " + client.Name;
            }
            updateTable(null, null);
            btnPayLoan1.Enabled = client.loans.Count() != 0;
        }

        
        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm.Form2_Log_Out();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditCard credit = new CreditCard(this.client.ID); // create new form
            credit.ShowDialog(); // show the form
        }

        public void btnGetLoan_Click(object sender, EventArgs e)
        {

            if (LoanAvailable()==true)
            {
                FormGetLoan getLoan = new FormGetLoan(client, frm); // create new form
               getLoan.FormClosed += new FormClosedEventHandler(updateTable);
                getLoan.ShowDialog(); // show the form
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = dataGridLoans.SelectedCells[0]; // Assuming you want the value from the first selected cell
            string selectedValue = selectedCell.Value.ToString();

            int data = Int32.Parse(selectedValue);
            client.DeleteLoan(data);
            client._balance -= data;

            //Refresh the DataGrid's data source
            updateTable(null, null);
        }




        public bool LoanAvailable()
        {
            if ((client.loans.Count()) < client.MaxLoans)
            {
                return true;
            }
            else
                return false;
            }
         

           public void updateTable(object sender, FormClosedEventArgs e)
        {

            dataGridLoans.Columns.Clear();
            dataGridView12.Columns.Clear();


            dataGridView12.Columns.Add("Name", "Name");
            dataGridView12.Columns.Add("ID Number", "ID Number");
            dataGridView12.Columns.Add("Balance", "Balance");
            dataGridLoans.Columns.Add("Loans", "Loans");
            dataGridView12.Rows.Add(client.Name, client.ID.ToString(), client._balance.ToString());

            foreach (int loans in this.client.loans)
            {
                dataGridLoans.Rows.Add(loans.ToString());
            }

            if (LoanAvailable())
            {
                btnGetLoan.Enabled = true;
            }
            else
            {
                btnGetLoan.Enabled = false;
            }
            btnPayLoan1.Enabled = client.loans.Count() != 0;

        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(client.RandomFact(), "Fact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm.Form2_Log_Out();
        }
    }


}

    

