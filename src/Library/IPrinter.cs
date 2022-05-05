using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Se eliminó la clase AllInOnePrinter, que violaba el SRP debido a que imprimía recetas de dos formas distintas,
    /// y en cambio se creó la interfaz "IPrinter", la cual emplea el patrón Polymorphism debido a que es implementada por
    /// dos clases distintas, cada una con la responsabilidad de imprimir de una de las formas que se encontraban previamente
    /// en AllInOnePrinter.
    /// </summary>
    public interface IPrinter
    {
        public void PrintRecipe(Recipe recipe);
    }
}