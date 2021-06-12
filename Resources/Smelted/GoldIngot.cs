namespace Server
{
    class GoldIngot: Resource
    {
        public GoldIngot(int newCount): base(newCount)
        {
            resourceType = "Gold Ingot";
            classType = this;
        }
    }
}