namespace Server
{
    class Bow: Resource
    {
        public Bow(int newCount): base(newCount)
        {
            resourceType = "Bow";
            classType = this;
        }
    }
}