namespace Server
{
    class Ladder: Resource
    {
        public Ladder(int newCount): base(newCount)
        {
            resourceType = "Ladder";
            classType = this;
        }
    }
}