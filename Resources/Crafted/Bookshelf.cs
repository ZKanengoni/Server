namespace Server
{
    class Bookshelf: Resource
    {
        public Bookshelf(int newCount): base(newCount)
        {
            resourceType = "Bookshelf";
            classType = this;
        }
    }
}