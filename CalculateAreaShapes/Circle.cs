using System;

namespace CalculateAreaShapes
{
  public class Circle : IFigure
  {
    double radius;

    public double Calculate()
    {
      return radius * radius * Math.PI;
    }

    public Circle(double radius)
    {
      this.radius = radius;
    }
  }
}
