namespace Server
{
    class CrackedNetherBricks: Resource
    {
        public CrackedNetherBricks(int newCount): base(newCount)
        {
            resourceType = "Cracked Nether Brick";
            classType = this;
        }
    }
}