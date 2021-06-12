using System;
using System.Collections;

namespace Server
{
    class Inventory
    {
        private static ArrayList items = new ArrayList(); 

        public Inventory()
        {
           ArrayList data = Database.ReadResources();
          
           foreach (Tuple<string, int, string> curTuple in data)
           {
               Resource newResource;
               switch (curTuple.Item1)
               {
                    case "Arrow":
                        newResource = new Arrow(curTuple.Item2);
                        break;
                    case "Bow":
                        newResource = new Bow(curTuple.Item2);
                        break;
                    case "Brick":
                        newResource  = new Brick(curTuple.Item2);
                        break;
                    case "Bucket":
                        newResource = new Bucket(curTuple.Item2);
                        break;
                    case "Bed":
                        newResource = new Bed(curTuple.Item2);
                        break;
                     case "Wool":
                        newResource = new Wool(curTuple.Item2);
                        break;
                    case "Wooden Plank":
                        newResource = new WoodenPlank(curTuple.Item2);
                        break;
                    case "":
                        newResource = new Empty(curTuple.Item2);
                        break; 
                    default:
                        newResource = new Empty(curTuple.Item2);
                        break;
               }
                items.Add(newResource);
           }
        }

        public static ArrayList Items
        {
            get
            {
                return items;
            }
        }

        public static Resource GetClass(string index)
        {
            foreach (Resource curItem in items)
            {
                if(curItem.ResourceType == index)
                    return curItem;
            }

            // return null; 
            return null;
        }

        public static int GetCount(string index)
        {
            foreach (Resource curItem in items)
            {
                if(curItem.ResourceType == index)
                    return curItem.Count;
            }

            return -1;
        }

    }
}