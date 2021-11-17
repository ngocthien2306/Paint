using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        protected Point center = new Point();
        public Point Center
        {
            get { return center; }
            set { center = value; }
        }
        public Circle()
        {
            Name = "";
            Radius = 0;
            Center.Name = "O";
            Center.X = 0;
            Center.Y = 0;
        }
        public Circle(string name, double radius, Point point, string color)
        {
            Name = name;
            Radius = radius;
            Color = color;
            Center = point;
            Center.Color = color;
        }
        public Circle(string name, double radius, string centerName, double x, double y, string color)
        {
            Name = name;
            Radius = radius;
            Center = new Point();
            Center.Color = color;
        }
        ~Circle()
        {

        }
        public override void Input()
        {
            Console.Write("Name ");
            Name = Console.ReadLine();
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Color: ");
            Color = Console.ReadLine();
            Console.WriteLine("Enter the center: ");
            center.Input();
            CalculateArea();
        }
        public override void Output()
        {
            string next;
            next = Console.ReadLine();
            Console.Write("Name: " + Name);
            Console.Write("Radian: " + Radius);
            Console.Write("Color: " + Color);
            Console.Write("The center: ");
            center.Output();
            Area = CalculateArea();
            Console.WriteLine("Area: {0}", Area);
            Draw();
            Console.Write("Enter the distance dx you want to move: ");
            Dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance dy you want to move: ");
            Dy = Convert.ToDouble(Console.ReadLine());
            Move(Dx, Dy);
        }
        public override double CalculateArea()
        {
            double result = 3.14 * Radius * Radius;
            Area = result;
            return result;
        }
        public override void Move(double dx, double dy)
        {
            Center.Move(dx, dy);
        }
        public override void Turn(double angle = 0, double a = 0, double b = 0)
        {
            Center.Turn(angle, a, b);
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " Cricle " + Name + " with radian is " + Radius);
            Console.WriteLine("and the center is ");
            Center.Output();
            Console.ResetColor();
        }
    }
}
