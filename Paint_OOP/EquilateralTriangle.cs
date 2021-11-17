using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class EquilateralTriangle : Triagle
    {
        private double dEdgeTriangle = 0;
        public double EdgeTriagle
        {
            get { return dEdgeTriangle; }
            set
            {
                dEdgeTriangle = value;
                HeightTri = value;
                EdgeA = value;
            }
        }
        public EquilateralTriangle()
        {

        }
        public EquilateralTriangle(string name, double edgetri) : base (name, edgetri, edgetri, edgetri) 
        {
            this.EdgeTriagle = edgetri;
        }
        public EquilateralTriangle(string name, string color, double edgetri) : base(name, edgetri, edgetri, edgetri)
        {
            this.EdgeTriagle = edgetri;
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
                EdgeTriagle = Convert.ToDouble(Console.ReadLine());
                Pointss[0] = new Point(Name[0].ToString(), 0, 0);
                CalculateArea();
                CreatePoint();
                CreateEdge();
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
                Console.WriteLine("Edge lenght: " + EdgeTriagle);
                Console.WriteLine("Color: " + Color);
                Console.WriteLine("Area: " + Area);
                Console.WriteLine("The four point: ");
                for (int i = 0; i < Pointss.Length; i++)
                {
                    Pointss[i].Output();
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
            Console.WriteLine("Drawed a " + Color + " sqare " + Name + " with each edge is " + EdgeTriagle);
            Console.ResetColor();
        }
    }
}
