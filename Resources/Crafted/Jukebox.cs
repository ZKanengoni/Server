namespace Server
{
    class Jukebox: Resource
    {
        public Jukebox(int newCount): base(newCount)
        {
            resourceType = "Jukebox";
            classType = this;
        }
    }
}