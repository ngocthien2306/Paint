using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Edge : Shape
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
        public double Length { get; set; }
        public Edge()
        {

        }
        public Edge(string name, string color,string namePoint1, double x1, double y1, string namePoint2, double x2, double y2)
        {
            try
            {
                Name = name;
                Color = color;
                Point1 = new Point(namePoint1, x1, y1);
                Point2 = new Point(namePoint2, x2, y2);
                CalculateLenght();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Edge(string name, double x1, double y1, double x2, double y2)
        {
            try
            {
                Name = name;
                Point1 = new Point("A", x1, y1);
                Point2 = new Point("B", x2, y2);
                CalculateLenght();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Edge(string name, Point point, string namePoint2, double x2, double y2, string color)
        {
            Name = name;
            Point1 = point;
            Point2 = new Point(namePoint2, x2, y2);
            Color = color;
            CalculateLenght();
        }
        public Edge(Point point1, Point point2)
        {
            Name = point1.Name + point2.Name;
            Point1 = point1;
            Point2 = point2;
            CalculateLenght();
        }
        ~Edge()
        {

        }
        public override void Input()
        {
            try
            {
                Console.Write("Name edge: ");
                Name = Console.ReadLine();
                Console.Write("Color: ");
                Color = Console.ReadLine();
                Console.Write("Point 1: ");
                Point1 = new Point();
                Point1.Input();
                Console.Write("Point 2: ");
                Point2 = new Point();
                Point2.Input();
                CalculateLenght();
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
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Color: " + Color);
                Console.WriteLine("Point 1: ");
                Point1.Output();
                Console.WriteLine("Point 2: ");
                Point2.Output();
                Console.WriteLine("Length: {0}", Length);
                Console.WriteLine("Area: " + Area);
                Draw();
                Console.Write("The amout of length you want to increase or decrease: ");
                Dl = Convert.ToDouble(Console.ReadLine());
                LengthIncrease(Dl);
                Turn();
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
        public void LengthIncrease(double dL)
        {
            Length += dL;
            if(Point1.X < Point2.X)
            {
                Point1.X -= (dL / 2);
                Point2.X += (dL / 2);
            }
            else
            {
                Point1.X += (dL / 2);
                Point2.X -= (dL / 2);
            }
            if(Point1.Y < Point2.Y)
            {
                Point1.Y -= (dL / 2);
                Point2.Y += (dL / 2);
            }
            else
            {
                Point1.Y += (dL / 2);
                Point2.Y -= (dL / 2);
            }
            Console.WriteLine("X: " + Point1.X);
            Console.WriteLine("Y: " + Point1.Y);
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " edge " + Name + " with leight is " + Length);
            Console.WriteLine("and the points it go though is ");
            Point1.Output();
            Point2.Output();
            Console.ResetColor();
        }
        public void CalculateLenght()
        {
            Length = Math.Sqrt(Math.Pow(Point1.X - Point2.X, 2) + Math.Pow(Point1.Y - Point2.Y, 2));
        }
        public override double CalculateArea()
        {
            Area = 0;
            return Area;
        }
        public override void Turn(double angle = 0, double a = 0, double b = 0)
        {
            Point1.Turn(angle, a, b);
            Point2.Turn(angle, a, b);
        }
    }
}
