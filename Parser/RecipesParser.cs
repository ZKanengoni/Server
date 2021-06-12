using System;
using System.IO;
using System.Text;
using HtmlAgilityPack;
using System.Collections;

namespace Server
{
    class RecipesParser
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
                }
                
                if(count > 0)
                    throw new FileNotFoundException("Corrupt file!");
            }

            HtmlNode recipesNode  = htmlDoc.GetElementbyId("recipes");

            recipesNode.RemoveAllChildren();

            ArrayList newItems = RecipeBook.Recipes;

            // string[] cards = { "<a href=\"\" class=\"card-outline recipe\"><div class=\"input\"><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div></div><div class=\"output\"><div class=\"block\"></div></div></a>"};

            
            foreach (Recipe currItem in newItems)
            {
                    HtmlNode newNode = HtmlNode.CreateNode($"<a href=\"\" class=\"card-outline recipe\"><div class=\"input\"><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div><div class=\"block\"></div></div><div class=\"output\"><div class=\"block\"></div></div></a>");
                    
                    recipesNode.AppendChild(newNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}