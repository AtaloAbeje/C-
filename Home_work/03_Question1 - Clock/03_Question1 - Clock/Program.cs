using System;
namespace _03_Question1___Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            // answar 1.5.1 + get info from user
            Clock MyClock = new Clock();
            do
            {                                        // Hours between 0 and 12;
                Console.WriteLine("Please Current Enter Hour:");
                MyClock.Hours = Convert.ToInt32(Console.ReadLine());
            } while (MyClock.Hours < 0 || MyClock.Hours > 13);

            do
            {                                        // Minutes between 0 and 60;
                Console.WriteLine("Please Current Enter Minutes:");
            MyClock.Minutes = Convert.ToInt32(Console.ReadLine());
            } while (MyClock.Minutes < 0 || MyClock.Minutes > 60);

            do
            {                                        // Seconds between 0 and 12;
                Console.WriteLine("Please Current Enter Seconds:");
                MyClock.Seconds = Convert.ToInt32(Console.ReadLine());
            } while (MyClock.Seconds < 0 || MyClock.Seconds > 60);

            do
            {                                        // Milli Secondes between 0 and 1000;
                Console.WriteLine("Please Current Enter Milliseconds:");
                MyClock.Milliseconds = Convert.ToInt32(Console.ReadLine());
            } while (MyClock.Milliseconds < 0 || MyClock.Milliseconds > 1000);

            Console.Clear(); // answar 1.5.2

            Console.WriteLine(MyClock.show()); // print My Clock

            Console.WriteLine(); // answar 1.5.3 + 4 
            MyClock.Milliseconds += 2;
            Console.WriteLine($"{MyClock.show()} ->> My Clock after + 2 Milliseconds");

            Console.WriteLine(); // answar 1.5.5
            MyClock.setMidDay();
            Console.WriteLine($"{MyClock.show()} ->> My Clock at Mid Day");

            Console.WriteLine(); // answar 1.5.6 + 7
            MyClock.Milliseconds += 3;
            Console.WriteLine(MyClock.show());

            Clock YourClock = new Clock(); // answar 1.5.8

            Console.WriteLine(); // answar 1.5.9 + 10
            YourClock.setMidNight();
            Console.WriteLine($"{YourClock.show()} ->> Mid Night");

            /// Task.03.Question.1 -->> Atalo
        }
    }
}
