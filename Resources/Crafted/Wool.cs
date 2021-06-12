namespace Server
{
    class Wool: Resource
    {
        public Wool(int newCount): base(newCount)
        {
            resourceType = "Wool";
            classType = this;
        }
    }
}