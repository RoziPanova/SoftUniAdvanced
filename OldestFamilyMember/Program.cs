using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));
                family.AddMembers(person);
            }
            var oldest = family.GetOldestMember();
            Console.WriteLine(oldest.Name + " " + oldest.Age);
        }
    }
}
/*
5
Steve 10
Christopher 15
Annie 4
Ivan 35
Maria 34
 */
