namespace Server
{
    class Sign: Resource
    {
        public Sign(int newCount): base(newCount)
        {
            resourceType = "Sign";
            classType = this;
        }
    }
}