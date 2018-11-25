using System;
namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            cookie cookie1 = new cookie();
            cookie cookie2 = new cookie();
            cookie cookie3 = new cookie();

            //fill cookie 1
            Console.WriteLine("Do you want gloten? Please enter ur choice:\nPress 1-> YES or 0-> NO:");
            cookie1.Gloten = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter eggs for cookie 1:");
            cookie1.Eggs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter grams sugar for cookie 1:");
            cookie1.Sugar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter grams flour for cookie 1:");
            cookie1.Flour = Convert.ToDouble(Console.ReadLine());

            //fill cookie 2
            Console.WriteLine("Do you want gloten? Please enter ur choice:\nPress 1-> YES or 0-> NO:");
            cookie1.Gloten = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter eggs for cookie 2:");
            cookie2.Eggs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter grams sugar for cookie 2:");
            cookie2.Sugar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter grams flour for cookie 2:");
            cookie2.Flour = Convert.ToDouble(Console.ReadLine());

            printfun(cookie1);
            printfun(cookie2);

            Console.WriteLine("Please enter new garm Sugar for cookie 1:");
            cookie1.Sugar = Convert.ToDouble(Console.ReadLine());
            printfun(cookie1); // print agan all the cookies
            printfun(cookie2);

            cookie2 = cookie1;
        
            Console.WriteLine("Please enter new Eggs for cookie 2:");
            cookie2.Sugar = Convert.ToDouble(Console.ReadLine());

            printfun(cookie1); // print agan all the cookies
            printfun(cookie2);
        }
        ///Task.03 Question 1 - Atalo Abeje
        static void printfun(cookie cookies) //function for print cookies
        {
            Console.WriteLine($"eggs: {cookies.Eggs}, sugar: {cookies.Sugar} gram, flour: {cookies.Flour} gram");

            if (cookies.Gloten == 0)
                Console.WriteLine("This cookie without gloten :) !!\n");

            else if (cookies.Gloten != 0) // for another numbers
                Console.WriteLine("This cookie with gloten! :( !!\n");
        }

    }
}
