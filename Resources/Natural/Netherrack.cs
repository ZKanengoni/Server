using System;

namespace Server
{
    class Netherrack: Resource
    {
        public Netherrack(int newCount): base(newCount)
        {
            resourceType = "Netherrack";
            classType = this;
        }

        public Resource Smelt(int amount)
        {
            Count -= amount;
            Console.WriteLine("{0} {1} was/were smelted to make {2} brick/s.", amount, resourceType, amount);
            return new NetherBrick(amount);
        }
    }
}