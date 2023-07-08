namespace Task1
{
    internal class Student : IComparable<Student>, IComparable, IEquatable<Student>, ICloneable
    {
        public string Name { get; set; }
        public string Specialty { get; set; }
        public int Course { get; set; }

        public Student(string name, string specialty, int course)
        {
            Name = name;
            Specialty = specialty;
            Course = course;
        }

        public int CompareTo(object? obj)
        {
            Student student = obj as Student;
            if (student == null)
                return -1;
            return student.Course.CompareTo(Course);
        }

        public override string ToString() => $"Студент {Name} группы {Specialty} {Course} курса ";

        public int CompareTo(Student? other)
        {
            if (other == null)
                return -1;
            return other.Course.CompareTo(Course);
        }

        public bool Equals(Student? other)
        {
            if (other == null)
                return false;
            return other.Name.Equals(Name) && other.Specialty.Equals(Specialty) && other.Course.Equals(Course);
        }

        public object Clone()
        {
            return new Student(Name, Specialty, Course);
        }
    }
}
