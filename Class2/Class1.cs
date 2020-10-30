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
        public static void MaxMas(DataGridView table, TextBox textBox1)
        {
            int columns = table.ColumnCount;
            int rows = table.RowCount;
            int min = Convert.ToInt32(table[0, 0].Value);
            //Поиск минимального числа и номера его строки
            for (int n = 0; n < rows; n++)
            {
                for (int m = 0; m < columns; m++)
                {
                    if (Convert.ToInt32(table[m, n].Value) < min)
                    {
                        min = Convert.ToInt32(table[m, n].Value);
                    }
                }
                textBox1.Text = textBox1.Text + " " + min.ToString();
                min= Convert.ToInt32(table[0, 0].Value);
            }
        }
    }
}
