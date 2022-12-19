using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasChallenge.Day_19
{
    internal class Box
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        public Box(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int GetBoxSurfaceArea()
        {
            return (2 * ((X * Y) + (X * Z) + (Y * Z)));
        }

        public override string? ToString()
        {
            return $"{X}cm x {Y}cm x {Z}cm";
        }
    }
}
