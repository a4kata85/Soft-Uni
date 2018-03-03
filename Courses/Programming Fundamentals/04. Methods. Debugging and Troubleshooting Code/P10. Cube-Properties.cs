using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.CubeProperties
{
    class StartUp
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string wantedCalcolation = Console.ReadLine();

            if (wantedCalcolation == "face")
            {
                Console.WriteLine("{0:f2}", GetCubeFaceDiagonals(side));
            }
            else if (wantedCalcolation == "space")
            {
                Console.WriteLine("{0:f2}" , GetCubeSpaceDiagonals(side));
            }
            else if (wantedCalcolation == "volume")
            {
                Console.WriteLine("{0:f2}", GetCubeVolume(side));
            }
            else if (wantedCalcolation == "area")
            {
                Console.WriteLine("{0:f2}", GetCubeSurfaceArea(side));
            }
        }
        public static double GetCubeFaceDiagonals(double a)
        {
            double faceDiagonals = Math.Sqrt(2 * a * a);
            return faceDiagonals;
        }
        public static double GetCubeSpaceDiagonals(double a)
        {
            double spaceDiagonals = Math.Sqrt(3 * a * a);
            return spaceDiagonals;
        }
        public static double GetCubeVolume(double a)
        {
            double volume = a * a * a;
            return volume;
        }
        public static double GetCubeSurfaceArea(double a)
        {
            double surfaceArea = 6 * a * a;
            return surfaceArea;
        }
    }
}
