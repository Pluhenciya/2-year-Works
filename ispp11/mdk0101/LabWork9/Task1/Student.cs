namespace Task1
{
    internal class Student: IPrinter
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
            Console.WriteLine($"Студент {Name} группы {Specialty} {Course} курса");
        }
    }
}
