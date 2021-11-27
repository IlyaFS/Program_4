using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число больше 0 = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 0;

            for (int i = 2 * N - 1; i >0; i-=2)
            {
                a += i;                
            }
            Console.WriteLine("Квадрат числа {0} равен {1}", N, a);

            Console.WriteLine("Нажмите на любого клавиша");
            Console.ReadKey();
        }
    }
}
