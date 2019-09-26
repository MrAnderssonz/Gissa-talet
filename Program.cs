using System;

namespace Gissa_talet
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0;
            int secretNumber;
            int userGuess = 0;
            Random random = new Random();
            secretNumber = random.Next(0, 101);

            Console.WriteLine("Välkommen till GISSA TALET!");
            Console.WriteLine("Låt oss inte sitta här och vänta.");
            Console.WriteLine("Talet vi söker är mellan 1 och 100, Nu kör vi!");
            while (true)
            {
                guesses++;
                Console.Write("Vad är din gissning: ");
                string strInput = Console.ReadLine();
                try
                {
                userGuess = Convert.ToInt32(strInput);
                }
                catch
                {
                    Console.WriteLine("Hörrredu du! {0}, är väl iget tal! 👿", strInput);
                    guesses--;
                    continue;
                }

                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Nä dra mig på en vagn! Du gissade rätt,");
                    Console.WriteLine("det hemliga nummret var {0},", secretNumber);
                    Console.WriteLine("och det tog dig bara {0} försök att gissa rätt!", guesses);
                    if (guesses == 1)
                    {
                        Console.WriteLine("En gissning är ju galet! hade jag varit du");
                        Console.WriteLine("skulle jag gå och köpa en lott!");
                    }
                    return;
                }
                else if (userGuess > 100 || userGuess < 0)
                {
                    Console.WriteLine("{0} är en ogiltlig gissning! Talet är mellan 1-100", userGuess);
                    guesses--;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine("Det hemliga nummret är större än {0}, testa igen!", userGuess);
                }
                else if (userGuess > secretNumber)
                {
                    Console.WriteLine("Det hemliga nummret är lägre än {0}, testa igen!", userGuess);
                }


            }
        }
    }
}
