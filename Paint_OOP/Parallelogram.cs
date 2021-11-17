using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Parallelogram : Rectangle
    {
        public double Heights { get; set; }
        public double Bottom { get; set; }
        protected Point h = new Point();
        public Point H 
        {
            get { return h; }
            set { h = value; }
        }
        public Parallelogram()
        {

        }
        public Parallelogram(string name, string color) : base(name, color)
        {

        }
        public Parallelogram(string name, string color, double height, double bottom, double hY) : base(name, color)
        {
            Heights = height;
            Bottom = bottom;
            H.X = 0;
            H.Y = hY;
        }
        public override void Input()
        {
            try
            {
                Console.Write("Enter the Name: ");
                Name = Console.ReadLine();
                Console.Write("Color: ");
                Color = Console.ReadLine();
                Console.Write("Enter the bottom: ");
                Bottom = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Height: ");
                Heights = Convert.ToDouble(Console.ReadLine());
                Points[0] = new Point(Name[0].ToString(), 0, 0);
                CalculateArea();
                createOtherPoint();
                createEdge();
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
                Console.WriteLine("Bottom: " + Bottom);
                Console.WriteLine("Height: " + Heights);
                Console.WriteLine("Color: " + Color);
                Console.WriteLine("Area: " + Area);
                Console.WriteLine("The four point: ");
                for (int i = 0; i < Points.Length; i++)
                {
                    Points[i].Output();
                    Console.WriteLine("\n");
                }
                Area = CalculateArea();
                Console.WriteLine("Area: " + Area);
                Draw();
                Console.Write("Enter the distance dx you want to move: ");
                Dx = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the distance dy you want to move: ");
                Dy = Convert.ToDouble(Console.ReadLine());
                Move(Dx, Dy);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void createOtherPoint()
        {
            Points[1] = new Point(Name[1].ToString(), H.Y, Heights);
            Points[2] = new Point(Name[2].ToString(), Heights, Bottom + H.Y);
            Points[3] = new Point(Name[3].ToString(), Bottom, 0);
        }
        public override void createEdge()
        {
            Edges[0] = new Edge(Points[0], Points[1]);
            Edges[1] = new Edge(Points[1], Points[2]);
            Edges[2] = new Edge(Points[2], Points[3]);
            Edges[3] = new Edge(Points[3], Points[0]);
        }
        public override void Move(double dx, double dy)
        {
            try
            {
                for (int i = 0; i < Points.Length; i++)
                {
                    Console.WriteLine("The point {0} when moved! ", i + 1);
                    Points[i].Move(dx, dy);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override double CalculateArea()
        {
            double area = Heights * Bottom * 0.5;
            Area = area;
            return area;
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " rectangular " + Name + " with Height is " + Height + " Width is " + Bottom);
            Console.ResetColor();
        }
    }
}
