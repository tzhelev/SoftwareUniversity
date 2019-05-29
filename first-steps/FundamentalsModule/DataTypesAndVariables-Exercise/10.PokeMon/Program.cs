using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main()
        {
            long pokePowerN = long.Parse(Console.ReadLine());
            long distanceM = long.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int hitTargets = 0;
            long startingPokePower = pokePowerN;

            while (pokePowerN >= distanceM)
            {
                pokePowerN -= distanceM;
                hitTargets++;

                bool exhaustFactor = startingPokePower * 0.5 == pokePowerN && exhaustionFactorY != 0; 
                if (exhaustFactor)
                {
                    pokePowerN /= exhaustionFactorY;

                }
            }

            Console.WriteLine(pokePowerN);
            Console.WriteLine(hitTargets);
        }
    }
}
