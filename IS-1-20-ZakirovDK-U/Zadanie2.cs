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
        //создаём класс
        public class Connection
        {
            public MySqlConnection OpenConn()
            {
                //"server=chuc.caseum.ru;port=33333;user=st_1_20_14;database=is_1_20_st14_KURS;password=45850148;"
                //"server=chuc.caseum.ru;port=33333;user=uchebka;database=uschebka;password=uchebka;"
                string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_14;database=is_1_20_st14_KURS;password=45850148;";  
                MySqlConnection conn = new MySqlConnection(connStr);
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                return conn;
            }
        }
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void Zadanie2_Load(object sender, EventArgs e)
        {
            //создаём экземпляр класса Connection
            Connection Conn1 = new Connection();
            //прогоняем выполнение метода через конструкцию try..catch
            try
            {
                //выполнение метода
                Conn1.OpenConn();
            }
            catch(Exception ex)
            {
                //если возникнет исключение, вылетит сообщение об ошибке
                MessageBox.Show(ex.Message);
            }
        }
    }
}
