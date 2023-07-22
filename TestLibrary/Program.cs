using System;
using CalculateAreaShapes;

namespace TestLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        IFigure f;

        f = new Circle(12);
        Console.WriteLine(String.Format("Circle: {0}\n", f.Calculate()));

        f = new Triangle(12, 6, 8);
        Console.WriteLine(String.Format("Triangle: {0}\n", f.Calculate()));

        Triangle t1 = new Triangle(12, 6, 8);
        Console.WriteLine(String.Format("Triangle 1 (Equilateral = {0}): {1}\n", t1.isEquilateralTriangle(), t1.Calculate()));

        Triangle t2 = new Triangle(7, 24, 25);
        Console.WriteLine(String.Format("Triangle 1 (Equilateral = {0}): {1}\n", t2.isEquilateralTriangle(), t2.Calculate()));

        Triangle t3 = new Triangle(12, -1, -3);
        Console.WriteLine(String.Format("Triangle 1 (Equilateral = {0}): {1}\n", t3.isEquilateralTriangle(), t3.Calculate()));
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }
    }
  }
}
