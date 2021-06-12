using System;
using System.Collections.Generic;

namespace Server
{
    class Recipe
    {
        private Resource[,] inputs;
        private Crafted result;

        public Recipe(Crafted newResult, Resource[,] newInputs)
        {
            inputs = newInputs;
            result = newResult;
            result.SetRecipe(this);
        }

        public Resource[,] Inputs
        {
            get 
            {
                return inputs;
            }
        }

        public Resource Result
        {
            get
            {
                return (Resource)result;
            }
        }
    }
}