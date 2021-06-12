namespace Server
{
    class Water: Resource
    {
        public Water(int newCount): base(newCount)
        {
            resourceType = "Water";
            classType = this;
        }
    }
}