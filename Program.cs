using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Collections;


namespace Server
{
    class Program
    {
        public static HttpListener listener;
        public static string url = "http://localhost:8000/";
        public static int pageViews = 0;
        public static int requestCount = 0;

        public static async Task HandleIncomingConnections()
        {
            bool runServer = true;

            while(runServer) {
                HttpListenerContext ctx = await listener.GetContextAsync();

                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                Console.WriteLine("Request #:{0}", ++requestCount);
                Console.WriteLine(req.Url.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);
                Console.WriteLine();

                string path = req.Url.AbsolutePath;

                if((req.HttpMethod == "POST") && (path == "/shutdown")) {
                    path = "/index.html";
                    Console.WriteLine("Shutdown requested");
                    runServer = false;
                }

                if(path != "/favicon.ico")
                    pageViews += 1;
                try
                {
                    FileLoader myFileLoader = new FileLoader(path);
                    myFileLoader.ReadFile();

                    string disableSubmit = !runServer ? "disabled" : "";
                    byte[] data; 

                    if(myFileLoader.mimeType.IndexOf("text/html") >= 0)
                    {
                        string input = Encoding.UTF8.GetString(myFileLoader.data);                     

                       if(path == "/index.html")
                       {
                           data = Encoding.UTF8.GetBytes(IndexHtmlParser.Process(input));
                       } else if(path == "/pages/Craft.html") {
                           data = Encoding.UTF8.GetBytes(CraftParser.Process(input));
                       } else if(path == "/pages/Recipes.html") {
                           data = Encoding.UTF8.GetBytes(RecipesParser.Process(input));
                       } else {
                           throw new FileNotFoundException("No page");
                       }
                    }   
                    else
                        data = myFileLoader.data;

                    resp.ContentType = myFileLoader.mimeType;
                    resp.ContentEncoding = Encoding.UTF8;
                    resp.ContentLength64 = data.LongLength;
                    await resp.OutputStream.WriteAsync(data, 0, data.Length);
                    resp.Close();
                }
                catch 
                {
                    byte[] data;
                    data = Encoding.UTF8.GetBytes("<h2>A 404 error occured</h2>");
                    resp.ContentType = "text/html";
                    resp.ContentEncoding = Encoding.UTF8;
                    resp.ContentLength64 = data.LongLength;
                    resp.StatusCode = 404;


                    await resp.OutputStream.WriteAsync(data, 0, data.Length);
                }
                
                
            }
        }
   
        static void Main(string[] args) {

            Inventory inventory = new Inventory();
            // ArrayList array = inventory.Items;

            // RecipeBook.Populate();
           
            // Console.WriteLine(RecipeBook.Recipes);
            //  ArrayList records = Database.ReadRecipes();

            // Console.WriteLine(records);

            // foreach (Tuple<string, string[,]> curTuple in records)
            // {
            //     Console.WriteLine(curTuple.Item2[2, 1]);
            // }

            // foreach (Recipe curRecipe in RecipeBook.Recipes)
            // {
            //     Console.WriteLine("recipe is " + curRecipe.Result.ResourceType);
            // }

            // Console.WriteLine(Inventory.GetClass("Arrow").ResourceType);
            // Console.WriteLine(Inventory.GetCount("Arrow"));
            // Console.WriteLine(Inventory.GetImageUrl("Arrow"));
            // Console.WriteLine(Inventory.GetClass("Bow").ResourceType);
            //  Console.WriteLine(Inventory.GetCount("Bow"));
            //  Console.WriteLine(Inventory.GetImageUrl("Bow"));
            // Console.WriteLine(Inventory.GetClass("Brick").ResourceType);
            //  Console.WriteLine(Inventory.GetCount("Brick"));
            //  Console.WriteLine(Inventory.GetImageUrl("Brick"));
            // Console.WriteLine(Inventory.GetClass("Bucket").ResourceType);
            //  Console.WriteLine(Inventory.GetCount("Bucket"));
            //  Console.WriteLine(Inventory.GetImageUrl("Bucket"));

            // Console.WriteLine(Inventory)
            RecipeBook.Populate();  
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            Console.WriteLine("Listening for connections on {0}", url);
            Task listenTask = HandleIncomingConnections();
            listenTask.GetAwaiter().GetResult();
            listener.Close();
        }
    }

}
