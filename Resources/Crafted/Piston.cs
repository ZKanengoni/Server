namespace Server
{
    class Piston: Resource
    {
        public Piston(int newCount): base(newCount)
        {
            resourceType = "Piston";
            classType = this;
        }
    }
}