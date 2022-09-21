using Figures.SimpleFigures;

namespace Figures;

public static class PointExtensions
{
    private static double distance(double ax, double ay, double bx, double by)
    {
        // sqrt[ (x2-x1)^2 + (y2-y1)^2 ]
        return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    }
    /// <summary>
    /// Растояние между точками <paramref name="a"/> и <paramref name="b"/> на прямоугольной системе координат
    /// </summary>
    /// <param name="a">Точка А</param>
    /// <param name="b">Точка B</param>
    /// <returns>Растояние, не может быть меньше или равное нулю</returns>
    public static double Distance(this Point a, Point b) => distance(a.X, a.Y, b.X, b.Y);
    /// <summary>
    /// Растояние между точками <paramref name="a"/> и <paramref name="b"/> на прямоугольной системе координат
    /// </summary>
    /// <param name="a">Точка А</param>
    /// <param name="b">Точка B</param>
    /// <returns>Растояние, не может быть меньше или равное нулю</returns>
    public static double Distance(this System.Drawing.Point a, System.Drawing.Point b) => distance(a.X, a.Y, b.X, b.Y);
    /// <summary>
    /// Растояние между точками <paramref name="a"/> и <paramref name="b"/> на прямоугольной системе координат
    /// </summary>
    /// <param name="a">Точка А</param>
    /// <param name="b">Точка B</param>
    /// <returns>Растояние, не может быть меньше или равное нулю</returns>
    public static float Distance(this System.Drawing.PointF a, System.Drawing.PointF b) => Convert.ToSingle(distance(a.X, a.Y, b.X, b.Y));


}
