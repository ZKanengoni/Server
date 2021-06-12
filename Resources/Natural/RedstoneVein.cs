namespace Server
{
    class RedstoneVein: Resource
    {
        public RedstoneVein(int newCount): base(newCount)
        {
            resourceType = "Redstone Vein";
            classType = this;
        }
    }
}