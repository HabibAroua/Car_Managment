using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Managment_System.Controller
{
    public class PLSQL
    {
        public PLSQL()
        {

        }

        public String PLSQL_Procedure(String p)
        {
            return "Begin "+p+" ; end ;";
        }
    }
}
