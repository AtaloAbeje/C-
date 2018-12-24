using System;

namespace class_task_solution
{
    class Program
    {
        static void InitArray(Person[] PersonArray)
        {
            for (int i = 0; i < PersonArray.Length; i++) 
            {
                Random rnd = new Random();
                int choice = rnd.Next(0, 2);

                switch(choice)
                {
                    case 0:
                        PersonArray[i] = new Student(true, "Atalo", 20, "123456789", "Ariel", "lala");   
                        break;

                    case 1:
                        PersonArray[i] = new Teacher(false, "Alice",25, "111111111", "softwar", 550);
                        break;

                    case 2:
                        PersonArray[i] = new Worker(true, "Lala", 30, "987654321", 100);
                        break;
                }
            }
        }

        static void PrintInfo(Person[] PersonArray, Cinema BestCinema)
        {
            decimal Total_Price = 0;
            int Student_countr = 0;
            int Teacher_countr = 0;
            int Worker_countr = 0;

            foreach (Person i in PersonArray)
            {
                if(i is Student)
                {
                    Student_countr++;
                    Total_Price += (int)((BestCinema.Price) * (decimal)(1 - (BestCinema.Discount_Student / 100.0)));
                }

                else if(i is Teacher)
                {
                    Teacher_countr++;
                    Total_Price += (int)((BestCinema.Price) * (decimal)(1 - (BestCinema.Discount_Teacher / 100.0)));
                }
                else if(i is Worker)
                {
                    Worker_countr++;
                    Total_Price += BestCinema.Price;
                }
            }
            Console.WriteLine($"Total Price for is day: {Total_Price}");
            Console.WriteLine($"Price per movie: {BestCinema.Price}");
            Console.WriteLine($"Total clients: {PersonArray.Length}");
            Console.WriteLine($"Total clients students: {Student_countr}");
            Console.WriteLine($"Total clients teachers: {Teacher_countr}");
            Console.WriteLine($"Total clients Workers: {Worker_countr}");

            Console.WriteLine($"Student Discount: {BestCinema.Discount_Student}");
            Console.WriteLine($"Student Teacher: {BestCinema.Discount_Teacher}");

        }

        static void Main(string[] args)
        {
            Cinema myCinema = new Cinema();

            myCinema.Price = 25;
            myCinema.Cinemaname = "Dune";

            Person[] PersonArray = new Person[15];

            InitArray(PersonArray);
            PrintInfo(PersonArray, myCinema);
        }
    }
}