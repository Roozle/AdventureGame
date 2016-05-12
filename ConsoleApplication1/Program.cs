using ClassLibrary1;
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
            
            var sums = new Sums();
            Console.WriteLine("Hello, This console application will do some math, probably");
            //play(sums);
            play2();

        }

        private static void play2()
        {
            double a, b;
            a = 99;
            b = 98;
            for (var i = 0; i < 99; i++) 
            {
                if (b != 0)
                {
                    Console.WriteLine("{0} bottles of beer on the wall, {0} bottles of beer, take one down, pass it around, {1} bottles of beer on the wall", a, b);
                }
                else
                {
                    Console.WriteLine("{0} bottles of beer on the wall, {0} bottles of beer, take one down and pass it around, no more bottles of beer on the wall.", a);
                    Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, 99 bottles of beer on the wall.");
                }
                a = a - 1;
                b = b - 1;

            }
            Console.ReadLine();
            play2();
        }
        
        private static void play(Sums sums)
        {
            Console.WriteLine("Please enter a number");
            double a, b;
            if (double.TryParse(Console.ReadLine(), out a))        
            {
                b = a;
                a = sums.add(a, 4);
                a = sums.multiply(a, 4);
                a = sums.subtract(a, 8);
                a = sums.divide(a, 4);
                a = a-b;
                Console.WriteLine("{0}", a);
                Console.WriteLine("Press Return to restart");
                Console.ReadLine();
                play(sums);

            }
            else
            {
                Console.WriteLine("Try Again");
                play(sums);
            }
        }
    }
}
