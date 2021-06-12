namespace Server
{
    class Glass: Resource
    {
        public Glass(int newCount): base(newCount)
        {
            resourceType = "Glass";
            classType = this;
        }
    }
}