using System;

namespace Server
{
    class NetherBrick: Resource
    {
        public NetherBrick(int newCount): base(newCount)
        {
            resourceType = "Nether Brick";
            classType = this;
        }

        public Resource Smelt(int amount)
        {
            Count -= amount;
            Console.WriteLine("{0} {1} was/were smelted to make {2} Cracked Nether Brick/s.", amount, resourceType, amount);
            return new CrackedNetherBricks(amount);
        }
    }
}