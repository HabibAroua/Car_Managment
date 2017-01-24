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

        public List<Voiture> SelectAll()
        {
            List<Voiture> listVoiture = new List<Voiture>();
            string req = string.Format("SELECT reference , marque , carburant , prixparjour  FROM Voiture ");
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                decimal n = Reader.GetDecimal(3);
                Voiture v = new Voiture(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2),(int) n);

                listVoiture.Add(v);

            }
            Reader.Close();
            cn.Close();
            return listVoiture;


        }


    }
}
