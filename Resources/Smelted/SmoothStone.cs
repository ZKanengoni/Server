namespace Server
{
    class SmoothStone: Resource
    {
        public SmoothStone(int newCount): base(newCount)
        {
            resourceType = "Smooth Stone";
            classType = this;
        }
    }

}