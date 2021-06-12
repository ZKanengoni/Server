namespace Server
{
    class Lava: Resource
    {
        public Lava(int newCount): base(newCount)
        {
            resourceType = "Lava";
            classType = this;
        }
    }
}