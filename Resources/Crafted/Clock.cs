namespace Server
{
    class Clock: Resource
    {
        public Clock(int newCount): base(newCount)
        {
            resourceType = "Clock";
            classType = this;
        }
    }
}