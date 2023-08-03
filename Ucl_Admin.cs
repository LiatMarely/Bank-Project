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
    public partial class Ucl_Admin : UserControl
    {
        private Form2 parentt;
        public Ucl_Admin(Form2 parentt)
        {
            InitializeComponent();
            this.parentt = parentt;

        }

        private void cmoAdminchoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTable(null, null);
        }

        private void dataGridViewAdmain_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Person person = (Person)e.Row.DataBoundItem;
            PersonManager.RemovePerson(person);
        }

        //Add worker
        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson(ePersonsType.ClientsManager); // create new form
            addPerson.FormClosed += new FormClosedEventHandler(updateTable);
            addPerson.ShowDialog(); // show the form
        }

        //Add client
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson(ePersonsType.RegularClient, ePersonsType.BuisnessClient); // create new form
            addPerson.FormClosed += new FormClosedEventHandler(updateTable);
            addPerson.ShowDialog(); // show the form
        }

        //show in datagrid the wanted chois
        public void updateTable(object sender, FormClosedEventArgs e)
        {
            if (cmoAdminchoise.SelectedItem != null)
            {
                if (cmoAdminchoise.SelectedItem.ToString() == "Workers")
                {
                    dataGridViewAdmain.DataSource = PersonManager.GetSpecificPersons<ClientsManager>();
                    dataGridViewAdmain.Columns.Remove("Password");
                }

                else if (cmoAdminchoise.SelectedItem.ToString() == "Clients")
                {
                    dataGridViewAdmain.DataSource = PersonManager.GetSpecificPersons<Client>();
                    dataGridViewAdmain.Columns.Remove("Password");
                    dataGridViewAdmain.Columns.Remove("_creditCard");
                }
            }
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.parentt.Form2_Log_Out();
        }
    }
}




