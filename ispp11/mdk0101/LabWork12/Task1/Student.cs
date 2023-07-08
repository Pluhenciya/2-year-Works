namespace Task1
{
    internal struct Student
    {
        public EducationLevel Level { get; set; }

        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
            }
        }

        private string specialty;

        public string Specialty
        {
            get => specialty;
            set
            {
                if (value.Length > 0)
                {
                    specialty = value;
                }
            }
        }

        private int course;

        public int Course
        {
            get => course;
            set
            {
                if (value > 0)
                {
                    course = value;
                }
            }
        }

        public Student(string name, string specialty, int course)
        {
            this.name = name;
            this.specialty = specialty;
            this.course = course;
            Level = EducationLevel.Bachelor;
        }

        public void Print()
        {
            Console.WriteLine($"{name} {specialty} {course} {Level}");
        }
    }
}
