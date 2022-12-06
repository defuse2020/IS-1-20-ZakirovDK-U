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
using static IS_1_20_ZakirovDK_U.Program;

namespace IS_1_20_ZakirovDK_U
{
    public partial class Zadanie3 : Form
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
        public Zadanie3()
        {
            InitializeComponent();
        }
        public void GLU()
        {
            conn.Open();
            string commandStr = "SELECT items.id_item, items.title_product, items.provider, items.title_maker, items.title_client, items.dt_delivery, items.dt_shipment, items.employee, items.count " +
                "FROM items JOIN type ON type.id_type = items.title_product JOIN provider ON provider.id_provider = items.provider JOIN maker ON maker.id_maker = items.title_maker " +
                "JOIN client ON client.id_client = items.title_client JOIN employees ON employees.id_employee = items.employee";
            MySqlCommand command = new MySqlCommand(commandStr, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = reader[0].ToString();
                dataGridView1.Rows[row].Cells[1].Value = reader[1].ToString();
                dataGridView1.Rows[row].Cells[2].Value = reader[2].ToString();
                dataGridView1.Rows[row].Cells[3].Value = reader[3].ToString();
                dataGridView1.Rows[row].Cells[4].Value = reader[4].ToString();
            }
            reader.Close();
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GLU();
            dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
        }

        private void Zadanie3_Load(object sender, EventArgs e)
        {
            conn = Connection.OpenConn();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            int rowIdx = e.RowIndex;
            string commStr = "SELECT items.title_product, items.provider, items.title_maker, items.title_client, items.dt_delivery, items.dt_shipment, items.employee, items.count " +
            "FROM items JOIN type ON type.id_type = items.title_product JOIN provider ON provider.id_provider = items.provider JOIN maker ON maker.id_maker = items.title_maker " +
            "JOIN client ON client.id_client = items.title_client JOIN employees ON employees.id_employee = items.employee";

            MySqlCommand command = new MySqlCommand(commStr, conn);

            MySqlDataReader reader = command.ExecuteReader();

            string info = "";

            while (reader.Read())
            {
                info += $"Название продукта: {reader[0].ToString()}\n";
                info += $"Тип продукта: {reader[1].ToString()}\n";
                info += $"Поставщик: {reader[2].ToString()}\n";
                info += $"Производитель: {reader[3].ToString()}\n";
                info += $"Клиент: {reader[4].ToString()}\n";
                info += $"Дата поставки: {reader[5].ToString()}\n";
                info += $"Дата отгрузки: {reader[6].ToString()}\n";
                info += $"Количество: {reader[7].ToString()}\n";
            }
            reader.Close();
            MessageBox.Show(info);
            conn.Close();
        }
    }
}
