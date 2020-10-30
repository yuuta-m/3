using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lib_7
{
    public class Class2
    {
        /*Параметры:
        Входные:
        DataGridView table - таблица
        TextBox textBox - форма для вывода ответа
        Выходные:
        min - минимальное значение в строке
        */
        public static void MinMas(DataGridView table, TextBox textBox)
        {
            //Поиск минимального числа  
            for (int n = 0; n < table.ColumnCount; n++)
            {
                if (n == table.ColumnCount)
                {
                    break;
                }

                int min = Convert.ToInt32(table[0, n].Value);
                for (int m = 0; m < table.RowCount; m++)
                {
                    if (Convert.ToInt32(table[m, n].Value) < min)
                    {
                        min = Convert.ToInt32(table[m, n].Value);
                    }
                }
                textBox.Text = textBox.Text + " " + min.ToString();
            }
        }
    }
}
