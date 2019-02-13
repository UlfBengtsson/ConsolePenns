using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolePenns
{
    abstract class Pen
    {
        protected ConsoleColor color;
        protected string material;
        protected string name;
        protected double size;

        public Pen(ConsoleColor color, string material, string name, double size)
        {
            this.color = color;
            this.material = material;
            this.name = name;
            this.size = size;
        }

        public abstract void Write(string text);
    }
}
