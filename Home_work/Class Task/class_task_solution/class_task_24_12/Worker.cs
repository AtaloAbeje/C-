namespace class_task_solution
{
    class Worker : Person
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public new string print()
        {
            return base.print() + $"Salary: {Salary}";
        }

        public Worker(bool gender, string fn, int age, string id, int salary) : base(gender, fn, age, id)
        {
            Salary = salary;
        }
    }
}