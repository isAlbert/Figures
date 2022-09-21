namespace Figures.Interfaces;

/// <summary>
/// Определяет метод, который реализуется типом значения или классом для создания метода с целью определения периметра.
/// </summary>
public interface IPerimeterable
{
    /// <summary>
    /// Расчитывает весь контур фигуры
    /// </summary>
    /// <returns>Сумма всех сторон</returns>
    double GetPerimeter();
}
