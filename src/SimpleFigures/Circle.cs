using Figures.Interfaces;

namespace Figures.SimpleFigures;
/// <summary>
/// Окружность в прямоугольной системе координат
/// </summary>
public record Circle : IFigure
{
    /// <summary>
    /// Центр окружности
    /// </summary>
    public Point Center { get; init; }
    /// <summary>
    /// Радиус окружности
    /// </summary>
    public double Radius { get; init; }
    /// <summary>
    /// Инициализирует объект <see cref="Circle"/> c центром <paramref name="center"/> и радиусом <paramref name="radius"/>
    /// </summary>
    /// <param name="center">Центр окружности</param>
    /// <param name="radius">Радиус окружности</param>
    /// <exception cref="FigureCanNotExsistException">Выбрасывается если <paramref name="radius"/> меньше или равен 0</exception>
    public Circle(Point center, double radius)
    {
        FigureCanNotExsistException.ThrowIfTrue(radius <= 0);

        Center = center;
        Radius = radius;
    }
    private Circle() { }
    /// <summary>
    /// Расчитывает площадь окружности
    /// </summary>
    /// <returns>Площадь</returns>
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    /// <summary>
    /// Расчитывает периметр окружности
    /// </summary>
    /// <returns>периметр</returns>
    public double GetPerimeter()
    {
        return MathF.PI * Radius * 2;
    }
}
