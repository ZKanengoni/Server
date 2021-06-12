namespace Server
{
    class GoldVein: Resource
    {
        public GoldVein(int newCount): base(newCount)
        {
            resourceType = "Gold Vein";
            classType = this;
        }
    }
}