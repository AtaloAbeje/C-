using HomeWork_24_12_18_Circle;
using System;

namespace HomeWork_24_12_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, X, Y;
            string color;

            //---------- Circle ------------

            Console.WriteLine("Enter axis X for circle:");
            X = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter axis Y for circle:");
            Y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter raduis circle:");
            num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter color circle:");
            color = Console.ReadLine();

            System.Console.Clear();

            Circle my_circle = new Circle(X, Y, num, color);
            Console.WriteLine(my_circle.Ctor());              // print all information of circle
            Console.WriteLine(my_circle.area_circle());      // print area circle
            Console.WriteLine(my_circle.scope_circel());    // print scope circel

            //---------- Square ------------
            num = 0; X = 0; Y = 0;
            color = "";

            Console.WriteLine("\nEnter axis X for square:");
            X = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter axis Y for square:");
            Y = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter rib square:");
            num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter color square:");
            color = Console.ReadLine();

            Square my_square = new Square(X, Y, num, color);

            Console.WriteLine(my_square.Ctor());            // print all information of circle
            Console.WriteLine(my_square.area_square());    // print area square
            Console.WriteLine(my_square.scope_square());  // print scope square

        }
    }
}
