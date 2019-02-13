using System;
using System.Collections.Generic;

namespace ConsolePenns
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new WhiteboardPen(ConsoleColor.Blue, "Plastic", "ArtLine517",1.2);

            pen.Write("Testing our whiteboardpen");

            IncPen incpen = new IncPen(ConsoleColor.DarkBlue, "Plastic and rubber", "Lexicon pen", 1.0);

            incpen.ToggleTipOnPen();

            bool tryPen = true;
            while (tryPen)
            {
                try
                {
                    incpen.Write("Second test with Incpen.");
                    tryPen = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    incpen.ToggleTipOnPen();
                }
            }

            Console.WriteLine("----------------------------------");

            Money swe100kr = new SweBill() { Name = "Kr", Worth = 100 };
            Money swe5kr = new SweCoin() { Name = "Kr", Worth = 5 };

            List<Money> money = new List<Money>
            {
                swe5kr,
                swe100kr
            };

            foreach (var item in money)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey(true);
        }
    }
}
