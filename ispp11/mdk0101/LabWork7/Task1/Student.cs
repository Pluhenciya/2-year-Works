using System.Reflection.Emit;

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

        public static Student operator ++(Student student) =>
            new Student(student.Name, student.Specialty, student.Course + 1);

        public static Student operator +(Student student1, Student student2) =>
            new Student(student1.Name, student1.Specialty, student1.Course + student2.Course);

        public static bool operator ==(Student student1, Student student2) =>
            student1.Name == student2.Name && student1.Specialty == student2.Specialty && student1.Course == student2.Course;

        public static bool operator !=(Student student1, Student student2) =>
            student1.Name != student2.Name || student1.Specialty != student2.Specialty || student1.Course != student2.Course;

        public static bool operator true (Student student) =>
            student.Course >=0;

        public static bool operator false (Student student) =>
            student.Course < 0;

        public void Print()
        {
            Console.WriteLine($"{Name} {Specialty} {Course}");
        }
    }
}
