using System;

namespace Server
{
    class Stone: Resource
    {
        public Stone(int newCount): base(newCount)
        {
            resourceType = "Stone";
            classType = this;
        }

        public Resource Smelt(int amount)
        {
             Count -= amount;
                Console.WriteLine("{0} {1} was/were smelted to make {2} stone/s.", amount, resourceType, amount);
                return new SmoothStone(amount);
        }
    }
}