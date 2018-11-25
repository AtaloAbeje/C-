using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            int newspeed;
           
            car1.Speed_up = 20;
            printcar(car1); //print info car

            Console.WriteLine("Do you want to speed up your car?\nPlease enter the speed: ");
            newspeed = Convert.ToInt32(Console.ReadLine());
            car1.Speed_up += newspeed; //add new speed

            Console.WriteLine("ur speed car now:");
            printcar(car1); //print new speed

            car1.Speed_up -= 2;
            Console.WriteLine("speed car now (after -2 KM):");
            printcar(car1); //print new speed

            car1.Speed_up = 0;
            Console.WriteLine("stop the car!");
            printcar(car1); //print new speed
        }
        ///Task.03 Question 2 - Atalo Abeje
        static void printcar(Car mycar)
        {
            Console.WriteLine($"speed car: {mycar.Speed_up}");
        }
    }
}
