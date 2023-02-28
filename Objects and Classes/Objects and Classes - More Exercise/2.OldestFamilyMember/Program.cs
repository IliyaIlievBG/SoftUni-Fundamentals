using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OldestFamilyMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < peopleCount; i++)
            {
                string[] currentPerson = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person currentFamilyMember = new Person(currentPerson[0], int.Parse(currentPerson[1]));
                
                family.AddMember(currentFamilyMember);
            }
            var oldestFamilyMember = family.GetOldestMember(family.FamilyMembers);
            Console.Write($"{oldestFamilyMember.Name} ");
            Console.WriteLine(oldestFamilyMember.Age);
        }

    }
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Family
    {
        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }
        public List<Person> FamilyMembers { get; set; }
        
        public void AddMember(Person name)
        {
            FamilyMembers.Add(name);
        }
        public Person GetOldestMember(List<Person> familyMembers)
        {
            List<Person> orderedFamilyMembers = familyMembers.OrderByDescending(x => x.Age).ToList();
            return orderedFamilyMembers[0];
        }
    }
}
