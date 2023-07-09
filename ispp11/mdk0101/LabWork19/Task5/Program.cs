namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student model = RetriveStudentFromDatabase();
            StudentView view = new StudentView();
            StudentController controller = new StudentController(model, view);
            controller.UpdateView();
            Console.WriteLine();
            controller.Model.Name="John";
            controller.UpdateView();
        }

        private static Student RetriveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Robert";
            student.RollNo = "10";
            return student;
        }
    }
}