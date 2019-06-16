using System;
using System.Collections.Generic;

namespace _02._Oldest_Family_Member
{
    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person() { }

        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person ReturnOldestMember()
        {
            int tempAge = int.MinValue;
            Person oldestMember = new Person();
            foreach (var person in this.Members)
            {
                if (person.Age > tempAge)
                {
                    tempAge = person.Age;
                    oldestMember = person;
                }
            }
            return oldestMember;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            MakeFamily(family);

            PrintOldestMember(family);
        }

        private static void PrintOldestMember(Family family)
        {
            Person oldest = family.ReturnOldestMember();
            Console.WriteLine(string.Join(" ",oldest.Name, oldest.Age));
        }

        private static void MakeFamily(Family family)
        {
            int familyMembers = int.Parse(Console.ReadLine());
            for (int i = 0; i < familyMembers; i++)
            {
                string[] inputMember = Console.ReadLine().Split();
                string name = inputMember[0];
                int age = int.Parse(inputMember[1]);
                Person newPerson = new Person(name, age);
                family.AddMember(newPerson);
            }
        }
    }
}
