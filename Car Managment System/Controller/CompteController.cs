using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Car_Managment_System.Controller
{
    public class CompteController
    {
        OleDbConnection cn = new OleDbConnection(Properties.Settings.Default.ch);
        OleDbCommand cmd = new OleDbCommand();

        public CompteController()
        {

        }

        public Boolean compteIsExist(String login,String password)
        {
            try
            {
                Cryptage cr = new Cryptage();
            
                string req = string.Format("SELECT * FROM Compte Where login='"+login+"'");
                cn.Open();
                OleDbCommand cmd = new OleDbCommand(req, cn);
                OleDbDataReader Reader = cmd.ExecuteReader();
                Boolean test = false;
            while (Reader.Read())
            {
                if (password.Equals(cr.Descrypt(Reader.GetString(1))))
                {
                    test = true;
                }
            }
                Reader.Close();
                cn.Close();
                return test;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        public Boolean uppdate(Object id, Object el)
        {
            return true;
        }
    }
}
