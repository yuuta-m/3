using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibMas
{
    public class Class1
    {

        /*Очищение массива 
          column - количество столбцов
          kolvo - количество столбцов */
        public static void DelMas(DataGridView table)
        {
            //Очищаем ячейки таблицы
            for (int m = 0; m < table.ColumnCount; m++)
                for (int n = 0; n < table.RowCount; n++)
                    table[m, n].Value = " ";
        }
        /*Заполнение массива случайными числами
       column - количество столбцов
       Rnd - диапазон
       Выходные параметры:
       mas- заполненный массив */
        public static void InitMas(DataGridView table, int min, int max)
        {
            //table - таблица DataGridView
            //заполняем таблицу случайными значениями
            Random rnd;
            rnd = new Random();
            for (int m = 0; m < table.ColumnCount; m++)
                for (int n = 0; n < table.RowCount; n++)
                    table[m, n].Value = rnd.Next(min, max);
        }
        /*Сохранение таблицы в файл
         DataGridView table - таблица
         */
        public static void SaveFile(DataGridView table)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            save.FilterIndex = 2;
            save.Title = "Сохранение таблицы";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(save.FileName);

                file.WriteLine(table.ColumnCount);
                file.WriteLine(table.RowCount);

                for (int m = 0; m < table.ColumnCount; m++)
                    for (int n = 0; n < table.RowCount; n++)
                        file.WriteLine(table[m, n].Value);
                file.Close();
            }
        }
        /*Чтение таблицы из файла
          DataGridView table - таблица
         */
        public static void OpenFile(DataGridView table)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            open.FilterIndex = 2;
            open.Title = "Открытие таблицы";

            int columns = 0,
                rows = 0;
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);

                if (Int32.TryParse(file.ReadLine(), out columns))
                {
                    if (Int32.TryParse(file.ReadLine(), out rows))
                    {
                        table.ColumnCount = columns;
                        table.RowCount = rows;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка");
                    return;
                }

                for (int m = 0; m < columns; m++)
                {
                    for (int n = 0; n < rows; n++)
                    {
                        table[m, n].Value = file.ReadLine();
                    }
                }
            }
        }
    }
}
