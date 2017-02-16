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
using Car_Managment_System.View;

namespace Car_Managment_System.View
{
    public partial class Index : MetroForm
    {
        public Index()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Car_Managment cm = new Car_Managment();
            cm.Show();
            this.Hide();
        }

        private void ClientTitle_Click(object sender, EventArgs e)
        {
            Clients_Managment cm = new Clients_Managment();
            cm.Show();
            this.Hide();
        }

        private void btExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
