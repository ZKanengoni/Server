namespace Server
{
    class Air: Resource
    {
        public Air(int newCount, string imageUrl): base(newCount)
        {
            resourceType = "Air";
            imageUrl = "";
            classType = this;
        }
    }
}