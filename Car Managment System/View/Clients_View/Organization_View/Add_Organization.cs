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
    public partial class Add_Organization : MetroForm
    {
        public Add_Organization()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OrganizationController oc = new OrganizationController();
            Boolean test = oc.add(new Organization(txtCin.Text.ToString(), txtNom.Text.ToString(), txtAdresse.Text.ToString(), txtMail.Text.ToString(), txtTelephone.Text.ToString()));
            if (test == true)
            {
                MessageBox.Show("Cette organization est ajouté avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur d'ajout", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
