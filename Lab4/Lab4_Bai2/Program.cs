using System;
using System.Collections.Generic;
using System.Linq;

public class UserData
{
    public string Name { get; set; }
    public int Level { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<UserData> userData = new List<UserData>
        {
            new UserData { Name = "Alice", Level = 5 },
            new UserData { Name = "Bob", Level = 2 },
            new UserData { Name = "Charlie", Level = 4 },
            new UserData { Name = "David", Level = 1 },
            new UserData { Name = "Eve", Level = 3 }
        };

        var selectedData = userData.Select(user => new { user.Name, user.Level });
        Console.WriteLine("Name and Level of users:");

        foreach (var user in selectedData)
        {
            Console.WriteLine($"Name: {user.Name}, Level: {user.Level}");
        }

        var sortedData = userData.OrderByDescending(user => user.Level).ToList();
        Console.WriteLine("\nUsers sorted by Level (descending):");
        foreach (var user in sortedData)
        {
            Console.WriteLine($"Name: {user.Name}, Level: {user.Level}");
        }
        Console.ReadLine();
    }
}