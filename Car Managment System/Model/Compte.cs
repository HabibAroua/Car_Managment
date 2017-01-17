using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Managment_System.Model
{
    public class Compte
    {
        public String login
        {
            get;
            set;
        }
        public String password
        {
            get;
            set;
        }

        public Compte()
        {

        }
        public Compte(String login,String password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
