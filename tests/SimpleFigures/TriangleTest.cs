namespace Figures.Tests.SimpleFigures;

public class TriangleTest
{
    private readonly Triangle _egyptianTriangle = new(new(0, 0), new(0, 3), new(4, 0));

    [Fact]
    public void Init_TriangleInequalityRule_CanNotExsistException()
    {
        Point a = new(0, 0);
        Point b = new(0, 3);
        Point c = new(0, -3);

        Assert.Throws<FigureCanNotExsistException>(() =>
        {
            Triangle triangle = new(a, b, c);
        });
    }

    [Fact]
    public void CanExists_InequalityRule_False()
    {
        Point a = new(0, 0);
        Point b = new(0, 3);
        Point c = new(0, -3);

        bool result = Triangle.CanExists(a, b, c);

        Assert.False(result);
    }
    [Fact]
    public void CanExists_EgyptianTriangle_True()
    {

        bool result = Triangle.CanExists(_egyptianTriangle.A, _egyptianTriangle.B, _egyptianTriangle.C);

        Assert.True(result);
    }

    [Fact]
    public void IsRectangular_EgyptianTriangle_True()
    {
        Assert.True(_egyptianTriangle.IsRectangular);
    }

    [Fact]
    public void IsIsosceles()
    {
        Point a = new(0, 2);
        Point b = new(2, 0);
        Point c = new(-2, 0);

        Triangle triangle = new(a, b, c);

        Assert.True(triangle.IsIsosceles);
    }

    [Fact]
    public void GetPerimeter_EgyptianTriangle_12()
    {
        double perimeter = _egyptianTriangle.GetPerimeter();

        Assert.Equal(12, perimeter);
    }

    [Fact]
    public void GetArea_EgyptianTriangle_6()
    {
        double area = _egyptianTriangle.GetArea();

        Assert.Equal(6, area);
    }

}
