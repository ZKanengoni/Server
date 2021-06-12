using System;
using System.IO;
using System.Text;
using HtmlAgilityPack;

namespace Server
{
    class CraftParser
    {
        public static string Process(string input)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(input);

            if(htmlDoc.ParseErrors != null || htmlDoc.DocumentNode == null)
            {
                int count = 0;
                Console.WriteLine("Parse error occured");
                
                foreach(var htmlParseError in htmlDoc.ParseErrors)
                {
                    count++;
                    Console.WriteLine("Parse errors:" + htmlParseError.Reason);
                    Console.WriteLine(count);
                }
                
                if(count > 0)
                    throw new FileNotFoundException("Corrupt file!");
            }

            HtmlNode craftNode  = htmlDoc.GetElementbyId("craft");


            string[] cards = { "<div class=\"card-craft card-outline\"><div class=\"card-content\"><div class=\"text-center\"><img src=\"\" alt=\"\" /></div><h3>Lorem ipsum dolor sit amet consectetur</h3>Iste quasi corrupti error numquam. Suscipit expedita tempora distinctio, ullam veniam natus.<div class=\"tag\">#Rare</div><button class=\"btn btn-green btn-block\">Craft</button></div></div>"};

             foreach (string currentItem in cards)
            {  
                HtmlNode newNode = HtmlNode.CreateNode(currentItem);
                craftNode.AppendChild(newNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}