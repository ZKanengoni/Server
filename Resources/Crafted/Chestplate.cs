namespace Server
{
    class Chestplate: Resource
    {
        public Chestplate(int newCount): base(newCount)
        {
            resourceType = "Chestplate";
            classType = this;
        }
    }
}