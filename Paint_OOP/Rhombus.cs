using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Rhombus : Rectangle
    {
        public double EdgeLenght { get; set; }
        public Rhombus()
        {

        }
        public Rhombus(string name, string color) : base(name, color)
        {

        }
        public Rhombus(string name, string color, double height, double width) : base(name, color, height, width)
        {

        }
        
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " Rhombus " + Name + " with each edge is " + EdgeLenght);
            Console.ResetColor();
        }
        public override double CalculateArea()
        {
            return base.CalculateArea() / 2;
        }
        public double CalculateEdge()
        {
            double edgeLenght = Math.Sqrt(Math.Pow(Width / 2, 2) + Math.Pow(Height / 2, 2));
            EdgeLenght = edgeLenght;
            return edgeLenght;
        }
    }
}
