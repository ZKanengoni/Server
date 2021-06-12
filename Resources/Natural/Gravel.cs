namespace Server
{
    class Gravel: Resource
    {
        public Gravel(int newCount): base(newCount)
        {
            resourceType = "Gravel";
            classType = this;
        }
    }
}