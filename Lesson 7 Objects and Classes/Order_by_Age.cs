using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Persons
    {
        public Persons(string name, string personalID, int age)
        {
            this.Name = name;
            this.PersonalID = personalID;
            this.Age = age;
        }

        public string Name { get; set; }

        public string PersonalID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {PersonalID} is {Age} years old.";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Persons> personsList = new List<Persons>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine=="End")
                {
                    break;
                }
                string[] input = inputLine.Split().ToArray();
                string name = input[0];
                string personalID = input[1];
                int age = int.Parse(input[2]);
                Persons newPerson = new Persons(name, personalID, age);
                personsList.Add(newPerson);
            }
            List<Persons> orderedPersonsList = personsList
                                                .OrderBy(p => p.Age)
                                                .ToList();
            foreach (var person in orderedPersonsList)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}
