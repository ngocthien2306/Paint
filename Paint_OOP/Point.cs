using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Point : Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point()
        {

        }
        public Point(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        public Point(string name, double x, double y, string color)
        {
            Name = name;
            X = x;
            Y = y;
            Color = color;
        }
        ~Point()
        {

        }
        public override void Input()
        {
            try
            {
                Console.Write("Name: ");
                Name = Console.ReadLine();
                Console.Write("Enter point X: ");
                X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter point Y: ");
                Y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Color: ");
                Color = Console.ReadLine();
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public override void Output()
        {
            try
            {
                Area = CalculateArea();
                Console.WriteLine("Name " + Name);
                Console.WriteLine("X: {0}", X);
                Console.WriteLine("Y: {0}", Y);
                Console.WriteLine("Color: " + Color);
                Console.WriteLine("Area: " + Area);
                Draw();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public override void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
            Console.WriteLine("X: " + X);
            Console.WriteLine("Y: " + Y);
        }
        public override void Turn(double angle = 0, double a = 0, double b = 0)
        {
            try
            {
                this.X = (X - a) * Math.Cos(angle) - (Y - b) * Math.Sin(angle) + a;
                this.Y = (X - a) * Math.Sin(angle) + (Y - b) * Math.Cos(angle) + a;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public override double CalculateArea()
        {
            return 0;
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " point " + Name + " with position (" + X + "," + Y + ")");
            Console.ResetColor();
        }
    }
}