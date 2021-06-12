using System;

namespace Server
{
    class CobbleStone: Resource, Smelt
    {
        public CobbleStone(int newCount): base(newCount)
        {
            resourceType = "Cobble Stone";
            classType = this;
        }

        public Resource Smelt(int amount)
        {
            Count -= amount;
            Console.WriteLine("{0} {1} was/were smelted to make {2} brick/s.", amount, resourceType, amount);
            return new Stone(amount);
        }
    }
}