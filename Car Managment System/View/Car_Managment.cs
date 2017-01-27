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
    public partial class Car_Managment : MetroForm
    {
        public Car_Managment()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }

        private void Car_Managment_Load(object sender, EventArgs e)
        {
            Refresh_();
        }

        private void Refresh_()
        {
            VoitureController vc = new VoitureController();
            List<Voiture> list = vc.SelectAll();
            dataGridView1.DataSource = vc.Select();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            VoitureController vc = new VoitureController();
            DialogResult a = MessageBox.Show("Voulez vous supprimer", "Message", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                string reference = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Boolean test=vc.remove(reference);
                if(test==true)
                {
                    MessageBox.Show("Cette voiture est déjà supprimé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur de duppression", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Annuler de supprimer cette voiture","Message",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            
        }

        private void btRefrersh_Click(object sender, EventArgs e)
        {
            Refresh_();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdateCar u = new UpdateCar();
            u.Show();
        }
    }
}
