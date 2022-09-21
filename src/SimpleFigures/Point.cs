using Figures.Interfaces;

namespace Figures.SimpleFigures;

/// <summary>
/// Точка в прямоугольной системе координат
/// </summary>
/// <param name="X">X</param>
/// <param name="Y">Y</param>
public readonly record struct Point(double X, double Y) : IFigure
{
    /// <summary>
    /// Площадь
    /// </summary>
    /// <returns>0</returns>
    public double GetArea() => 0;
    /// <summary>
    /// Периметр
    /// </summary>
    /// <returns>0</returns>
    public double GetPerimeter() => 0;
}

