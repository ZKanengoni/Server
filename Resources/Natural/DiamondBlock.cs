namespace Server
{
    class DiamondBlock: Resource
    {
        public DiamondBlock(int newCount): base(newCount)
        {
            resourceType = "Diamond Block";
            classType = this;
        }
    }
}