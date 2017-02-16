using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Managment_System.Controller
{
    public interface Crud
    {
        Boolean add(Object o);
        Boolean remove(Object o);
        Boolean uppdate(Object id, Object el);
    }
}
