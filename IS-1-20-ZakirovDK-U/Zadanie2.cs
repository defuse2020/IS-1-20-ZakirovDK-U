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
        public class Connection
        {
            public MySqlConnection Conn()
            {
                string connect = "server=chuc.caseum.ru;port=33333;user=uchebka;database=uschebka;password=uchebka;";
                MySqlConnection conn;
                conn = new MySqlConnection(connect);
                return conn;
            }
        }
        public Zadanie2()
        {
            InitializeComponent();
        }

        private void Zadanie2_Load(object sender, EventArgs e)
        {
            Connection Conn1 = new Connection();
            try
            {
                Conn1.Conn();
            }
            catch
            {
                MessageBox.Show("Возникло исключение");
            }
        }
    }
}
