namespace Server
{
    class Melon: Resource
    {
        public Melon(int newCount): base(newCount)
        {
            resourceType = "Melon";
            classType = this;
        }
    }
}