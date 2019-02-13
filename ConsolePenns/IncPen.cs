using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePenns
{
    class IncPen : Pen
    {
        bool isOut;

        public IncPen(ConsoleColor color, string material, string name, double size) : base(color, material, name, size)
        {
            isOut = false;
        }

        public override void Write(string text)
        {
            if (isOut)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
            else
            {
                throw new Exception("Tip of pen is not out.");
            }
            
        }

        public bool ToggleTipOnPen()
        {
            if (isOut)//isOut==true
            {
                isOut = false;
            }
            else
            {
                isOut = true;
            }
            return isOut;
        }
    }
}
