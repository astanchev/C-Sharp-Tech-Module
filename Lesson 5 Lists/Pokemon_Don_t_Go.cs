using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            int sum = 0;
            int increaseOrDecreaseValue = 0;
            while (pokemons.Count > 0)
            {
                int indexToRemoveAt = int.Parse(Console.ReadLine());
                if (indexToRemoveAt < 0)
                {
                    sum += pokemons[0];
                    increaseOrDecreaseValue = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i]<= increaseOrDecreaseValue)
                        {
                            pokemons[i] += increaseOrDecreaseValue;
                        }
                        else
                        {
                            pokemons[i] -= increaseOrDecreaseValue;
                        }
                    }
                }
                else if (indexToRemoveAt > pokemons.Count - 1)
                {
                    sum += pokemons[pokemons.Count - 1];
                    increaseOrDecreaseValue = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= increaseOrDecreaseValue)
                        {
                            pokemons[i] += increaseOrDecreaseValue;
                        }
                        else
                        {
                            pokemons[i] -= increaseOrDecreaseValue;
                        }
                    }
                }
                else
                {
                    sum += pokemons[indexToRemoveAt];
                    increaseOrDecreaseValue = pokemons[indexToRemoveAt];
                    pokemons.RemoveAt(indexToRemoveAt);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= increaseOrDecreaseValue)
                        {
                            pokemons[i] += increaseOrDecreaseValue;
                        }
                        else
                        {
                            pokemons[i] -= increaseOrDecreaseValue;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
