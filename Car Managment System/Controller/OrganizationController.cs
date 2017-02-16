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
    public class OrganizationController : Crud
    {
        PLSQL plSql = new PLSQL();
        OleDbConnection cn ;
        OleDbCommand cmd;
        public OrganizationController()
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
            Organization org = (Organization)o;
            String cin = org.cin;
            String nom = org.nom;
            String adresse = org.adresse;
            String mail = org.mail;
            String telephone = org.telephone;

            try
            {
                string req = string.Format(plSql.PLSQL_Procedure("AjouterOrganization('" + cin + "','" + nom + "','" + adresse + "','" + mail + "' , '"+telephone+"')"));
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
        public Boolean remove(Object o)
        {
            String cin = (String)o;
            try
            {
                string req = string.Format(plSql.PLSQL_Procedure("Delete_Organization('" + cin + "')"));
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
            Organization o = (Organization)el;
            String cin = o.cin;
            String nom = o.nom;
            String adresse = o.adresse;
            String mail = o.mail;
            String telephone = o.telephone;
            try
            {
                string req = string.Format(plSql.PLSQL_Procedure("ModifierOrganization('"+cin+"' , '"+nom+"' , '"+adresse+"' , '"+mail+"' , '"+telephone+"' , '"+oldCin+"')"));
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

        public DataTable SelectAll()
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("select *  From Organization where cin!='0' ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Organization");
            tab1 = dtst.Tables["Organization"];
            return tab1;
        }

        public DataTable Search(String nom)
        {
            OleDbDataAdapter adap1;
            DataTable tab1;
            adap1 = new OleDbDataAdapter("SELECT *  FROM Organization where nom like LOWER('" + nom + "%') or nom like UPPER('" + nom + "%')  ", Properties.Settings.Default.ch);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Organization");
            tab1 = dtst.Tables["Organization"];
            return tab1;
        }
    }
}
