namespace Server
{
    class RedstoneDust: Resource
    {
        public RedstoneDust(int newCount): base(newCount)
        {
            resourceType = "Redstone Dust";
            classType = this;
        }
    }
}