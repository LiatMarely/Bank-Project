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
    public partial class CreditCard : Form
    {
        private readonly RegularClient client;
        public CreditCard(int clientId)
        {
            InitializeComponent();
            this.client = PersonManager.GetPerson<RegularClient>(clientId);
            lblCCN.Text = this.client._creditCard.ToString();
            lblName.Text = this.client.Name;
        }

       
    }
}
