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
        OleDbConnection cn; 
        OleDbCommand cmd;
        PLSQL plSql = new PLSQL();
        public VoitureController()
        {
            try
            {
                cn= new OleDbConnection(Properties.Settings.Default.ch);
                cmd = new OleDbCommand();
            }
            catch(OleDbException)
            {

            }
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
                string req = string.Format(plSql.PLSQL_Procedure("AjouterVoiture('" + reference + "','" +marque + "','" + carburant + "'," + prixParJour + ")"));
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

        public Boolean remove(Object o)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection();
                cn.ConnectionString = Properties.Settings.Default.ch;
                OleDbCommand cmd = new OleDbCommand();
                String reference = (String)o;
                string req = string.Format(" delete Voiture where reference='" + reference + "' ");
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch(OleDbException)
            {
                return true;
            }
        }

        public List<Voiture> SelectAll()
        {
            List<Voiture> listVoiture = new List<Voiture>();
            string req = string.Format("SELECT reference , marque , carburant , prixparjour  FROM Voiture");
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                decimal n = Reader.GetDecimal(3);
                Voiture v = new Voiture(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), (int)n);

                listVoiture.Add(v);

            }
            Reader.Close();
            cn.Close();
            return listVoiture;
        }

        public List<Voiture> Search(String r)
        {
            List<Voiture> listVoiture = new List<Voiture>();
            string req = string.Format("SELECT reference , marque , carburant , prixparjour  FROM Voiture where marque like LOWER('%"+r+ "') or marque like UPPER('%" + r + "') ");
            cn.Open();
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                decimal n = Reader.GetDecimal(3);
                Voiture v = new Voiture(Reader.GetString(0), Reader.GetString(1), Reader.GetString(2), (int)n);

                listVoiture.Add(v);

            }
            Reader.Close();
            cn.Close();
            return listVoiture;
        }

        public DataTable search(String marque)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("SELECT reference , marque , carburant , prixparjour  FROM Voiture where marque like LOWER('" + marque + "%') or marque like UPPER('" + marque + "%') ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Voiture");
            tab1 = dtst.Tables["Voiture"];
            return tab1;
        }

        public DataTable Select()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select Reference , Marque , Carburant , PrixParJour  From Voiture ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Voiture");
            tab1 = dtst.Tables["Voiture"];
            return  tab1;
            
        }

        public Boolean uppdate(Object id, Object el)
        {
            Voiture v = (Voiture)el;
            String reference = v.reference;
            String marque = v.marque;
            String carburant = v.carburant;
            int prixParJour = v.prixParJour;
            String oldReference = (String)id;
            try
            {
                string req = string.Format(plSql.PLSQL_Procedure("ModifierVoiture('" + reference + "','" + marque + "','" + carburant + "'," + prixParJour + " , '"+ oldReference +"')"));
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                cn.Close();
                return true;
            }
            catch (OleDbException)
            {
                return false;
            }
        }


    }
}
