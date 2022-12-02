using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3_111
{
    class Program
    {
        static int f(string num)
        {
            int min = 9;
            //string a = num.ToString();

            for (int i=0; i<num.Length; i++)
            {
                if (num[i] != '-')
                {
                    string c = num[i].ToString();
                    int n = Convert.ToInt32(c);
                    if (n < min) { min = n; }
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число a: ");
                string a = Console.ReadLine();
                Console.Write("Введите число b: ");
                string b = Console.ReadLine();
                int z = f(a) + f(b);
                Console.Write("z = " + z.ToString());
            }
            catch { Console.WriteLine("Некорректный ввод данных"); }
            Console.ReadKey();
        }
    }
}
