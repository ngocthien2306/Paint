using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Sqare : Rectangle
    {
        protected double edgeLenght = 0;
        public double EdgeLenght
        {
            get { return edgeLenght; }
            set { 
                edgeLenght = value;
                Height = value;
                Width = value;
            }
        }

        public Sqare()
        {

        }
        public Sqare(string name, double edge) : base(name, edge, edge)
        {
            this.edgeLenght = edge;
        } 
        public Sqare(string name, string color, double edge) : base(name, edge, edge)
        {
            this.edgeLenght = edge;
        }
        public override void Input()
        {
            try
            {
                Console.Write("Enter the Name: ");
                Name = Console.ReadLine();
                Console.Write("Color: ");
                Color = Console.ReadLine();
                Console.Write("Enter the edge lenght: ");
                EdgeLenght = Convert.ToDouble(Console.ReadLine());
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
                Console.WriteLine("Edge lenght: " + EdgeLenght);
                Console.WriteLine("Color: " + Color);
                Console.WriteLine("Area: " + Area);
                Console.WriteLine("The four point: ");
                for (int i = 0; i < Points.Length; i++)
                {
                    Points[i].Output();
                    Console.WriteLine("\n");
                }
                Draw();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " sqare " + Name + " with each edge is " + EdgeLenght);
            Console.ResetColor();
        }
        
    }
}
