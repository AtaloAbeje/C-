namespace class_task_solution
{
    class Teacher : Person
    {
        public string Teaching_profession;  
        public int Seniority;
      
        public new string print()
        {
            return base.print() + $"Teaching profession:, {Teaching_profession}, Seniority: {Seniority}\n";
        }

        public Teacher(bool gender, string fn, int age, string id, string teaching_profession, int seniority)
            : base(gender, fn, age, id)
        {
            Teaching_profession = teaching_profession;
            Seniority = seniority;
        }
    }
}
