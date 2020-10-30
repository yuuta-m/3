using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMas;
using Lib_7;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Начальные значения таблицы при первом запуске
        private void Form1_Load(object sender, EventArgs e)
        {
            table.ColumnCount = 5;//Кол-во столбцов таблицы
            table.RowCount = 4;//Кол-во строк таблицы
        }

        //Кнопка "Рассчитать"
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Class2.MinMas(table, textBox1);
        }

        //Кнопка "Заполнить"
        private void button5_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(diapazonMinus.Value);
            int max = Convert.ToInt32(diapazonPlus.Value);
            Class1.InitMas(table, min, max);
        }

        //Кнопка "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка "Очистить"
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.DelMas(table);
            textBox1.Clear();
        }

        //Кнопка "Сохранить"
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.SaveFile(table);
        }

        //Кнопка "Открыть"
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.OpenFile(table);
        }

        //Кнопка "О программе"
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №3. Бороненкова Дария, гр.ИСП - 31.\n" +
                "Задание: Дана матрица размера M × N. \n" +
                "В каждой строке матрицы найти минимальный элемент.", "О программе");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class2.MinMas(table, textBox1);
        }
    }
}
