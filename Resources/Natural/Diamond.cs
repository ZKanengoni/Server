namespace Server
{
    class Diamond: Resource
    {
        public Diamond(int newCount): base(newCount)
        {
            resourceType = "Diamond";
            classType = this;
        }
    }
}