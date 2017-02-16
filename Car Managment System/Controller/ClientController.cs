using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Car_Managment_System.Model;

namespace Car_Managment_System.Controller
{
    public class ClientController : Crud
    {
        OleDbConnection cn;
        OleDbCommand cmd;
        PLSQL plSql = new PLSQL();

        public ClientController()
        {
            try
            {
                cn = new OleDbConnection(Properties.Settings.Default.ch);
                cmd = new OleDbCommand();
            }
            catch(OleDbException)
            {
                
            }
        }

        public Boolean add(Object o)
        {
            Client c = (Client)o;
            String cin = c.cin;
            String nom = c.nom;
            String prenom = c.prenom;
            String occupation = c.occupation;
            String adresse = c.adresse;
            String mail = c.mail;
            String telephone = c.telephone;
            try
            {
                string req = string.Format(plSql.PLSQL_Procedure("AjouterClient('"+cin+"' , '"+nom+"' , '"+prenom+"' , '"+occupation+"' , '"+adresse+"' , '"+mail+"' , '"+telephone+"' )"));
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(OleDbException)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public Boolean remove(Object o)
        {
            String cin = (String)o;
            try
            {
                string req = string.Format(plSql.PLSQL_Procedure("SupprimerClient('" + cin + "')"));
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

        }
        public Boolean uppdate(Object id, Object el)
        {
            String oldCin = (String)id;
            Client c = (Client)el;
            String cin = c.cin;
            String nom = c.nom;
            String prenom = c.prenom;
            String occupation = c.occupation;
            String adresse = c.adresse;
            String mail = c.mail;
            String telephone = c.telephone;
            try
            {
                string req = string.Format(plSql.PLSQL_Procedure("ModifierClient('" + cin + "' , '" + nom + "' , '" + prenom + "' , '" + occupation + "' , '" + adresse + "' , '" + mail + "' , '" + telephone + "', '"+oldCin+"' )"));
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OleDbException)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable SelectAll()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("SELECT *  FROM Client where cin!='0'  ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Client");
            tab1 = dtst.Tables["Client"];
            return tab1;
        }

        public DataTable Search(String nom)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("SELECT *  FROM Client where nom like LOWER('" + nom + "%') or nom like UPPER('" + nom + "%')  ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Client");
            tab1 = dtst.Tables["Client"];
            return tab1;
        }
    }
}
