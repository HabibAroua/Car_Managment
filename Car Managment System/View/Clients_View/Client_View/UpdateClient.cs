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
    public partial class UpdateClient : MetroForm
    {
        public String oldCin;
        ClientController cc = new ClientController();
        public UpdateClient()
        {
            InitializeComponent();
        }

        public String getOldCin()
        {
            return oldCin;
        }

        public void setOldCin(String oldCin)
        {
            this.oldCin = oldCin;
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            Boolean test = cc.uppdate(getOldCin(), new Client(txtCin.Text.ToString(), txtNom.Text.ToString(), txtPrenom.Text.ToString(), txtOccupation.Text.ToString(), txtAdresse.Text.ToString(), txtMail.Text.ToString(), txtTelephone.Text.ToString()));
            if(test==true)
            {
                MessageBox.Show("Modifier effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur de mise à jour", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
