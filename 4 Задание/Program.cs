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
            Console.WriteLine("++++++++");
            for(int i = 0; i < 3; i++)
            {
                Console.Write("+");
                for(int j = 0; j < 6; j++)
                {
                    Console.Write("*");
                }
                Console.Write("+");
                Console.WriteLine("");
            }
            Console.WriteLine("++++++++");
        }
    }
}
