namespace SquareLib;

public class Triangle : IFigure // Triangle figure
{
    private readonly double _a, _b, _c;

    public Triangle(double a, double b, double c)
    {
        if (!IsTriangle(a, b, c)) throw new ArgumentException("Треугольник не существует");
        var sides = new List<double> { a, b, c };
        sides.Sort(); // Sort is necessary to check if triangle is right 
        _a = sides[0];
        _b = sides[1];
        _c = sides[2];
    }

    private static bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    
    public double CalcSquare()
    {
        double result;
        if (Math.Abs(_a*_a + _b*_b - _c*_c) < 0.00000001)
        {
            result = _a * _b * 0.5;
        }
        else
        {
            var p = (_a + _b + _c) * 0.5;
            result = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
        return result;
    }


}