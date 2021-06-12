namespace Server
{
    class Grass: Resource
    {
        public Grass(int newCount): base(newCount)
        {
            resourceType = "Grass";
            classType = this;
        }
    }
}