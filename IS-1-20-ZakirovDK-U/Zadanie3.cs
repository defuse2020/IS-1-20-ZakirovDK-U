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
        Connection1 Conn1;
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet ds = new DataSet();
        private DataTable table = new DataTable();
        string id_selected_rows = "0";
        public Zadanie3()
        {
            InitializeComponent();
        }

        public void GLU()
        {
            string commandStr = "SELECT items.id_item, items.title_product, items.provider, items.title_maker, items.title_client, items.dt_delivery, items.dt_shipment, items.employee, items.count " +
                "FROM items JOIN type ON type.id_type = items.title_product JOIN provider ON provider.id_provider = items.provider JOIN maker ON maker.id_maker = items.title_maker " +
                "JOIN client ON client.id_client = items.title_client JOIN employees ON employees.id_employee = items.employee";
            Conn1.Open1();
            MyDA.SelectCommand = new MySqlCommand(commandStr, Conn1.ConnBD());
            try
            {
                MyDA.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            Conn1.Close1();
            int count_rows = dataGridView1.RowCount - 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GLU();
               //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               //dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns.Add("items.id_item", "ID предмета");
            dataGridView1.Columns.Add("items.title_product", "Название");
            dataGridView1.Columns.Add("type_product", "Тип");
            dataGridView1.Columns.Add("items.provider", "Поставщик");
            dataGridView1.Columns.Add("items.title_maker", "Производитель");
            dataGridView1.Columns.Add("items.title_client", "Клиент");
            dataGridView1.Columns.Add("items.dt_delivery", "Дата поставки");
            dataGridView1.Columns.Add("items.dt_shipment", "Дата выгрузки");
            dataGridView1.Columns.Add("items.employee", "Сотрудник");
            dataGridView1.Columns.Add("items.count", "Количество");
            //Убираем заголовки строк
            dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
        }

        private void Zadanie3_Load(object sender, EventArgs e)
        {
            Conn1 = new Connection1();
            Conn1.ConnBD();
        }
    }
}
