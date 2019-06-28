using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _09._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMessages = int.Parse(Console.ReadLine());
            
            List<string> destroyedPlanets = new List<string>();
            List<string> attackededPlanets = new List<string>();

            Regex patternForDecrypt = new Regex(@"[tTsSrRaA]");
            Regex patternForPlanets = new Regex(@"@([a-zA-Z]+)[^@\-!:>]*:[0-9]+[^@\-!:>]*!([AD])![^@\-!:>]*->[0-9]+");


            for (int i = 0; i < numberMessages; i++)
            {
                string message = Console.ReadLine();
                StringBuilder resultMessage = new StringBuilder();

                MatchCollection decryptionMatches = patternForDecrypt
                                                    .Matches(message);
                int decryptionKey = decryptionMatches.Count;

                foreach (var symb in message)
                {
                    char newSymb = (char)(symb - decryptionKey);
                    resultMessage.Append(newSymb);
                }

                string newMessage = resultMessage.ToString();

                if (patternForPlanets.IsMatch(newMessage))
                {
                    string planetName = patternForPlanets
                                        .Match(newMessage)
                                        .Groups[1]
                                        .Value;
                    string attackOrDestroy = patternForPlanets
                                        .Match(newMessage)
                                        .Groups[2]
                                        .Value;

                    if (attackOrDestroy == "A")
                    {
                        attackededPlanets.Add(planetName);
                    }
                    else if (attackOrDestroy == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackededPlanets.Count}");
            if (attackededPlanets.Count > 0)
            {
                foreach (var planet in attackededPlanets.OrderBy(p => p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }            

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(p => p))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            
        }
    }
}
