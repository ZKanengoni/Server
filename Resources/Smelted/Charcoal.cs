namespace Server
{
    class Charcoal: Resource
    {
        public Charcoal(int newCount): base(newCount)
        {
            resourceType = "Charcoal";
            classType = this;
        }
    }
}