namespace Server
{
    class Torch: Resource
    {
        public Torch(int newCount): base(newCount)
        {
            resourceType = "Torch";
            classType = this;
        }
    }
}