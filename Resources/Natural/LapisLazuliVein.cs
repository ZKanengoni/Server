namespace Server
{
    class LapisLazuliVein: Resource
    {
        public LapisLazuliVein(int newCount): base(newCount)
        {
            resourceType = "Lapis Lazuli Vein";
            classType = this;
        }
    }
}