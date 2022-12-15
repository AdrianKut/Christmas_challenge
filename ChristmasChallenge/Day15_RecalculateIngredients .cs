namespace ChristmasChallenge
{
    public abstract class BakingSheet
    {
        public abstract double GetSurfaceArea();
    }

    public class RoundBakingSheet : BakingSheet
    {
        public double Radius { get; private set; }

        public RoundBakingSheet(double radius)
        {
            Radius = radius;
        }

        public override double GetSurfaceArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }


    public class RectangleBakingSheet : BakingSheet
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public RectangleBakingSheet(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override double GetSurfaceArea()
        {
            return X * Y;
        }
    }

    internal class Day15_RecalculateIngredients : IShowResult
    {
        /**
     * Mama przesłała Mikołajowi przepisy na ciasta. 
     * Blacha mamy Mikołaja jest prostokątna i ma wymiary 20cm converter 30cm.
     * Mikołaj ma blachę okrągłą o średnicy 9.8 cm.
     * Pomóż Mikołajowi przeliczuć składniki przepisu na jego blaszkę.
     * Przygotuj funkcję, która będzie przyjmować 2 wymiary blaszki prostokątnej oraz średnicę okrąglej
     * i dla podanej listy składników dla prostokątnej przeliczy ich ilość dla okrągłej.
     * Dla uproszczenia nie przejmuj się jednostkami i załóż, że formy mają taką samą wysokość.
     */

        public double GetBakingSheetConverter(double firstBakingSheet, double secontBakingSheet)
        {
            return firstBakingSheet / secontBakingSheet;
        }

        public double GetConverterAmountOfIngredients(double converter, double amount)
        {
            return amount / converter;
        }

        public void ShowResult()
        {
            Dictionary<string, int> ingredientsForRectangleForm = new Dictionary<string, int>()
            {
                { "Maka", 300 },
                { "Cukier", 100},
                { "Jajka", 4 },
                { "Czekolada", 200 },
                { "Maslo", 200 }
            };

            RectangleBakingSheet rectangleBakingSheet = new RectangleBakingSheet(20, 30);
            RoundBakingSheet roundBakingSheet = new RoundBakingSheet((9.8/2));

            double rectangleSurfaceArea = rectangleBakingSheet.GetSurfaceArea();
            double roundSurfaceArea = roundBakingSheet.GetSurfaceArea();

            double converter = GetBakingSheetConverter(rectangleSurfaceArea, roundSurfaceArea);
            
            foreach (KeyValuePair<string, int> item in ingredientsForRectangleForm)
            {
                Console.WriteLine($"{item.Key}: {item.Value} --> {GetConverterAmountOfIngredients(converter, item.Value):F0}");
            }
        } 
    }
}
