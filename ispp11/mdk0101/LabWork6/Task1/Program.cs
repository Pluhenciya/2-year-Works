using System;
using Task1;

int n = 3;
double width = 4, length = 5, x = 2;

Student student = new();
Console.WriteLine(student["ФИО"]);
Console.WriteLine(student[1]);
Console.WriteLine(Student.GetSquare(width));
Console.WriteLine(Student.GetSquare(width, length));
Console.WriteLine(Math.Round(Student.Power(n, x),4));
Console.WriteLine(Math.Round(Student.Power(x),4));