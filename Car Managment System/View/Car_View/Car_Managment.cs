using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Car_Managment_System.Controller;

namespace Car_Managment_System.View
{
    public partial class Car_Managment : MetroForm
    {
        VoitureController vc = new VoitureController();
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
            dataGridView1.DataSource = vc.Select();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous supprimer", "Message", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                string reference = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Boolean test = vc.remove(reference);
                if (test == true)
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
                MessageBox.Show("Annuler de supprimer cette voiture", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btRefrersh_Click(object sender, EventArgs e)
        {
            Refresh_();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdateCar u = new UpdateCar();
            u.setOldREf(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            u.txtReference.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            u.txtMarque.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() ;
            u.txtPrixJour.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString(); ;
            u.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vc.search(txtSearch.Text.ToString());
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Index i = new Index();
            i.Show();
            this.Hide();
        }
    }
}
