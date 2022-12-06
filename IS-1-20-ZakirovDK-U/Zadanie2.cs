using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_ZakirovDK_U
{
    public partial class Zadanie2 : Form
    {
        MySqlConnection conn;
        //создаём класс
        public class Connection
        {
            public static MySqlConnection OpenConn()
            {
                //"server=chuc.caseum.ru;port=33333;user=st_1_20_14;database=is_1_20_st14_KURS;password=45850148;"
                //"server=chuc.caseum.ru;port=33333;user=uchebka;database=uschebka;password=uchebka;"
                string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_14;database=is_1_20_st14_KURS;password=45850148;";  
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
        }
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void Zadanie2_Load(object sender, EventArgs e)
        {
            conn = Connection.OpenConn();
            //прогоняем выполнение метода через конструкцию try..catch
            try
            {
                //выполнение метода
                conn.Open();
            }
            catch(Exception ex)
            {
                //если возникнет исключение, вылетит сообщение об ошибке
                MessageBox.Show(ex.Message);
            }
        }
    }
}
