using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public Person() { }
        public void Print(List<Person> people)
        {
            List<Person> peopleOver30 = new List<Person>();
            peopleOver30.AddRange(people.FindAll(x => x.Age > 30));
            var ordered = peopleOver30.OrderBy(x => x.Name);
            foreach (Person person in ordered)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
