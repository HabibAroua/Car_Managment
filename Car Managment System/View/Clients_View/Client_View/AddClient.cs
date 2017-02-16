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

namespace Car_Managment_System.View.Clients_View.Client_View
{
    public partial class AddClient : MetroForm
    {
        ClientController cc = new ClientController();
        public AddClient()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            Boolean test = cc.add(new Client(txtCin.Text.ToString(), txtNom.Text.ToString(), txtPrenom.Text.ToString(), txtOccupation.Text.ToString(), txtAdresse.Text.ToString(), txtMail.Text.ToString(), txtTelephone.Text.ToString()));
            if(test==true)
            {
                MessageBox.Show("Ajout effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur d'ajout","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
