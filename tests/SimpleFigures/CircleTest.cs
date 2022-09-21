namespace Figures.Tests.SimpleFigures;

public class CircleTest
{
    [Theory]
    [InlineData(-10)]
    [InlineData(0)]
    public void Init_RadiusLessOrEqual0_ThrowCanNotExsistException(double radius)
    {
        Point center = new(0, 0);

        Assert.Throws<FigureCanNotExsistException>(() =>
        {
            Circle circle = new(center, radius);
        });
    }

    [Fact]
    public void GetPerimeter_Radius7_Approximately44()
    {
        Point center = new(0, 0);
        double radius = 7;
        double fault = 0.1e5;
        double perimeter = 43.9822971502571053384770073659D;

        Circle circle = new(center, radius);
        var perimeterCircle = circle.GetPerimeter();

        var difference = 1 - Math.Abs(perimeter / perimeterCircle);

        Assert.True(fault > difference);
    }

    [Fact]
    public void GetArea_Radius7_Approximately154()
    {
        Point center = new(0, 0);
        double radius = 7;
        double fault = 0.0e5;
        double area = 153.938040025899868684669525781D;

        Circle circle = new(center, radius);
        var areaCircle = circle.GetArea();

        var difference = 1 - Math.Abs(area / areaCircle);

        Assert.True(fault > difference);
    }
}
