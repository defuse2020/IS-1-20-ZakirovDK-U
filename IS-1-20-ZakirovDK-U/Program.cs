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
            public MySqlConnection Conn()
            {
                string connect = "server=chuc.caseum.ru;port=33333;user=uchebka;database=uschebka;password=uchebka;"; //переменная string, содержащая строку подключения к БД
                MySqlConnection conn = new MySqlConnection(connect); ; //экземпляр класса MySqlConnection, в который пишем переменную строки подключения
                return conn; //возвтрат строки подключения
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
