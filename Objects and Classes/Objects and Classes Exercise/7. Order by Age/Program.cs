using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] personInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                string ID = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = new Person(name, ID, age);

                if (people.Any(x => x.ID == ID))
                {
                    int index = people.FindIndex(x => x.ID == ID);

                    people[index].Age = age;
                    people[index].Name = name;
                }
                else
                {
                    people.Add(person);

                }
                command = Console.ReadLine();
            }
            
            foreach (Person person1 in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person1.Name} with ID: {person1.ID} is {person1.Age} years old.");
            }

        }
    }
}
public class Person
{
    public Person(string name, string iD, int age)
    {
        this.Name = name;
        this.ID = iD;
        this.Age = age;
    }

    public string Name { get; set; }
    public string ID { get; set; }

    public int Age { get; set; }
}
