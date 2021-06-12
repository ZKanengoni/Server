namespace Server
{
    class Chest: Resource
    {
        public Chest(int newCount): base(newCount)
        {
            resourceType = "Chest";
            classType = this;
        }
    }
}