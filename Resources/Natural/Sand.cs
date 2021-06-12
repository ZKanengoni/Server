using System;

namespace Server
{
    class Sand: Resource
    {
        public Sand(int newCount): base(newCount)
        {
            resourceType = "Sand";
            classType = this;
        }

        
        public Resource Smelt(int amount)
        {
            Count -= amount;
                Console.WriteLine("{0} {1} was/were smelted to make {2} brick/s.", amount, resourceType, amount);
                return new Glass(amount);
        }
    }
}