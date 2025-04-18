using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace DefiningClasses
{
    internal class Family
    {
        private List<Person> members = new List<Person>();
        public Family() { }
        public void AddMembers(Person member)
        {
            members.Add(member);
        }
        public Person GetOldestMember()
        {
            return members.FirstOrDefault(x => x.Age == members.Max(x => x.Age));
        }
    }
}
