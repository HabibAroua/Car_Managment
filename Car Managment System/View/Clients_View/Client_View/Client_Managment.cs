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
using Car_Managment_System.View.Clients_View;
using Car_Managment_System.View.Clients_View.Client_View;

namespace Car_Managment_System.View
{
    public partial class Client_Managment : MetroForm
    {
        ClientController cc = new ClientController();
        public Client_Managment()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Clients_Managment cls = new Clients_Managment();
            cls.Show();
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous supprimer ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                string cin = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Boolean test = cc.remove(cin);
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddClient ac = new AddClient();
            ac.Show();    
        }

        private void _Refresh()
        {
            dataGridView1.DataSource = cc.SelectAll();
        }
        private void Client_Managment_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void btRefrersh_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource=cc.Search(txtSearch.Text.ToString());
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdateClient up = new UpdateClient();
            up.Show();
            up.setOldCin(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            up.txtCin.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            up.txtNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            up.txtPrenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            up.txtOccupation.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            up.txtAdresse.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            up.txtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            up.txtTelephone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
