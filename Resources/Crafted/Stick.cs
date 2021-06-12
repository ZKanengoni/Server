namespace Server
{
    class Stick: Resource
    {
        public Stick(int newCount): base(newCount)
        {
            resourceType = "Stick";
            classType = this;
        }
    }
}