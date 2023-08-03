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
    public partial class AddPerson : Form
    {
        public AddPerson(params ePersonsType[] personsType)
        {
            InitializeComponent();
            initComboBoxKinds(personsType);
            textBoxPassword.PasswordChar = '*';
            textBoxVerifyPassword.PasswordChar = '*';
        }

        private void initComboBoxKinds(ePersonsType[] personsType)
        {
            foreach(ePersonsType personType in personsType)
            {
                comboBoxKind.Items.Add(personType.ToString());
            }
            comboBoxKind.SelectedIndex = 0;
            changeDynamic();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (verifyForm() == true)
            {
                string name = textBoxName.Text;
                string password = textBoxPassword.Text;
                int id = Int32.Parse(textBoxID.Text);
                string selectedKind = comboBoxKind.SelectedItem.ToString();
                int dynamic = Int32.Parse(textBoxDynamic.Text);
                if (selectedKind.Equals(ePersonsType.ClientsManager.ToString()))
                {
                    PersonManager.AddPerson(new ClientsManager(dynamic, name, id, password));
                } 
                else if (selectedKind.Equals(ePersonsType.RegularClient.ToString()))
                {
                    PersonManager.AddPerson(new RegularClient(name, id, password, dynamic));
                } 
                else if (selectedKind.Equals(ePersonsType.BuisnessClient.ToString()))
                {
                    PersonManager.AddPerson(new BuisnessClient(name, id, password, dynamic));
                }
                MessageBox.Show("Added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }

        private bool verifyForm()
        {
            int id;
            if (textBoxName.Text.Length == 0 || textBoxPassword.Text.Length == 0 || textBoxVerifyPassword.Text.Length == 0)
            {
                MessageBox.Show("One of the text boxes is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } 
            else if (Int32.TryParse(textBoxID.Text, out id) == false)
            {
                MessageBox.Show("Password text box is empty or contain non numeric char", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } else if (!textBoxPassword.Text.Equals(textBoxVerifyPassword.Text)) {
                MessageBox.Show("Passwords are not equal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void comboBoxKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeDynamic();
        }

        private void changeDynamic()
        {
            if (comboBoxKind.SelectedItem.ToString().Equals(ePersonsType.ClientsManager.ToString()))
            {
                labelDynamic.Text = "WorkerID:";
            } else
            {
                labelDynamic.Text = "Balance:";
            }
        }
    }
}
