using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Triagle : Shape
    {
        protected Point[] points = new Point[3];
        public double HeightTri { get; set; }
        public double WidthTri { get; set; }
        public double Heighttri
        {
            get { return HeightTri; }
            set { HeightTri = value; }
        }
        public Point[] Pointss
        {
            get { return points; }
            set { points = value; }
        }
        protected Edge[] edges = new Edge[3];
        public Edge[] Edges
        {
            get { return edges; }
            set { edges = value; }
        }
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }
        public Triagle()
        {

        }
        public Triagle(string name, double a, double b, double c)
        {
            try
            {
                Pointss[0] = new Point(name[0].ToString(), 0, 0);
                EdgeA = a;
                EdgeB = b;
                EdgeC = c;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Triagle(string name, string color, double a, double b, double c)
        {
            try
            {
                Pointss[0] = new Point(name[0].ToString(), 0, 0);
                Color = color;
                EdgeA = a;
                EdgeB = b;
                EdgeC = c;
                CalculateArea();
                CreatePoint();
                CreateEdge();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        protected virtual void CreatePoint()
        {
            double p = (EdgeA + EdgeB + EdgeC) / 2;
            HeightTri = 2 * Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC))/ EdgeA;
            WidthTri = EdgeA;
            Pointss[1] = new Point(Name[1].ToString(), 0, HeightTri);
            Pointss[2] = new Point(Name[2].ToString(), WidthTri, HeightTri);
        }
        protected virtual void CreateEdge()
        {
            Edges[0] = new Edge(Pointss[0], Pointss[1]);
            Edges[1] = new Edge(Pointss[1], Pointss[2]);
            Edges[2] = new Edge(Pointss[2], Pointss[0]);
        }
        public override void Input()
        {
            try
            {            
                Console.Write("Enter name of triagle: ");
                Name = Console.ReadLine();
                Console.Write("Enter color: ");
                Color = Console.ReadLine();
                Console.Write("Enter the Edge 1: ");
                EdgeA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Edge 2: ");
                EdgeB = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Edge 3: ");
                EdgeC = Convert.ToDouble(Console.ReadLine());
                Pointss[0] = new Point(Name[0].ToString(), 0, 0);
                CalculateArea();
                CreatePoint();
                CreateEdge();


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            
        }
        //public int CheckTriangle()
        //{
        //    if (EdgeA == EdgeB || EdgeB == EdgeC || EdgeC == EdgeA)
        //        if (EdgeA == EdgeB && EdgeB == EdgeC)
        //            return 1;
        //        else if (EdgeA * EdgeA == EdgeB * EdgeB + EdgeC * EdgeC || EdgeB * EdgeB == EdgeA * EdgeA + EdgeC * EdgeC || EdgeB * EdgeB + EdgeA * EdgeA == EdgeC * EdgeC)
        //            return 2;
        //        else return 3;
        //    else if (EdgeA * EdgeA == EdgeB * EdgeB + EdgeC * EdgeC || EdgeB * EdgeB == EdgeA * EdgeA + EdgeC * EdgeC || EdgeB * EdgeB + EdgeA * EdgeA == EdgeC * EdgeC)
        //        return 4;
        //    else return 5;
        //}
        //public void TypeofTriangle()
        //{
        //    switch (CheckTriangle())
        //    {
        //        case 1:
        //            Console.WriteLine("Tam giac deu \n");
        //            break;
        //        case 2:
        //            Console.WriteLine("Tam giac vuong can \n");
        //            break;
        //        case 3:
        //            Console.WriteLine("Tam giac can \n");
        //            break;
        //        case 4:
        //            Console.WriteLine("Tam giac vuong \n");
        //            break;
        //        default:
        //            Console.WriteLine("Tam giac thuong \n");
        //            break;
        //    }
        //}
        public override void Output()
        {
            try
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Color: " + Color);
                Console.WriteLine("Edge 1: " + EdgeA);
                Console.WriteLine("Edge 2: " + EdgeB);
                Console.WriteLine("Edge 3: " + EdgeC);
                Console.WriteLine("Area of triangle: " + Area);
                Console.WriteLine("The three points: ");
                for (int i = 0; i < Pointss.Length; i++)
                {
                    Pointss[i].Output();
                    Console.WriteLine("\n");
                }
                Area = CalculateArea();
                Console.WriteLine("Area: " + Area);
                Draw();
                string choice;
                do
                {
                    Console.Write("Do you want to move the shape? Yes  or No: ");
                    choice = Convert.ToString(Console.ReadLine());
                    switch(choice)
                    {
                        case "Yes":
                            Console.Write("Enter the distance dx you want to move: ");
                            Dx = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the distance dy you want to move: ");
                            Dy = Convert.ToDouble(Console.ReadLine());
                            Move(Dx, Dy);
                            break;
                        case "No":
                            break;
                        default:
                            Console.WriteLine("ERROR!. Please enter again!");
                            break;
                    }
                } while (choice != "No");
                
                Turn();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override void ChangeColor(string newColor)
        {
            base.ChangeColor(newColor);
        }
        public override double CalculateArea()
        {
            try
            {
                double p = 0.5 * (EdgeA + EdgeB + EdgeC);
                Area = 0.25 * Math.Sqrt((EdgeA + EdgeB + EdgeC) *(EdgeA + EdgeB - EdgeC) *(EdgeB + EdgeC - EdgeA) *(EdgeC - EdgeB + EdgeA));
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Area;
        }
        public override void Draw()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Drawed a " + Color + " triangle " + Name + " with Edge 1 = " + EdgeA + " Edge 2 = " + EdgeB + " and Edge 3 = " + EdgeC);
            Console.ResetColor();
        }
        public override void Move(double dx, double dy)
        {
            try
            {
                for(int i = 0; i < Pointss.Length ; i++)
                {
                    Console.WriteLine("The point {0} when moved! ", i + 1);
                    Pointss[i].Move(dx, dy);                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }         
        }
        public override void Turn(double angle = 0, double a = 0, double b = 0)
        {
            try
            {
                for (int i = 0; i < Pointss.Length; i++)
                {
                    Pointss[i].Turn(angle, a, b);
                }
                for (int i = 0; i < Edges.Length; i++)
                {
                    Edges[i].Turn(angle, a, b);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
