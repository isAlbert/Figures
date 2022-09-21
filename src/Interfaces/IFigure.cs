using System;
using System.Runtime.CompilerServices;

namespace Figures.Interfaces
{
    /// <summary>
    /// Определяет общий интерфейс для фигур, который должн реализовывать <see cref="IPerimeterable"/> и <see cref="IAreal"/>
    /// </summary>
    public interface IFigure : IPerimeterable, IAreal
    {
    }
}
