using System;

namespace class_task_solution
{
    class Cinema
    {
        private string cinemaname;

        public string Cinemaname
        {
            get { return cinemaname; }
            set { cinemaname = value; }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 30 && value <= 200)
                {
                    price = value;
                }
            }
        }
        public readonly int Discount_Student;
        public readonly int Discount_Teacher;

        public Cinema(string cinemaname, decimal price)
        {
            Cinemaname = cinemaname;
            Price = price;

            Random rnd1 = new Random();
            Discount_Student = rnd1.Next(10, 21);

            Random rnd2 = new Random();
            Discount_Teacher = rnd2.Next(5, 11);
        }
        public Cinema() { }
    }
}
