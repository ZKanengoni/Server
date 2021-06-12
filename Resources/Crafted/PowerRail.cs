namespace Server
{
    class PowerRail: Resource
    {
        public PowerRail(int newCount): base(newCount)
        {
            resourceType = "Power Rail";
            classType = this;
        }
    }
}