using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class ComplexShape : Shape
    {
        private List<Shape> shapes = new List<Shape>();
        public List<Shape> Shapes
        {
            get { return shapes; }
            set { shapes = value; }
        }
        public ComplexShape()
        {

        }
        public ComplexShape(string name)
        {
            Name = name;
        }
        public ComplexShape(string name, List<Shape> listShapes)
        {
            Name = name;
            Shapes = listShapes;
        }
        public override double CalculateArea()
        {
            return 0;
        }
        public override void Move(double dx, double dy)
        {
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Move(dx, dy);
            }
        }
        public override void Turn(double angle = 0, double a = 0, double b = 0)
        {
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Turn(angle, a, b);
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Drawed a  group of shape " + Name);
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Draw();
            }
        }
        public override void Input()
        {
            try
            {
                Console.Write("Name of group: ");
                Name = Console.ReadLine();
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
                Console.WriteLine("Name of group: " + Name);
                Console.WriteLine("Contain: ");
                for (int i = 0; i < Shapes.Count; i++)
                {
                    Shapes[i].Output();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
