using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace perulangan
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int count;
            for (count = 1; count <= 10; count+=1)
            {
                Console.WriteLine(count+" hasilnya adalah " + count*count );
            }
            Console.Read();
         */


        /*
         
        static void Main(string[] args)
        {
            int count;
            for (count = 10; count <= 200; count++)
            {
                Console.WriteLine( count + " mph = "  + count*1.609  + " kph" );
            }
            Console.Read();
         */


        static void Main(string[] args)
        {
            int count, a, hasil;
            hasil = 1;
            Console.Write("Masukan angka : ");
            a = int.Parse(Console.ReadLine());

            for (count = 1; count <= a; count++)
            {
                hasil = hasil * count;
                
                Console.WriteLine(a + "! =" + hasil);
            }
            Console.Read();

        }
    }
}
