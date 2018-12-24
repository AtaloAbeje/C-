namespace class_task_solution
{
    class Student : Person
    {
        public string Place_of_study;
        public string Profession;

        public new string print()
        {
            return base.print() + $"Place of study: {Place_of_study}, Profession:{Profession}\n";
        }

        public Student(bool gender, string fn, int age, string id, string place_of_study, string profession)
            : base(gender, fn, age, id)
        {
            Place_of_study = place_of_study;
            Profession = profession;
        }
    }
}