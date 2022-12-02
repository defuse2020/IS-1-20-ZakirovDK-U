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
        public abstract class Complect<T> //создаём абстрактный класс "Комплектующие", который использует обобщённый тип данных
        {
            //создаём поля класса
            public int price;
            public int sience;
            //создаём обобщённый тип данных с артикулом
            public T artic;
            public Complect(int price,int sience, T artic) //создаём конструктор, принимающий и инициализирующий поля класса
            {
                this.price = price;
                this.sience = sience;
                this.artic = artic;
            }
            //Создаём виртуальный метод вывода полей класса в MessageBox. Виртуальным делаем для переопределения
            public virtual void Display()
            {
                MessageBox.Show($"Цена:{price}, Дата выпуска:{sience}, Артикул:{artic}");
            }
        }
        //создаём наследуемый класс "Жёсткий диск", который использует обобщённый тип данных
        public class HardDrive<T> : Complect<T>
        {
            //создаём поля класса, закрытые свойствами
            public int numrevol { get; set; }
            public int interfacee { get; set; }
            public int size { get; set; }
            //инициализируем свойства через конструктор
            public HardDrive(int price, int sience, T artic, int numrevol, int interfacee, int size) : base(price, sience, artic)
            {
                this.numrevol = numrevol;
                this.interfacee = interfacee;
                this.size = size;
            }
            //создаём переопределённый метод Display для вывода инфы по жёсткому диску через MessageBox
            public override void Display()
            {
                MessageBox.Show($"Цена:{price}, Дата выпуска:{sience}, Артикул:{artic}, Количество оборотов:{numrevol}, Интерфейс:{interfacee}, Объём памяти:{size}");
            }
        }
        //создаём наследуемый класс "Видеокарта", который использует обобщённый тип данных
        public class GPU<T> : Complect<T>
        {
            //создаём поля класса, закрытые свойствами
            public int freq { get; set; }
            public string maker { get; set; }
            public int memory { get; set; }
            //инициализируем свойства через конструктор
            public GPU(int price,int siense, T artic, int freq, string maker, int memory):base(price,siense,artic)
            {
                this.freq = freq;
                this.maker = maker;
                this.memory = memory;
            }
            //создаём переопределённый метод Display для вывода инфы по жёсткому диску через MessageBox
            public override void Display()
            {
                MessageBox.Show($"Цена:{price}, Дата выпуска:{sience}, Артикул:{artic}, Частота GPU:{freq}, Производитель:{maker}, Объём памяти:{memory}");
            }
        }

        public Zadanie1()
        {
            InitializeComponent();
        }

        //button1 выполняет вывод инфы по жёсткому диску
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //очищаем listBox
            //создаём экземпляр класса жёсткого диска, в который засовываем необходимые textBox-ы
            HardDrive<int> H1 = new HardDrive<int>(Convert.ToInt32(metroTextBox1.Text), Convert.ToInt32(metroTextBox2.Text), 
                Convert.ToInt32(metroTextBox3.Text),Convert.ToInt32(metroTextBox4.Text), Convert.ToInt32(metroTextBox5.Text), Convert.ToInt32(metroTextBox6.Text));
            //Добавляем в listBox textBox-ы для вывода нужной инфы
            listBox1.Items.Add($"Цена:{metroTextBox1.Text}");
            listBox1.Items.Add($"Дата выпуска:{metroTextBox2.Text}");
            listBox1.Items.Add($"Артикул:{metroTextBox3.Text}");
            listBox1.Items.Add($"Частота оборотов:{metroTextBox4.Text}");
            listBox1.Items.Add($"Интерфейс::{metroTextBox5.Text}");
            listBox1.Items.Add($"Объём памяти:{metroTextBox6.Text}");
            H1.Display(); //вызываем метод вывода инфы через MessageBox
        }

        //button2 выполняет вывод инфы по видеокарте
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //очищаем listBox
            //создаём экземпляр класса видеокарты, в который засовываем необходимые textBox-ы
            GPU<int> GPU1 = new GPU<int>(Convert.ToInt32(metroTextBox1.Text), Convert.ToInt32(metroTextBox2.Text),
                Convert.ToInt32(metroTextBox3.Text), Convert.ToInt32(metroTextBox7.Text), metroTextBox8.Text, Convert.ToInt32(metroTextBox9.Text));
            //Добавляем в listBox textBox-ы для вывода нужной инфы
            listBox1.Items.Add($"Цена:{metroTextBox1.Text}");
            listBox1.Items.Add($"Дата выпуска:{metroTextBox2.Text}");
            listBox1.Items.Add($"Артикул:{metroTextBox3.Text}");
            listBox1.Items.Add($"Частота GPU:{metroTextBox7.Text}");
            listBox1.Items.Add($"Производитель::{metroTextBox8.Text}");
            listBox1.Items.Add($"Объём памяти:{metroTextBox9.Text}");
            GPU1.Display(); //вызываем метод вывода инфы через MessageBox
        }
    }
}
