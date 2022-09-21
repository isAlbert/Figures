namespace Figures.Tests.SimpleFigures;

public class LineTest
{
    [Theory]
    [InlineData(0, 0, 0, 1, 1)]
    [InlineData(0, 0, 3, 4, 5)]
    public void GetPerimeter(double aX, double aY, double bX, double bY, double resultLength)
    {
        Point A = new(aX, aY);
        Point B = new(bX, bY);

        Line line = new(A, B);

        Assert.Equal(resultLength, line.GetPerimeter());
    }
}