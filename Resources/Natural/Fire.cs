namespace Server
{
    class Fire: Resource
    {
        public Fire(int newCount): base(newCount)
        {
            resourceType = "Fire";
            classType = this;
        }
    }
}