namespace class_task_solution
{
    class Person
    {
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 120)
                {
                    age = value;
                }
            }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set
            {
                int num;
                if (value.Length == 9 && int.TryParse(value, out num))
                {
                    id = value;
                }
            }
        }

        public bool Gender { get; set; }

        public string print()
        {
            return $"FullName: {FullName}, Age: {Age}, Id: {Id}, Gender: {Gender}";
        }

        public Person(bool gender, string fn, int age, string id)
        {
            FullName = fn;
            Age = age;
            Id = id;
            Gender = gender;
        }
    }
}

