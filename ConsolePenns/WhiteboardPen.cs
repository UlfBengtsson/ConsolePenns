using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePenns
{
    class WhiteboardPen : Pen
    {
        readonly ConsoleColor boardColor;
        public WhiteboardPen(ConsoleColor color, string material, string name, double size) : base(color,material,name,size)
        {
            boardColor = ConsoleColor.White;
        }

        public override void Write(string text)
        {
            Console.BackgroundColor = boardColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
