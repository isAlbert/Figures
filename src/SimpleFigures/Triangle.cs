using Figures.Interfaces;

namespace Figures.SimpleFigures;
/// <summary>
/// Треугольник
/// </summary>
public record Triangle : IFigure
{
    /// <summary>
    /// Координаты точки А
    /// </summary>
    public Point A { get; init; }
    /// <summary>
    /// Координаты точки В
    /// </summary>
    public Point B { get; init; }
    /// <summary>
    /// Координаты точки C
    /// </summary>
    public Point C { get; init; }
    /// <summary>
    /// Сторона между точками А и В
    /// </summary>
    public Line SideAB => new(A, B);
    /// <summary>
    /// Cторона между точками В и С
    /// </summary>
    public Line SideBC => new(B, C);
    /// <summary>
    /// Cторона между точками С и A
    /// </summary>
    public Line SideCA => new(C, A);
    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    /// <returns><see langword="true"/> если есть угол в 90°, иначе <see langword="false"/></returns>
    public bool IsRectangular
    {
        get
        {
            var sideAB2 = SideAB.Length * SideAB.Length;
            var sideBC2 = SideBC.Length * SideBC.Length;
            var sideCA2 = SideCA.Length * SideCA.Length;

            return sideAB2 + sideBC2 == sideCA2
                || sideBC2 + sideCA2 == sideAB2
                || sideCA2 + sideAB2 == sideBC2;
        }
    }
    /// <summary>
    /// Является ли треугольник равнобедренным
    /// </summary>
    /// <returns><see langword="true"/> если есть две равные стороны, иначе <see langword="false"/></returns>
    /// <remarks>Если треугольник является равносторонним вернёт <see langword="true"/></remarks>
    public bool IsIsosceles
    {
        get
        {
            return SideAB.Length == SideBC.Length
                || SideAB.Length == SideCA.Length
                || SideBC.Length == SideCA.Length;
        }
    }

    /// <summary>
    /// Является ли треугольник равносторонним
    /// </summary>
    /// <returns><see langword="true"/> если все стороны равны, иначе <see langword="false"/></returns>
    public bool IsEquilateral
    {
        get
        {
            return SideAB.Length == SideBC.Length && SideAB.Length == SideCA.Length;
        }
    }

    /// <summary>
    /// Инициализирует треугольник с тремя точками в координатной системе X и Y
    /// </summary>
    /// <param name="a">Точка А</param>
    /// <param name="b">Точка В</param>
    /// <param name="c">Точка С</param>
    /// <exception cref="FigureCanNotExsistException">Возникает если <see cref="Triangle"/> с такими точками не существует.</exception>
    public Triangle(Point a, Point b, Point c)
    {
        FigureCanNotExsistException.ThrowIfTrue(!CanExists(a, b, c));

        (A, B, C) = (a, b, c);
    }
    private Triangle() { }
    /// <summary>
    /// Проверяет может ли существовать треугольник с точками <paramref name="a"/>, <paramref name="b"/> и <paramref name="c"/>
    /// </summary>
    /// <returns><see langword="true"/> если треугольник существует, иначе <see langword="false"/></returns>
    public static bool CanExists(Point a, Point b, Point c)
    {
        var sideAB = a.Distance(b);
        var sideBC = b.Distance(c);
        var sideCA = c.Distance(a);

        return sideAB > 0
            && sideBC > 0
            && sideCA > 0
            && sideAB + sideBC > sideCA
            && sideAB + sideCA > sideBC
            && sideBC + sideCA > sideAB;
    }
    /// <summary>
    /// Расчитывает площадь треугольника
    /// </summary>
    /// <returns>Площадь</returns>
    public double GetArea()
    {
        /*   Triangle Area with Points
         *           
         *      |x1 - x3 | y1 - y3 |
         *  A = |--------+---------|  
         *      |x2 - x3 | y2 - y3 |
         *      
         *  det(A) = (x1-x3)(y2-y3) - (y1-y3)(x2-x3)
         *  
         *  S(tr) = 1/2 * |det(A)|
         */
        var determinant = (A.X - C.X) * (B.Y - C.Y) - (A.Y - C.Y) * (B.X - C.X);
        return 0.5F * Math.Abs(determinant);
    }
    /// <summary>
    /// Расчитывает периметр треугольника
    /// </summary>
    /// <returns>Периметр</returns>
    public double GetPerimeter()
    {
        return SideAB.Length + SideBC.Length + SideCA.Length;
    }
}
