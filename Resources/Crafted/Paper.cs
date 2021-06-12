namespace Server
{
    class Paper: Resource
    {
        public Paper(int newCount): base(newCount)
        {
            resourceType = "Paper";
            classType = this;
        }
    }
}