using System;

namespace Server
{
    class Wood: Resource, Smelt
    {
        public Wood(int newCount): base(newCount)
        {
            resourceType = "Wood";
            classType = this;
        }

        public Resource Smelt(int amount)
        {
            Count -= amount;
            Console.WriteLine("{0} {1} was/were smelted to make {2} charcoal/s.", amount, resourceType, amount);
            return new Charcoal(amount);
        }
    }
}