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
    public class VoitureController : Crud
    {
        OleDbConnection cn = new OleDbConnection(Properties.Settings.Default.ch);
        OleDbCommand cmd = new OleDbCommand();
        public VoitureController()
        {

        }

        public Boolean add(Object o)
        {
            Voiture v = (Voiture)o;
            String reference = v.reference;
            String marque = v.marque;
            String carburant = v.carburant;
            int prixParJour = v.prixParJour;
            
            try
            {
                string req = string.Format("Begin AjouterVoiture('" + reference + "','" +marque + "','" + carburant + "'," + prixParJour + "); end; ");
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch(OleDbException)
            {
                return false;
            }

        }

    }
}
