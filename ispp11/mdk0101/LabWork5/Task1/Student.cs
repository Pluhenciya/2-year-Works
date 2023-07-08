namespace Task1
{
    internal class Student
    {
        private string GivenSpecialty = "ИСПП";
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


        public Student() : this("Понаморёв Артём Витальевич", "ОИБ", 2)
        {

        }

        public Student(string name, string specialty, int course)
        {
            this.Name = name;
            this.Specialty = specialty;
            this.Course = course;
        }



        public void Print()
        {
            Console.WriteLine($"{Name} {Specialty} {Course}");
        }

        public bool IsFound()
        {
            return specialty == GivenSpecialty;
        }

        public bool IsFound(string userSpecial, int userCourse)
        {
            return specialty == userSpecial && course == userCourse; 
        }
    }
}

