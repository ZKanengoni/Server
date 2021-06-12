namespace Server
{   
    class Bed: Resource, Crafted
    {
        private Recipe recipe;
        public Bed(int newCount): base(newCount)
        {
            resourceType = "Bed";
            classType = this;
        }    

        public Recipe GetRecipe()
        {
            return recipe;
        }

        public void SetRecipe(Recipe newRecipe)
        {
            recipe = newRecipe;
        }
    }
} 