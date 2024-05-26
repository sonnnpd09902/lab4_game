using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> sochan = new List<int>();
        foreach (var item in list)
        {
            if (item % 2 == 0)
            {
                sochan.Add(item);
            }
        }
            foreach(var item in sochan)
            {
                Console.WriteLine(item);
            }Console.ReadLine();
    }
}
