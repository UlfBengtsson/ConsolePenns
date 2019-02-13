using System;

namespace ConsolePenns
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new WhiteboardPen(ConsoleColor.Blue, "Plastic", "ArtLine517",1.2);

            pen.Write("Testing our pen");

            Console.ReadKey(true);
        }
    }
}
