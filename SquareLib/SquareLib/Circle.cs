namespace SquareLib;

public class Circle : IFigure // Circle figure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius < 0) throw new ArgumentException("Радиус не может быть отрицательным");
        _radius = radius;
    }

    public double CalcSquare()
    {
        return Math.PI * _radius * _radius;
    }
}