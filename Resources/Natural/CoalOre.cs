namespace Server
{
    class CoalOre: Resource
    {
        public CoalOre(int newCount): base(newCount)
        {
            resourceType = "Coal Ore";
            classType = this;
        }
    }
}