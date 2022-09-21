using Figures.Interfaces;

namespace Figures.SimpleFigures;

/// <summary>
/// Отрезок на прямоугольной системе координат
/// </summary>
/// <param name="A">Точка начала отрезка</param>
/// <param name="B">Точка конца отрезка</param>
public readonly record struct Line(Point A, Point B) : IFigure
{
    /// <summary>
    /// Длина отрезка
    /// </summary>
    public double Length => A.Distance(B);
    /// <summary>
    /// Площадь отрезка
    /// </summary>
    /// <returns>0</returns>
    public double GetArea() => 0;
    /// <summary>
    /// Периметр отрезка
    /// </summary>
    /// <returns><see cref="Length"/> - длина отрезка</returns>
    public double GetPerimeter() => Length;
}
