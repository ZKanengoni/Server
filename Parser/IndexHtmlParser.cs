using System;
using System.IO;
using System.Text;
using HtmlAgilityPack;
using System.Diagnostics;
using System.Collections;


namespace Server
{
    class IndexHtmlParser
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
                    Debug.WriteLine("Parse line:" + htmlParseError.Line);
                    Debug.WriteLine("Parse errors:" + htmlParseError.Reason);
                }
            
                if(count > 0)
                    throw new FileNotFoundException("Corrupt file!");
            }

            HtmlNode inventoryNode  = htmlDoc.GetElementbyId("inventory");

            inventoryNode.RemoveAllChildren();
    
            ArrayList newItems = Inventory.Items;


            foreach (Resource currentItem in newItems)
            {  
                    HtmlNode newNode = HtmlNode.CreateNode($"<div class=\"card card-item\"> <a href=\"\"><img src=\"\" alt=\"\" /></a><div class=\"card-content\"><a href=\"\"><h3>{currentItem.ResourceType}</h3></a><p></p><a href=\"#\"><span class=\"tag secondary\">#{currentItem.ResourceType}</span><span class=\"tag secondary tag-amount {(currentItem.Count > 5 ? "high" : "normal")}\">#{currentItem.Count}</span></a></div></div>");
                    inventoryNode.AppendChild(newNode);
            }          

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}