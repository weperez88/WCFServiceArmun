using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace armun.general.SQLRepositorio
{
    public class ConexionRepositorio
    {
        public static string getStringConnection()
        {
            string string_connection = ConfigurationManager.ConnectionStrings["HouseDB"].ToString();
            return string_connection;
        }
    }
}
