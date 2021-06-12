namespace Server
{
    class Helmet: Resource
    {
        public Helmet(int newCount): base(newCount)
        {
            resourceType = "Helmet";
            classType = this;
        }
    }
}