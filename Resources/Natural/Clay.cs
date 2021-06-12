using System;

namespace Server
{
    class Clay: Resource, Smelt
    {
        public Clay(int newCount): base(newCount)
        {
            resourceType = "Clay";
            classType = this;
        }

        public Resource Smelt(int amount)
        {
            Count -= amount;
            Console.WriteLine("{0} {1} was/were smelted to make {2} brick/s.", amount, resourceType, amount);
            return new Brick(amount);
        }
    }
}