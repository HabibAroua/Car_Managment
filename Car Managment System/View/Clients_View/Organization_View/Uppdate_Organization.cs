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


namespace Car_Managment_System.View.Clients_View.Organization_View
{
    public partial class Uppdate_Organization : MetroForm
    {
        OrganizationController oc = new OrganizationController();
        public String oldCin;

        public String getOldCin()
        {
            return oldCin;
        }

        public void setOldCin(String oldCin)
        {
            this.oldCin = oldCin;
        }
        public Uppdate_Organization()
        {
            InitializeComponent();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            String cin = txtCin.Text.ToString();
            String nom = txtNom.Text.ToString();
            String adresse = txtAdresse.Text.ToString();
            String mail = txtMail.Text.ToString();
            String telephone = txtTelephone.Text.ToString();
            Organization o = new Organization(cin, nom, adresse, mail, telephone);
            Boolean test = oc.uppdate(getOldCin(),o);
            if(test==true)
            {
                MessageBox.Show("La mise à jour de cette organization est effétué avec succeés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur de mise à jour", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
