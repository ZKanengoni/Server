namespace Server
{
    class IronVein: Resource
    {
        public IronVein(int newCount): base(newCount)
        {
            resourceType = "Iron Vein";
            classType = this;
        }
    }
}