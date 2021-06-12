namespace Server
{
    class Dispenser: Resource
    {
        public Dispenser(int newCount): base(newCount)
        {
            resourceType = "Dispenser";
            classType = this;
        }
    }
}