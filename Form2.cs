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
    
    public partial class Form2 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
            
            this.Text = "Welcome";

            this.FormClosing += new FormClosingEventHandler(PersonManager.savePersons);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panelMainSreen.Controls.Add(new UserControlLogin(this));

        }

        public void Form2_ShowAdmin()
        {
            this.Text = "Admin";
            panelMainSreen.Controls.Clear();
            panelMainSreen.Controls.Add(new Ucl_Admin(this));
        }

        public void Form2_ShowClientWindow(int id, ePersonsType clientType)
        {
            this.Text = "Welcome";
            panelMainSreen.Controls.Clear();
            panelMainSreen.Controls.Add(new UCL_Client(id, clientType, this));
        }


        public void Form2_ShowWorkerWindow(int id)
        {
            this.Text = "Welcome";
            panelMainSreen.Controls.Clear();
            panelMainSreen.Controls.Add(new Ucl_Worker(id, this));
        }

        public void Form2_Log_Out()
        {
            panelMainSreen.Controls.Clear();
            panelMainSreen.Controls.Add(new UserControlLogin(this));
            this.Text = "Welcome";

        }
    }
}
