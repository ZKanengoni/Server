namespace Server
{
    class TNT: Resource
    {
        public TNT(int newCount): base(newCount)
        {
            resourceType = "TNT";
            classType = this;
        }
    }
}