using DefiningClasses;
using System;
using System.Net.Cache;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivan", 19);
            Person p2 = new Person
            {
                Name = "Gosho",
                Age = 19
            };
        }
    }
}
