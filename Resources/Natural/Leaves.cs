namespace Server
{
    class Leaves:Resource
    {
        public Leaves(int newCount): base(newCount)
        {
            resourceType = "Leaves";
            classType = this;
        }
    }
}