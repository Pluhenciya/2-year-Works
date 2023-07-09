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

        public object this[string index]
        {
            get
            {
                switch (index)
                {
                    case "ФИО":
                        return name;
                    case "Специальность":
                        return specialty;
                    case "Курс":
                        return course;
                    default:
                        return null;
                }
            }
        }

        public char this[int index]
        {
            get
            {
                return index < name.Length && index >= 0 ? name[index] : '\0';
            }
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

        public static double GetSquare(double width)
        {
            return width > 0 ? width * width : -1;
        }

        public static double GetSquare(double width, double length)
        {
            return width > 0 ? width * length : -1;
        }

        public static double Power(int n, double x)
        {
            double power = 1;
            if (n >= 0)
            {
                for (int i = 0; i < n; i++)
                {
                    power *= x;
                }
            }
            else
            {
                return -1;
            }
            return 1 / power;
        }

        public static double Power(double x)
        {
            return 1 / x;
        }
    }
}

