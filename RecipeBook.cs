using System;
using System.Collections;

namespace Server
{
    class RecipeBook
    {
        private static ArrayList recipes = new ArrayList();
        private static ArrayList imgUrls = new ArrayList();

        public static void Populate()
        {
            ArrayList records = Database.ReadRecipes();

            foreach (Tuple<string, string[,]> curTuple in records)
            {
                Recipe curRecipe = new Recipe((Crafted) Inventory.GetClass(curTuple.Item1), new Resource[3, 3]
                {{Inventory.GetClass(curTuple.Item2[0, 0]),Inventory.GetClass(curTuple.Item2[0, 1]),Inventory.GetClass(curTuple.Item2[0, 2])},
                {Inventory.GetClass(curTuple.Item2[1, 0]),Inventory.GetClass(curTuple.Item2[1, 1]),Inventory.GetClass(curTuple.Item2[1, 2])},
                {Inventory.GetClass(curTuple.Item2[2, 0]),Inventory.GetClass(curTuple.Item2[2, 1]),Inventory.GetClass(curTuple.Item2[2, 2])}});

                recipes.Add(curRecipe);
            }
        }
                  

        public static ArrayList Recipes
        {
            get
            {
                return recipes;
            }
        }
    }
}
