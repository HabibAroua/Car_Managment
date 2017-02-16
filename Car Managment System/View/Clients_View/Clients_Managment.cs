using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Car_Managment_System.Controller;
using Car_Managment_System.Model;

namespace Car_Managment_System.View
{
    public partial class Clients_Managment : MetroForm
    {
        public Clients_Managment()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Index i = new Index();
            i.Show();
            this.Close();
        }

        private void btOrganizationManagment_Click(object sender, EventArgs e)
        {
            Organization_Managment om = new Organization_Managment();
            om.Show();
            this.Close();
        }

        private void btClientManagment_Click(object sender, EventArgs e)
        {
            Client_Managment cm = new Client_Managment();
            cm.Show();
            this.Close();
        }
    }
}
