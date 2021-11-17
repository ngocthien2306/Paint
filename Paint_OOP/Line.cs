using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Line : Shape
    {
        Point point1 = new Point();
        Point point2 = new Point();
        public Point Point1
        {
            get { return point1; }
            set { point1 = value; }
        }
        public Point Point2
        {
            get { return point2; }
            set { point2 = value; }
        }
        public Line()
        {

        }
        public Line(string name, string color, string namePoint1, double x1, double y1, string namePoint2, double x2, double y2)
        {
            try
            {
                Name = name;
                Color = color;
                Point1 = new Point(namePoint1, x1, y1);
                Point2 = new Point(namePoint2, x2, y2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Line(string name, double x1, double y1, double x2, double y2)
        {
            try
            {
                Name = name;
                Point1 = new Point("A", x1, y1);
                Point2 = new Point("B", x2, y2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Line(string name, Point point, string namePoint2, double x2, double y2, string color)
        {
            Name = name;
            Point1 = point;
            Point2 = new Point(namePoint2, x2, y2);
            Color = color;
        }
        public Line(Point point1, Point point2)
        {
            Name = point1.Name + point2.Name;
            Point1 = point1;
            Point2 = point2;
        }
        ~Line()
        {

        }
        public override void Input()
        {
            try
            {
                Console.Write("Name: ");
                Name = Console.ReadLine();
                Console.Write("Color: ");
                Color = Console.ReadLine();
                Console.WriteLine("Point 1: ");
                Point1 = new Point();
                Point1.Input();
                Console.WriteLine("Point 2: ");
                Point2 = new Point();
                Point2.Input();
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
                Console.Write("Name: " + Name);
                Console.Write("Color: " + Color);
                Console.WriteLine("Point 1: ");
                Point1.Output();
                Console.WriteLine("Point 2: ");
                Point2.Output();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void Move(double dx, double dy)
        {
            Point1.Move(dx, dy);
            Point2.Move(dx, dy);
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " line " + Name);
            Console.WriteLine("and the points it go though is ");
            Point1.Output();
            Point2.Output();
            Console.ResetColor();
        }
        public override double CalculateArea()
        {
            return 0;
        }
        public override void Turn(double angle = 0, double a = 0, double b = 0)
        {
            Point1.Turn(angle, a, b);
            Point2.Turn(angle, a, b);
        }
    }
}
