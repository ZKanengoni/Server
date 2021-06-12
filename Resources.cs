using System;

namespace Server
{
   abstract class Resource
    {
        private int count;

        protected string resourceType;

        protected static Resource classType;

        public int Count 
        {
            get 
            {
                return count;
            }
            set 
            {
                if(count < 0) 
                    count = 0;
                else
                    count = value;
            }
        }

        public string ResourceType
        {
            get 
            {
                return resourceType;
            }
        }

        public Resource()
        {
            count = 0;
        }

        public Resource(int newCount)
        {
            count = newCount;
        }

        public void use(int amount) 
        {
            if(count - amount >= 0)
            {
                count -= amount;
                Console.WriteLine("{0} was used to craft", resourceType);
                Console.WriteLine("You have {0} block/s of {1} left", count, resourceType);
            } else
                Console.WriteLine("Sorry you do not have enough {0}", resourceType);
        }

        public static Resource Get() 
        {
            return classType;
        }
        
        
    }
}