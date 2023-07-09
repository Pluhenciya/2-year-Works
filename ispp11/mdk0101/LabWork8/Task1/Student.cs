namespace Task1
{
    internal class Student
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

        public void Print()
        {
            Console.WriteLine($"{Name} {Specialty} {Course}");
        }

        public override string ToString()
        {
            return $"{Name} {Specialty} {Course}";
        }

        public override bool Equals(object? obj)
        {
            Student student = obj as Student;
            return Name == student.Name && 
                Specialty == student.Specialty &&
                Course == student.Course;
        }
    }
}
