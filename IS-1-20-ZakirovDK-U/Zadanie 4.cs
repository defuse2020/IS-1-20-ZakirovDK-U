using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IS_1_20_ZakirovDK_U.connDB;

namespace IS_1_20_ZakirovDK_U
{
    public partial class Zadanie_4 : Form
    {
        MySqlConnection conn;
        public Zadanie_4()
        {
            InitializeComponent();
        }

        private void Zadanie_4_Load(object sender, EventArgs e)
        {
            conn = connDB.ConnDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string commandStr = "SELECT * FROM t_datatime";
            MySqlCommand command = new MySqlCommand(commandStr, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = reader[0].ToString();
                dataGridView1.Rows[row].Cells[1].Value = reader[1].ToString();
                dataGridView1.Rows[row].Cells[2].Value = reader[2].ToString();
                dataGridView1.Rows[row].Cells[3].Value = reader[3].ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string id = dataGridView1.Rows[row].Cells[0].Value.ToString();
            conn.Open();
            string commStr = $"SELECT photoUrl FROM t_datatime WHERE id = {id}";
            MySqlCommand comm = new MySqlCommand(commStr, conn);
            string url = comm.ExecuteScalar().ToString();
            pictureBox1.ImageLocation = url;
            conn.Close();
        }
    }
}
