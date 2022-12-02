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
        public Zadanie3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection1 Conn1 = new Connection1();
            Conn1.Conn();
        }
    }
}
