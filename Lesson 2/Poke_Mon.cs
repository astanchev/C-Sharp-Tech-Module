using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceToTargetM = int.Parse(Console.ReadLine());
            byte exhaustionFactorY = byte.Parse(Console.ReadLine());
            int originalPokePowerN = pokePowerN;
            int pokedTargets = 0;
            while (true)
            {
                if (originalPokePowerN == 2 * pokePowerN && pokePowerN > exhaustionFactorY && exhaustionFactorY!=0)
                {
                    pokePowerN /= exhaustionFactorY;
                }
                if (pokePowerN >= distanceToTargetM)
                {
                    pokePowerN -= distanceToTargetM;
                    pokedTargets++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(pokedTargets);

        }
    }
}
