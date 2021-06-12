namespace Server
{
    class Redstone: Resource
    {
        public Redstone(int newCount): base(newCount)
        {
            resourceType = "Redstone";
            classType = this;
        }
    }
}