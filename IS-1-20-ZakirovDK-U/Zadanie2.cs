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
            //создаём метод MySqlConnection, который будет выполнять подключение формы к БД
            public MySqlConnection Conn()
            {
                string connect = "server=chuc.caseum.ru;port=33333;user=uchebka;database=uschebka;password=uchebka;"; //переменная string, содержащая строку подключения к БД
                MySqlConnection conn = new MySqlConnection(connect); ; //экземпляр класса MySqlConnection, в который пишем переменную строки подключения
                return conn; //возвтрат строки подключения
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
                Conn1.Conn();
            }
            catch
            {
                //если возникнет исключение, вылетит сообщение об ошибке
                MessageBox.Show("Возникло исключение");
            }
        }
    }
}
