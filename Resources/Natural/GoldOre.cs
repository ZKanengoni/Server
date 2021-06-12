using System;

namespace Server
{
    class GoldOre: Resource
    {
        public GoldOre(int newCount): base(newCount)
        {
            resourceType = "Gold Ore";
            classType = this;
        }

        public Resource Smelt(int amount)
        {
            Count -= amount;
            Console.WriteLine("{0} {1} was/were smelted to make {2} brick/s.", amount, resourceType, amount);
            return new GoldIngot(amount);
        }
    }
}