namespace Server
{
    class Gunpowder: Resource
    {
        public Gunpowder(int newCount): base(newCount)
        {
            resourceType = "Gunpowder";
            classType = this;
        }
    }
}