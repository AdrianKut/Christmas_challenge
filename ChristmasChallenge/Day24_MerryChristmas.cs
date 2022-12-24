using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasChallenge
{  
     /**
     * Dzisiaj już nić nie koduj!
     * Spędź czas świętując i odpoczywając.
     * Po tylu dniach Ci się zdecydowanie należy. :D
     *
     * Gratuluję Ci, że dotarłe/aś do tego miejsca!
     * I dziękuję za udział w wyzwaniu!!!
     * Do zobaczenia na instagramie
     * Magda, @wswieciekodu <3
     */

    internal class Day24_MerryChristmas : IShowResult
    {
        public void ShowResult()
        {
            string message = "Wesołych Świąt";

            for (int i = 0; i < message.Length; i++)
            {
                ConsoleColorizer.RandomConsoleColor();
                Console.Write(message[i]);
            }
        }
    }
}
