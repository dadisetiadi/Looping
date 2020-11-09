using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int month;
            month = 3;
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("Error: Invalid Month");
                    break;
            }
            Console.Read();
            */


            int a;
            a = 1;
            switch (a + 1)
            {
               
                    case 1:
                    Console.WriteLine("nilai a adalah nol");
                    break;

                    case 2:
                    Console.WriteLine("nilai a adalah satu");
                    break;
                    case 3:
                    Console.WriteLine("nilai a adalah dua");
                    break;

                    default:
                    a = -1;
                    Console.WriteLine("nilai a adalah min satu");
                    break;
            }
            Console.Read();

        }
    }
}
