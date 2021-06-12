namespace Server
{
    class GlowstoneVein: Resource
    {
        public GlowstoneVein(int newCount): base(newCount)
        {
            resourceType = "Glowstone Vein";
            classType = this;
        }
    }
}