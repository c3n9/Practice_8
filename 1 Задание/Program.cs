using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.Write("Введите n\t");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Введите k\t");
            double k = double.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double num = i;
                for (int j = 2; j <= k; j++)
                {
                    num *= i;  
                }
                s += num;
            }
            Console.WriteLine("S="+s);
        }
    }
}
