namespace ChristmasChallenge.Day_19
{
    /**
    * Mikołaj zapakował już prezenty w pudełka i potrzebuje Twojej pomocy!
    * Ma 5 pudełek o wielkości 10cmx13cmx15cm, 10 o wielkości 20cmx15cmx10cm i 3 o wielkości 30cmx25cmx20cm.
    * Pomoż Mikołajowi! Oblicz i wypisz na ekranie, ile metrów kwadratowych papieru do pakowania prezentów musi kupić Mikołaj.
    * Wynik zaokrglij do pełnego metra w górę.
    * Załóż dla uproszczenia, że dla każdego prezentu musi kupić pole powierzchni pudełka, nie uwględniaj strat i zakładek.
    * Przygotuj funkcje liczaca ilosc potrzebnego papieru dla pudelka i uzyj jej dla kazdego pudeka.
    */

    internal class Day19_WrappingPaper : IShowResult
    {
        private int CalculateNeededWrappingPaperForGiftBox(int boxSurfaceArea, int amount)
        {
            return boxSurfaceArea * amount;
        }

        public void ShowResult()
        {
            Box small = new Box(10, 13, 15);
            Box medium = new Box(20, 15, 10);
            Box big = new Box(30, 25, 20);

            Dictionary<Box,int> boxWithAmountGiftboxes= new Dictionary<Box,int>();
            boxWithAmountGiftboxes.Add(small, 5);
            boxWithAmountGiftboxes.Add(medium, 10);
            boxWithAmountGiftboxes.Add(big, 3);

            float neededWrappingPaper = 0;

            foreach(KeyValuePair<Box,int> pair in boxWithAmountGiftboxes)    
            {
                var currentBoxSurfaceArea = pair.Key.GetBoxSurfaceArea();
                var currentNeededWrappingPaper = CalculateNeededWrappingPaperForGiftBox(currentBoxSurfaceArea, pair.Value);
                neededWrappingPaper += currentNeededWrappingPaper;
                Console.WriteLine($"For {pair.Key.ToString()} Santa Claus need {pair.Key.GetBoxSurfaceArea()}cm2 of wrapping paper " +
                    $"* {pair.Value} boxes = {currentNeededWrappingPaper}cm2");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Santa Claus need {neededWrappingPaper/10000:F0}m2 wrapping papers for all gifts");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
