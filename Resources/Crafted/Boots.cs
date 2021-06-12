namespace Server
{
    class Boots: Resource
    {
        public Boots(int newCount): base(newCount)
        {
            resourceType = "Boots";
            classType = this;
        }
    }
}