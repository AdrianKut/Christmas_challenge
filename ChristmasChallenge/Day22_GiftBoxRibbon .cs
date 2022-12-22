using ChristmasChallenge.Day_19;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasChallenge
{

    /**
     * Mikołaj zapakował prezenty w pudełka i papier i chce jeszcze obwiązać je wstążką.
     * Ma 5 pudełek o wielkości 10cmx13cmx15cm.
     * Oblicz i wypisz na ekranie, ile metrów wstążki musi kupić Mikołaj.
     * Załóż, że dla każdego prezentu musi kupić tyle wstążki,
     * żeby obwiązać prezent oddzielnie z dwóch stron + dla każdej strony mieć zapas 50%.
     * Niech wstązka krzyzuje sie na sciance o największej powierzchni.
     */

    internal class Day22_GiftBoxRibbon : IShowResult
    {

        private double ChangeCmToM(double x)
        {
            return x = x / 100;
        }

        public double CalculateNeededRibbon(int a , int b)
        {
           return (2 * a + 2 * b) * 1.5;
        }

        public void ShowResult()
        {

            Box box = new Box(10,13,15);
            int boxesAmount = 5;

            double firstPartForRibbon = CalculateNeededRibbon(box.X, box.Y);
            double secondPartForRibbon = CalculateNeededRibbon(box.X, box.Z);

            double neededRibbon = (firstPartForRibbon + secondPartForRibbon) * boxesAmount;
            neededRibbon = ChangeCmToM(neededRibbon);
            Console.WriteLine($"Santa need {neededRibbon:f2}[m] of ribbon");
        }
    }
}
