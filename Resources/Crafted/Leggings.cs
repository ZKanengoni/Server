namespace Server
{
    class Leggings: Resource
    {
        public Leggings(int newCount): base(newCount)
        {
            resourceType = "Leggings";
            classType = this;
        }
    }
}