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
using Car_Managment_System;
using Car_Managment_System.Controller;
using Car_Managment_System.Model;
namespace Car_Managment_System.View
{
    public partial class AddCar : MetroForm
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            carburantCamboBox.Items.Add("Essence");
            carburantCamboBox.Items.Add("GPL");
            carburantCamboBox.Items.Add("Gazoile");
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            txtReference.Clear();
            txtPrixJour.Clear();
            txtPrixJour.Clear();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            String marque = txtMarque.Text.ToString();
            String reference= txtReference.Text.ToString();
            String carburant = carburantCamboBox.SelectedItem.ToString();
            int nbJour = int.Parse(txtPrixJour.Text.ToString());
            Voiture v = new Voiture(reference,marque,carburant,nbJour);
            VoitureController vc = new VoitureController();
            Boolean test = vc.add(v);
            if(test==true)
            {
                MessageBox.Show("Ajout effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Problém d'Ajout","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
