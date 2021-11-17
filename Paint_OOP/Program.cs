using System;
using System.Collections.Generic;
namespace Paint_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            List<ComplexShape> group = new List<ComplexShape>();
            int choise;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t\t\t          -------MENU-------");
                    Console.WriteLine("\t\t\t\t\t| -       1. Draw a point         - |");
                    Console.WriteLine("\t\t\t\t\t| -       2. Draw a line          - |");
                    Console.WriteLine("\t\t\t\t\t| -       3. Draw a triagle       - |");
                    Console.WriteLine("\t\t\t\t\t| -       4. Draw a rectangle     - |");
                    Console.WriteLine("\t\t\t\t\t| -       5. Draw a circle        - |");
                    Console.WriteLine("\t\t\t\t\t| -       6. Draw a edge          - |");
                    Console.WriteLine("\t\t\t\t\t| -       7. Create a group       - |");
                    Console.WriteLine("\t\t\t\t\t| -       8. Move                 - |");
                    Console.WriteLine("\t\t\t\t\t| -       9. Turn                 - |");
                    Console.WriteLine("\t\t\t\t\t| -      10. Ungroup              - |");
                    Console.WriteLine("\t\t\t\t\t| -      11. Exit                 - |");
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Write("\t\t\t\t\t ----------------------------------\n");
                Console.Write("\t\t\t\t\tEnter your choise: ");
                choise = Convert.ToInt32(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Shape point = new Point();
                        point.Input();
                        shapes.Add(point);
                        point.Draw();
                        break;
                    case 2:
                        Shape line = new Line();
                        line.Input();
                        shapes.Add(line);
                        line.Draw();
                        break;
                    case 3:
                        int choice1;
                        Console.WriteLine("--------MENU---------");
                        Console.WriteLine("1. Equilateral triangle");
                        Console.WriteLine("2. Triangle ");
                        Console.WriteLine("3. Exit!\n");
                        Console.Write("Enter your choice: ");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        if (choice1 == 1)
                        {
                            Triagle Equi = new EquilateralTriangle();
                            Equi.Input();
                            Equi.Draw();
                            shapes.Add(Equi);
                        }
                        else if(choice1 == 2)
                        {
                            Triagle tri = new Triagle();
                            tri.Input();
                            tri.Draw();
                            shapes.Add(tri);
                        }
                        else if(choice1 == 3)
                        {
                            break;
                        }

                        break;
                    case 4:
                        int choice;
                        Console.WriteLine("--------MENU---------");
                        Console.WriteLine("1. Sqare");
                        Console.WriteLine("2. Parallelogram");
                        Console.WriteLine("3. Rhombus");
                        Console.WriteLine("4. Rectangle");
;                       Console.WriteLine("5. Exit!");
                        Console.Write("Enter your choice: ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            Rectangle sqare = new Sqare();
                            sqare.Input();
                            sqare.Draw();
                            shapes.Add(sqare);
                        }
                        else if (choice == 2)
                        {
                            Rectangle Para1 = new Parallelogram();
                            Para1.Input();
                            Para1.Draw();
                            shapes.Add(Para1);
                        }
                        else if (choice == 3)
                        {
                            Rectangle rhom = new Rhombus();
                            rhom.Input();
                            rhom.Draw();
                            shapes.Add(rhom);
                        }

                        else if (choice == 4)
                        {
                            Rectangle rec = new Rectangle();
                            rec.Input();
                            rec.Draw();
                            shapes.Add(rec);
                            break;
                        }
                        else if (choice == 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Your choice is ERROR! please choise again");
                        }
                        break;
                    case 5:
                        Circle circle = new Circle();
                        circle.Input();
                        circle.Draw();
                        shapes.Add(circle);
                        break;
                    case 6:
                        Edge edge = new Edge();
                        edge.Input();
                        edge.Draw();
                        break;
                    case 7:
                        ComplexShape a = new ComplexShape();
                        a.Input();
                        int choice7 = 0;
                        do
                        {
                            Console.WriteLine("--------Group---------");
                            Console.WriteLine("1. Add more memmber");
                            Console.WriteLine("2. Exit!");
                            Console.Write("Enter your choice: ");
                            choice7 = Convert.ToInt32(Console.ReadLine());
                            switch (choice7)
                            {
                                case 1:
                                    Console.Write("Name of shape to add: ");
                                    string name = Console.ReadLine();
                                    for (int i = 0; i < shapes.Count; i++)
                                    {
                                        if(shapes[i].Name == name)
                                        {
                                            a.Shapes.Add(shapes[i]);
                                            shapes.Remove(shapes[i]);
                                        }
                                    }
                                    break;
                                case 2:
                                    break;
                                default:
                                    Console.WriteLine("Your choice is ERROR! please choise again");
                                    break;
                            }
                        } while (choice7 != 2);
                        a.Draw();
                        group.Add(a);
                        break;
                    case 8:
                        Console.Write("Enter the name of the Shape you want to move:");
                        string nameMove = Console.ReadLine();
                        Console.WriteLine("Enter the vector to move shape: ");
                        double Dx = Convert.ToDouble(Console.ReadLine());
                        double Dy = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < shapes.Count; i++)
                        {
                            if (shapes[i].Name == nameMove)
                            {
                                shapes[i].Move(Dx, Dy);
                            }
                        }
                        break;
                    case 9:
                        Console.Write("Enter the name of the Shape you want to turn:");
                        string nameTurn = Console.ReadLine();
                        Console.Write("Enter the angle to Turn: ");
                        double angle = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the center to Turn shape: ");
                        double X = Convert.ToDouble(Console.ReadLine());
                        double Y = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < shapes.Count; i++)
                        {
                            if (shapes[i].Name == nameTurn)
                            {
                                shapes[i].Turn(angle, X, Y);
                            }
                        }
                        break;
                    case 10:
                        Console.Write("Enter the name of the group you want to Ungroup:");
                        string nameGroup = Console.ReadLine();
                        for (int i = 0; i < group.Count; i++)
                        {
                            if (group[i].Name == nameGroup)
                            {
                                for (int l = 0; l < group[i].Shapes.Count; l++)
                                {
                                    group[i].Shapes[l].Draw();
                                }
                                shapes.AddRange(group[i].Shapes);

                                group.Remove(group[i]);
                            }
                        }
                       break;
                    default:
                        Console.WriteLine("Invalid choise.");
                        break;
                }                
            }
            while (choise != 11);
        }
    }
}
