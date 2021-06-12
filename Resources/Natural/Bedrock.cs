namespace Server
{
    class Bedrock: Resource
    {
        public Bedrock(int newCount): base(newCount)
        {
            resourceType = "Bedrock";
            classType = this;
        }
    }    
}