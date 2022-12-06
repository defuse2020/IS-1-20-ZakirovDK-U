using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_1_20_ZakirovDK_U
{
    public class connDB
    {
        public static MySqlConnection ConnDB()
        {
            string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_14;database=is_1_20_st14_KURS;password=45850148;";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;
        }
    }
}
