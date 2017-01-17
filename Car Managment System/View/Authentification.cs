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

namespace Car_Managment_System
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btConnect.Enabled = false;
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
            
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if ((txtLogin.Text.ToString().Equals("")) || (txtPassword.Text.ToString().Equals("")))
            {
                btConnect.Enabled = false;
            }
            else
            {
                btConnect.Enabled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if ((txtLogin.Text.ToString().Equals("")) || (txtPassword.Text.ToString().Equals("")))
            {
                btConnect.Enabled = false;
            }
            else
            {
                btConnect.Enabled = true;
            }
        }

        private void Suscribe_Click(object sender, EventArgs e)
        {
            Car_Managment_System.View.Suscribecs s = new View.Suscribecs();
            s.Show();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            Car_Managment_System.Controller.CompteController cm = new Controller.CompteController();
            if (cm.compteIsExist(txtLogin.Text.ToString(), txtPassword.Text.ToString()))
            {
                Car_Managment_System.View.Index i = new View.Index();
                i.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vérifier votre login et votre Mot de passe","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
