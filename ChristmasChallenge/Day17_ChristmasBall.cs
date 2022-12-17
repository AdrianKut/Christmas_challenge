using System.Text;

namespace ChristmasChallenge
{
    /**
    * Mikołaj postanowił w tym roku skorzytać z pomocy nowoczesnych technologii.
    * Zamiast kupować choinkę i ozdoby postanowił użyć takich wygenerowanych w konsoli (terminalu)
    * Pomoż Mikołajowi! Przygotuj kod, który wypisze na ekranie bombkę choinkową.
    * Jeżeli potrafisz, nie wpisuj bombki bezpośrednio w printy - pokombinuj z pętlami.
    * Tak, żeby bombka wygenerowała się sama!
    * Bombka może mieć dowolny kształt, ale najlepiej, żeby była okrągła. :)
    */

    internal class Day17_ChristmasBall : IShowResult
    {
        private readonly int height = 25;
        private short totalLineSize;
        private short limitBuildSize;
        private short limitMiddleBuildPart;
        private short currentBuildPartSize;
        private short startBuildPartSize;

        private bool isIncreased;
        private bool isBuildMiddlePart;

        private bool colorizePartChanger = false;

        private void SetStartingValuesOfVariables()
        {
            totalLineSize = 40;
            limitBuildSize = 28;
            limitMiddleBuildPart = 6;
            currentBuildPartSize = 16;
            startBuildPartSize = currentBuildPartSize;

            isIncreased = true;
            isBuildMiddlePart = false;
        }

        private void ShowHolder()
        {
            StringBuilder currentSB = new StringBuilder();
            string currentLine = "";
            currentSB.Append(' ', (totalLineSize - 2) / 2);
            currentSB.Append('|', 2);
            currentSB.Append(' ', (totalLineSize - 2) / 2);
            currentLine += currentSB;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(currentLine);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void ShowLineWithSymbol(char symbol)
        {
            StringBuilder currentSB = new StringBuilder();
            string currentLine = "";

            currentSB.Append(' ', (totalLineSize - currentBuildPartSize) / 2);
            currentSB.Append(symbol, currentBuildPartSize);
            currentSB.Append(' ', (totalLineSize - currentBuildPartSize) / 2);
            currentLine += currentSB;

            if (isIncreased == false && isBuildMiddlePart == false)
            {
                if (currentBuildPartSize >= startBuildPartSize)
                    currentBuildPartSize -= 2;
                else
                {
                    return;
                }
            }
            else if (isIncreased == true && isBuildMiddlePart == false)
            {
                currentBuildPartSize += 2;
            }

            Console.WriteLine(currentSB.ToString());
        }

        private void ColorizeChristmasBauble(int i)
        {
            if (colorizePartChanger)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                else
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else
            {
                if (i % 2 != 0)
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                else
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }

        private void ChangeBooleanBuildStates()
        {
            if (currentBuildPartSize == limitBuildSize)
            {
                isIncreased = false;
                isBuildMiddlePart = true;
            }

            if (isBuildMiddlePart == true)
            {
                limitMiddleBuildPart--;

                if (limitMiddleBuildPart <= 0)
                {
                    isBuildMiddlePart = false;
                }
            }
        }

        public void ShowResult()
        {
            while (true)
            {
                SetStartingValuesOfVariables();

                for (int i = 0; i < limitMiddleBuildPart; i++)
                {
                    ShowHolder();
                }

                for (int i = 0; i < height - limitMiddleBuildPart; i++)
                {
                    ColorizeChristmasBauble(i);
                    ShowLineWithSymbol('0');
                    ChangeBooleanBuildStates();
                }

                colorizePartChanger = !colorizePartChanger;
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
