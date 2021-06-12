namespace Server
{
    class WoodenDoor: Resource
    {
        public WoodenDoor(int newCount): base(newCount)
        {
            resourceType = "Wooden Door";
            classType = this;
        }
    }
}