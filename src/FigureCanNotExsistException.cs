namespace Figures
{
    /// <summary>
    /// Представляет ошибку, если не возможно создать фигуру/>
    /// </summary>
    public class FigureCanNotExsistException : Exception
    {
        /// <summary>
        /// Выбрасывает исключение если улосиве <paramref name="condition"/> <see langword="true"/>
        /// </summary>
        /// <param name="condition">Условие</param>
        /// <exception cref="FigureCanNotExsistException"></exception>
        public static void ThrowIfTrue(bool condition)
        {
            if (condition)
            {
                throw new FigureCanNotExsistException();
            }
        }
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="FigureCanNotExsistException" /> с указанным сообщением об ошибке.
        /// </summary>
        /// <param name="message">Сообщение, описывающее ошибку.</param>
        public FigureCanNotExsistException(string? message = null)
            : base($"No such figure exists. {message ?? ""}")
        {
        }
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="FigureCanNotExsistException" />.
        /// </summary>
        public FigureCanNotExsistException() : this(null) 
        {
        }

    }
}
