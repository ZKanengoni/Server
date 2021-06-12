namespace Server
{
    class Dandelion: Resource
    {
        public Dandelion(int newCount): base(newCount)
        {
            resourceType = "Dandelion";
            classType = this;
        }
    }
}