﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_ZakirovDK_U
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadanie1 Z1 = new Zadanie1();
            Z1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zadanie2 Z2 = new Zadanie2();
            Z2.ShowDialog();
        }
    }
}
