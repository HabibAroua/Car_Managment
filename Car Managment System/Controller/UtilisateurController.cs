using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Managment_System.Model;
using System.Data;
using System.Data.OleDb;

namespace Car_Managment_System.Controller
{
    class UtilisateurController : Crud
    {
        public UtilisateurController()
        {

        }
        public Boolean add(Object o)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection();
                cn.ConnectionString = Properties.Settings.Default.ch;
                OleDbCommand cmd = new OleDbCommand();
                Utilisateur u = (Utilisateur)o;
                String login = u.compte.login;
                String password = u.compte.password;
                String nom = u.nom;
                String prenom = u.prenom;
                String mail = u.mail;
                Cryptage cr = new Cryptage();
                string req = string.Format("Begin Inscrire('" + login + "','" +cr.Encrypt(password) + "','" + nom + "','" + prenom + "','" + mail + "'); end; ");
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
