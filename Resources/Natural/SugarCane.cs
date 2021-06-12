namespace Server
{
    class SugarCane: Resource
    {
        public SugarCane(int newCount): base(newCount)
        {
            resourceType = "Sugar Cane";
            classType = this;
        }
    }
}