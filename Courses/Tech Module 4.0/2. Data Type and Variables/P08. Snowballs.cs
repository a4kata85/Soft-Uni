using System;
using System.Numerics;


namespace P08._Snowballs
{
    class Snowballs
    {
        static void Main()
        {
            int snowballsN = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQality = 0;


            for (int i = 0; i < snowballsN; i++)
            {
               int snowballSnowCurrent = int.Parse(Console.ReadLine());
               int snowballTimeCurrent = int.Parse(Console.ReadLine());
               int snowballQalityCurrent = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow(snowballSnowCurrent / snowballTimeCurrent, snowballQalityCurrent);
                if (value >= maxValue)
                {
                    maxValue = value;
                    snowballSnow = snowballSnowCurrent;
                    snowballTime = snowballTimeCurrent;
                    snowballQality = snowballQalityCurrent;
                }
            }
            
            Console.WriteLine("{0} : {1} = {2} ({3})", snowballSnow, snowballTime, maxValue, snowballQality);          
        }
    }
}

