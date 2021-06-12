namespace Server
{
    class Arrow: Resource, Crafted
    {
        public Recipe recipe;
        public Arrow(int newCount): base(newCount) 
        {
            resourceType = "Arrow";
            classType = this;
        }

        public void SetRecipe(Recipe newRecipe)
        {
            recipe = newRecipe;
        }

        public Recipe GetRecipe()
        {
            return recipe;
        }
    }
}