using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("высота");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("ширина");
            int w = int.Parse(Console.ReadLine());
            for (int i = 0; i <= w; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine("+");
            for(int i = 0; i < h; i++)
            {
                Console.Write("+");
                for(int j = 0; j < w; j++)
                {
                    Console.Write("*");
                }
                Console.Write("+");
                Console.WriteLine("");
            }
            for (int i = 0; i <= w; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine("+");
        }
    }
}
