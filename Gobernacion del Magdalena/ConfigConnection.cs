using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobernacion_del_Magdalena
{
    public static class ConfigConnection
    {
        public static string connectionString =
       ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
