namespace Server
{
    class Brick: Resource
    {
        public Brick(int newCount): base(newCount)
        {
            resourceType = "Brick";
            classType = this;
        }
    }
}