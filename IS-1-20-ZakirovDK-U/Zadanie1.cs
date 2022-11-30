using System;
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
    public partial class Zadanie1 : Form
    {
        class Complect
        {
            int price;
            int sience;
            public Complect(int price,int sience)
            {
                this.price = price;
                this.sience = sience;
            }
            public void Display()
            {

            }
        }
        public Zadanie1()
        {
            InitializeComponent();
        }
    }
}
