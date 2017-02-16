using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Car_Managment_System.Controller;
using Car_Managment_System.Model;

namespace Car_Managment_System.View
{
    public partial class Suscribecs : MetroForm
    {
        public Suscribecs()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtLogin.Clear();
            txtFirstN.Clear();
            txtMail.Clear();
            txtConfPass.Clear();
            txtPassword.Clear();
            txtLastN.Clear();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.ToString().Equals(txtConfPass.Text.ToString()))
            {
                
                Compte c = new Model.Compte(txtLogin.Text.ToString(),txtPassword.Text.ToString());
                Utilisateur u = new Utilisateur(0, txtFirstN.Text.ToString(), txtLastN.Text.ToString(), txtMail.Text.ToString(), c);
                UtilisateurController uC=new UtilisateurController();
                Boolean test= uC.add(u);
                if (test == true)
                {
                    MessageBox.Show("Inscription efectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Inscription Echoué ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Verifier votre mot de passe","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
