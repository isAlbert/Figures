namespace Figures.Interfaces
{
    /// <summary>
    /// Определяет метод,
    /// который реализуется типом значения или классом для создания метода с целью определения площади.
    /// </summary>
    public interface IAreal
    {
        /// <summary>
        /// Расчитывает площадь
        /// </summary>
        /// <returns>Площадь</returns>
        double GetArea();
    }
}