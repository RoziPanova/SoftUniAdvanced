using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>>students=new Dictionary<string,List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[]input=Console.ReadLine().Split(' ');
                if (students.ContainsKey(input[0])==true)
                {
                    students[input[0]].Add(decimal.Parse(input[1]));
                }
                else
                {
                    students.Add(input[0], new List<decimal>());
                    students[input[0]].Add(decimal.Parse(input[1]));
                }
            }
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ",item.Value.Select(x=>string.Format("{0:f2}",x)))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
