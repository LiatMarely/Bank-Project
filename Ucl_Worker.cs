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

    public partial class Ucl_Worker : UserControl
    {
        private ClientsManager worker;
        private Form2 frm;
        public Ucl_Worker(int ID, Form2 frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.worker = PersonManager.GetPerson<ClientsManager>(ID);
            lblWorker.Text = "Welcome " + worker.Name+" !";

        }

        //show in datagrid the wanted chois
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChoise.SelectedItem.ToString() == "Clients")
            {
                dataGridClients.DataSource = PersonManager.GetSpecificPersons<RegularClient>();
                dataGridClients.Columns.Remove("Password");
                dataGridClients.Columns.Remove("_creditCard");

            }

            else if (cmbChoise.SelectedItem.ToString() == "Business Clients")
            {
                dataGridClients.DataSource = PersonManager.GetSpecificPersons<BuisnessClient>();
                dataGridClients.Columns.Remove("Password");
                dataGridClients.Columns.Remove("_creditCard");

            }
        }

        //log out
        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.frm.Form2_Log_Out();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson(ePersonsType.RegularClient, ePersonsType.BuisnessClient); // create new form
            addPerson.FormClosed += new FormClosedEventHandler(updateTable);
            addPerson.ShowDialog(); // show the form
        }



        public void updateTable(object sender, FormClosedEventArgs e)
        {
            if (cmbChoise.SelectedItem != null)
            {
                if (cmbChoise.SelectedItem.ToString() == "Business Clients")
                {
                    dataGridClients.DataSource = PersonManager.GetSpecificPersons<BuisnessClient>();
                    dataGridClients.Columns.Remove("Password");
                }

                else if (cmbChoise.SelectedItem.ToString() == "Clients")
                {
                    dataGridClients.DataSource = PersonManager.GetSpecificPersons<Client>();
                    dataGridClients.Columns.Remove("Password");
                    dataGridClients.Columns.Remove("_creditCard");
                }
            }
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(worker.RandomFact(), "Fact", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}


