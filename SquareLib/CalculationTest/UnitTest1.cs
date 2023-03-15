using SquareLib;

namespace CalculationTest;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        var triangleAct = triangle.CalcSquare();
        Assert.That(triangleAct, Is.EqualTo((Object) 6.0d));
    }

    [Test]
    public void CommonTriangleTest()
    {
        var triangle = new Triangle(6, 12, 11);
        var triangleAct = triangle.CalcSquare();
        var actualDelta = Math.Abs(triangleAct - 32.83d);
        Assert.That(actualDelta, Is.LessThan((Object) 0.01d));
    }
    
    [Test]
    public void CircleTest()
    {
        var circle = new Circle(5);
        var circleAct = circle.CalcSquare();
        var actualDelta = Math.Abs(circleAct - 78.53d);
        Assert.That(actualDelta, Is.LessThan((Object) 0.01d));
    }
}
