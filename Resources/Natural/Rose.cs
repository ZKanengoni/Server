namespace Server
{
    class Rose: Resource
    {
        public Rose(int newCount): base(newCount)
        {
            resourceType = "Rose";
            classType = this;
        }
    }
}