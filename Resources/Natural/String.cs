namespace Server
{
    class String: Resource
    {
        public String(int newCount): base(newCount)
        {
            resourceType = "String"; 
            classType = this;
        }
    }
}