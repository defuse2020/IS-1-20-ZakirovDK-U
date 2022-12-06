using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_ZakirovDK_U
{
    static class Program
    {
        public class Connection1
        {
            //создаём метод MySqlConnection, который будет выполнять подключение формы к БД
            public MySqlConnection ConnBD()
            {
                string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_14;database=is_1_20_st14_KURS;password=45850148;";
                MySqlConnection conn = new MySqlConnection(connStr);
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return conn;
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection1 C1 = new Connection1();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
