using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bro_Hot_Food_And_Beverage
{
   public class DbCon
    {
        public MySqlConnection connectDB()
        {
            string ConnectionString = @"server=localhost;userid=root; Password=KAle@2002;Database=bro_food";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            return connection;
        }
    }
}
