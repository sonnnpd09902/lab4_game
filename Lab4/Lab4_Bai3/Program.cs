using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Tạo danh sách student
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Age = 10 },
            new Student { Name = "Bob", Age = 15 },
            new Student { Name = "Charlie", Age = 18 },
            new Student { Name = "David", Age = 21 },
            new Student { Name = "Eve", Age = 16 }
        };

        //  Xuất ra màn hình các student có Age > 12 và Age < 20 bằng cách dùng LINQ Query Syntax
        var querySyntaxStudents = from student in students
                                  where student.Age > 12 && student.Age < 20
                                  select student;

        Console.WriteLine("Students with Age > 12 and Age < 20 (Query Syntax):");
        foreach (var student in querySyntaxStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        //  Xuất ra màn hình các student có Age > 12 và Age < 20 bằng cách dùng LINQ Method Syntax
        var methodSyntaxStudents = students.Where(student => student.Age > 12 && student.Age < 20);

        Console.WriteLine("\nStudents with Age > 12 and Age < 20 (Method Syntax):");
        foreach (var student in methodSyntaxStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }
        Console.ReadLine();
    }
}
