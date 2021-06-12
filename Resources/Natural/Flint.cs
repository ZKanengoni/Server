namespace Server
{
     class Flint: Resource
    {
        public Flint(int newCount): base(newCount)
        {
            resourceType = "Flint";
            classType = this;
        }
    }
}