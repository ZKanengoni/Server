namespace Server
{
    class WoodenPlank: Resource
    {
        public WoodenPlank(int newCount): base(newCount)
        {
            resourceType = "Wooden Plank";
            classType = this;
        }
    }
}