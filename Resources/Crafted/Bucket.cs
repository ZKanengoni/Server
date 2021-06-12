namespace Server
{
    class Bucket: Resource
    {
        public Bucket(int newCount): base(newCount)
        {
            resourceType = "Bucket";
            classType = this;
        }
    }
}