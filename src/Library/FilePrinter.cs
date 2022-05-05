using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library 
{
    /// <summary>
    /// Esta clase imprime recetas por medio de file.
    /// Cumple con el principio SRP porque solo tiene la responsabilidad mencionada previamente.
    /// </summary>
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}