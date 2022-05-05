using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library 
{
    /// <summary>
    /// Esta clase imprime recetas por medio de la consola.
    /// Cumple con el principio SRP porque solo tiene la responsabilidad mencionada previamente.
    /// </summary>
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}