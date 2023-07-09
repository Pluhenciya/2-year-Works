using Task1;

int n, userCourse;
string userSpecial;

Student student1 = new();
Student student2 = new("Космынинг Фиодосий Олегович", "", -100);
student1.Print();
student2.Print();
Console.WriteLine("Введите количество студентов");
n = Convert.ToInt32(Console.ReadLine());
Student[] students = new Student[n];
for (int i = 0; i < students.Length; i++)
{
    students[i] = new Student(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
}
for (int i = 0; i < students.Length; i++)
{
    students[i].Print();
}
Console.WriteLine("Укажите специализацию:");
userSpecial = Console.ReadLine();
Console.WriteLine("Укажите курс:");
userCourse = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < students.Length; i++)
{
    if (students[i].IsFound())
    {
        students[i].Print();
    }
}
Console.WriteLine();
for (int i = 0; i < students.Length; i++)
{
    if (students[i].IsFound(userSpecial, userCourse))
    {
        students[i].Print();
    }
}