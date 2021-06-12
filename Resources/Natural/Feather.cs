namespace Server
{
    class Feather: Resource
    {
        public Feather(int newCount): base(newCount)
        {
            resourceType = "Feather";
            classType = this;
        }
    }
}