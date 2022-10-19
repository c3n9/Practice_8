using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту треугольника\t");
            int h = int.Parse(Console.ReadLine());
            for(int i = 1; i <= h; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
