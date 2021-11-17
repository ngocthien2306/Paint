using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    abstract class Shape
    {
        public double Dx { get; set; }
        public double Dy { get; set; }
        public double Dl { get; set; }
        public virtual string Name { get; set; }
        public virtual double Area { get; protected set; }
        protected ConsoleColor consoleColor = Console.ForegroundColor;
        public virtual string Color
        {
            get { return consoleColor.ToString(); }
            set { ChangeColor(value); }
        }
        public abstract void Input();
        public abstract void Output();
        public abstract double CalculateArea();
        public abstract void Move(double dx, double dy);
        public abstract void Turn(double angle = 0, double a = 0, double b = 0);
        public abstract void Draw();
        public virtual void ChangeColor(string newColor)
        {
            try
            {
                consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), newColor, true);
            }
            catch (Exception)
            {
                // Invalid color
            }
        }
    }
}
