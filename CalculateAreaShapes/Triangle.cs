using System;
using System.Text;

namespace CalculateAreaShapes
{
  public class Triangle : IFigure
  {
    private const String _exceptionSideLessZeroMessage = "Side value must be greater than zero: {0}"; 
    private const String _exceptionInequalityMessage = "Triangle inequality violated: the sum of two sides is not greater than the third side. Side value: {0}";

    private double[] sides;

    private void checkIsExist()
    {
      StringBuilder exception = new StringBuilder();

      foreach (double side in sides)
      {
        if (side <= 0)
        {
          exception.AppendLine(String.Format(_exceptionSideLessZeroMessage, side));
        }
      }
      if (sides[0] + sides[1] < sides[2])
      {
        exception.AppendLine(String.Format(_exceptionInequalityMessage, sides[2]));
      }

      if (exception.Length > 0)
      {
        throw new Exception(exception.ToString());
      }
    }

    public bool isEquilateralTriangle()
    {
      return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    public double Calculate()
    {
      if (isEquilateralTriangle())
      {
        return sides[0] * sides[1] / 2;
      }
      else
      {
        double halfPerimeter = (sides[0] + sides[1] + sides[2]) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - sides[0]) * (halfPerimeter - sides[1]) * (halfPerimeter - sides[2]));

      }
    }

    public Triangle(double side1, double side2, double side3)
    {
      double[] sides = { side1, side2, side3 };
      Array.Sort(sides);
      this.sides = sides;

      checkIsExist();
    }
  }
}
