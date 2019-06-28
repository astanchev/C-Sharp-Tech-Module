using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07._Nether_Realms
{
    class Demons
    {
        public Demons(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string patternNumbers = @"[+-]*(?:\d+(?:\.?\d+)*)";
            string patternCharacters = @"[^\+\-\*\/\.\d]";
            string patternMultiply = @"\*";
            string patternDevide = @"\/";

            string[] demons = Console.ReadLine()
                               .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<Demons> listOfDemons = new List<Demons>();

            for (int i = 0; i < demons.Length; i++)
            {
                string demon = demons[i];
                StringBuilder name = new StringBuilder();
                int healthPoints = 0;
                double damage = 0.0;

                Regex regexName = new Regex(patternCharacters);
                MatchCollection characters = regexName.Matches(demon);
                foreach (Match match in characters)
                {
                    name.Append(match.Value);
                }
                string demonName = name.ToString();
                foreach (var @char in demonName)
                {
                    healthPoints += @char;
                }

                Regex regexMultiply = new Regex(patternMultiply);
                int multipliers = regexMultiply.Matches(demon).Count;

                Regex regexDevide = new Regex(patternDevide);
                int deviders = regexDevide.Matches(demon).Count;

                List<double> numbers = new List<double>();
                Regex regexNumbers = new Regex(patternNumbers);
                MatchCollection foundNumbers = regexNumbers.Matches(demon);
                foreach (Match match in foundNumbers)
                {
                    double value = double.Parse(match.Value);
                    numbers.Add(value);
                }
                damage = numbers.Sum();
                if (multipliers > 0)
                {
                    for (int j = 1; j <= multipliers; j++)
                    {
                        damage *= 2;
                    }
                }
                if (deviders > 0)
                {
                    for (int j = 1; j <= deviders; j++)
                    {
                        damage /= 2;
                    }
                }

                Demons newDemon = new Demons(demon, healthPoints, damage);
                listOfDemons.Add(newDemon);                
            }

            foreach (var demon in listOfDemons.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }            
        }
    }
}
