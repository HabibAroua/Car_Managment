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
    public partial class UpdateCar : MetroForm
    {
        public String oldRef;
        public UpdateCar()
        {
            InitializeComponent();
        }
        public void setOldREf(String oldRef)
        {
            this.oldRef = oldRef;
        }

        public String getOldREF()
        {
            return this.oldRef;
        }
        private void UpdateCar_Load(object sender, EventArgs e)
        {
            carburantCamboBox.Items.Add("Essence");
            carburantCamboBox.Items.Add("GPL");
            carburantCamboBox.Items.Add("Gazoile");
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous annuller la modification ?", "Message", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            String marque = txtMarque.Text.ToString();
            String reference = txtReference.Text.ToString();
            String carburant = carburantCamboBox.SelectedItem.ToString();
            int nbJour = int.Parse(txtPrixJour.Text.ToString());
            Voiture v = new Voiture(reference, marque, carburant, nbJour);
            VoitureController vc = new VoitureController();
            Boolean test=vc.uppdate(getOldREF(),v);
            if(test==true)
            {
                MessageBox.Show("Modification effectué avec succés","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
