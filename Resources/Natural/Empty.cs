namespace Server
{
    class Empty: Resource
    {
        public Empty(int newCount): base(newCount)
        {
            resourceType = "Empty";
            classType = this;
        }
    }    
}