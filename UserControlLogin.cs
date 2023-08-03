using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Bank_Project
{
    public partial class UserControlLogin : UserControl
    {
        public Form2 parent;
        public int id_USER;
        public UserControlLogin(Form2 parent)
        {
            InitializeComponent();
            this.parent = parent;
            passwordTextBox.PasswordChar = '*';
            panelAboutUs.Visible = false;
            panelLogIn.Visible = true;
            linkgoback.Visible = false;
            panelContact.Visible = false;
          
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(usernameTextBox.Text, out int result))
            {
                id_USER = Int32.Parse(usernameTextBox.Text);
                if (usernameTextBox.Text.Equals(""))
                {
                    MessageBox.Show("Enter ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (passwordTextBox.Text.Equals(""))
                {
                    MessageBox.Show("Enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    int id = Int32.Parse(usernameTextBox.Text);
                    string password = passwordTextBox.Text;
                    ePersonsType currentUserType = PersonManager.FindPersonType(id, password);
                    if (currentUserType == ePersonsType.ClientsManager && id.Equals(1))
                    {
                        MessageBox.Show("Login successful");
                        this.parent.Form2_ShowAdmin();
                    }
                    else if (currentUserType == ePersonsType.ClientsManager)
                    {
                        MessageBox.Show("Login successful");
                        this.parent.Form2_ShowWorkerWindow(id);

                    }
                    else if (currentUserType == ePersonsType.None)
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                    else if (currentUserType == ePersonsType.RegularClient || currentUserType == ePersonsType.BuisnessClient)
                    {
                        MessageBox.Show("Login successful");
                        this.parent.Form2_ShowClientWindow(id, currentUserType);
                    }
                }

            }
            else
            {
                MessageBox.Show("ID text box is empty or contain non numeric char");
                this.btnClear_Click(null,null);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void linkAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogIn.Visible = false;
            panelAboutUs.Visible = true;
            linkgoback.Visible = true;
            linkAboutUs.Visible = false;

        }

        private void linkContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogIn.Visible = false;
            linkgoback.Visible = true;
            linkAboutUs.Visible = false;
            panelContact.Visible = true;
            linkContactUs.Visible = false;
        }

        public void linkgoback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.parent.Form2_Log_Out();
        }

        
    }
}
