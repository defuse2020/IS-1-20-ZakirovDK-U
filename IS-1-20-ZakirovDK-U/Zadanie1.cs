using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace IS_1_20_ZakirovDK_U
{
    public partial class Zadanie1 : Form
    {
        public abstract class Complect<T>
        {
            public int price;
            public int sience;
            public T artic;
            public Complect(int price,int sience, T artic)
            {
                this.price = price;
                this.sience = sience;
                this.artic = artic;
            }
            public virtual void Display()
            {
                MessageBox.Show($"Цена:{price}, Дата выпуска:{sience}, Артикул:{artic}");
            }
        }
        public class HardDrive<T> : Complect<T>
        {
            public int numrevol { get; set; }
            public int interfacee { get; set; }
            public int size { get; set; }
            public HardDrive(int price, int sience, T artic, int numrevol, int interfacee, int size) : base(price, sience, artic)
            {
                this.numrevol = numrevol;
                this.interfacee = interfacee;
                this.size = size;
            }
            public override void Display()
            {
                MessageBox.Show($"Цена:{price}, Дата выпуска:{sience}, Артикул:{artic}, Количество оборотов:{numrevol}, Интерфейс:{interfacee}, Объём памяти:{size}");
            }
        }
        public class GPU<T> : Complect<T>
        {
            public int freq { get; set; }
            public string maker { get; set; }
            public int memory { get; set; }
            public GPU(int price,int siense, T artic, int freq, string maker, int memory):base(price,siense,artic)
            {
                this.freq = freq;
                this.maker = maker;
                this.memory = memory;
            }
            public override void Display()
            {
                MessageBox.Show($"Цена:{price}, Дата выпуска:{sience}, Артикул:{artic}, Частота GPU:{freq}, Производитель:{maker}, Объём памяти:{memory}");
            }
        }
        public Zadanie1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            HardDrive<int> H1 = new HardDrive<int>(Convert.ToInt32(metroTextBox1.Text), Convert.ToInt32(metroTextBox2.Text), 
                Convert.ToInt32(metroTextBox3.Text),Convert.ToInt32(metroTextBox4.Text), Convert.ToInt32(metroTextBox5.Text), Convert.ToInt32(metroTextBox6.Text));
            listBox1.Items.Add($"Цена:{metroTextBox1.Text}");
            listBox1.Items.Add($"Дата выпуска:{metroTextBox2.Text}");
            listBox1.Items.Add($"Артикул:{metroTextBox3.Text}");
            listBox1.Items.Add($"Частота оборотов:{metroTextBox4.Text}");
            listBox1.Items.Add($"Интерфейс::{metroTextBox5.Text}");
            listBox1.Items.Add($"Объём памяти:{metroTextBox6.Text}");
            H1.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GPU<int> GPU1 = new GPU<int>(Convert.ToInt32(metroTextBox1.Text), Convert.ToInt32(metroTextBox2.Text),
                Convert.ToInt32(metroTextBox3.Text), Convert.ToInt32(metroTextBox7.Text), metroTextBox8.Text, Convert.ToInt32(metroTextBox9.Text));
            listBox1.Items.Add($"Цена:{metroTextBox1.Text}");
            listBox1.Items.Add($"Дата выпуска:{metroTextBox2.Text}");
            listBox1.Items.Add($"Артикул:{metroTextBox3.Text}");
            listBox1.Items.Add($"Частота GPU:{metroTextBox7.Text}");
            listBox1.Items.Add($"Производитель::{metroTextBox8.Text}");
            listBox1.Items.Add($"Объём памяти:{metroTextBox9.Text}");
            GPU1.Display();
        }
    }
}
