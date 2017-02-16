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
using Car_Managment_System.View.Clients_View.Organization_View;

namespace Car_Managment_System.View
{
    public partial class Organization_Managment : MetroForm
    {
        OrganizationController oc = new OrganizationController();
        public Organization_Managment()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Clients_Managment cm = new Clients_Managment();
            cm.Show();
            this.Close();
        }

        private void _Refresh()
        {
            dataGridView1.DataSource = oc.SelectAll();
        }

        private void Organization_Managment_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btRefrersh_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Add_Organization ao = new Add_Organization();
            ao.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous supprimer", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                string cin = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Boolean test = oc.remove(cin);
                if (test == true)
                {
                    MessageBox.Show("Cette Organization est déjà supprimé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur de suppression", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Annuler de supprimer cette voiture", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource= oc.Search(txtSearch.Text.ToString());
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Uppdate_Organization uo = new Uppdate_Organization();
            uo.Show();
            uo.setOldCin(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            uo.txtCin.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
            uo.txtNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); 
            uo.txtAdresse.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            uo.txtMail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            uo.txtTelephone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
