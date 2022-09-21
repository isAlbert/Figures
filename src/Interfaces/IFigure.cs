using System;
using System.Runtime.CompilerServices;

namespace Figures.Interfaces
{
    /// <summary>
    /// Определяет фигуру, которая должна реализовывать <see cref="IPerimeterable"/> и <see cref="IAreal"/>
    /// </summary>
    public interface IFigure : IPerimeterable, IAreal
    {
    }
}