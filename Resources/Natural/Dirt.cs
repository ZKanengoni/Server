namespace Server
{
    class Dirt: Resource
    {
        public Dirt(int newCount): base(newCount)
        {
            resourceType = "Dirt";
            classType = this;
        }
    }    
}