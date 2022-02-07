using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using AnimeGifBot.Models;

namespace AnimeGifBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong!");
        }
        [Command("gif")]
        public async Task Gif()
        {
            Random random = new Random();
            string tenorKey = "UZTJ7GN8AOF6";
            string url = $"https://g.tenor.com/v1/search?q=anime&key={tenorKey}&limit=8";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                    using (HttpContent content = response.Content)
                    {
                        var data = await content.ReadAsStringAsync();
                        //Parse your data into a object.
                        var dataObj = JObject.Parse(data);
                        //Then create a new instance of PokeItem, and string interpolate your name property to your JSON object.
                        //Which will convert it to a string, since each property value is a instance of JToken.
                        IList<JToken> results = dataObj["results"].Children().ToList();

                        // serialize JSON results into .NET objects
                        IList<GifUrls> searchResults = new List<GifUrls>();
                        foreach (JToken result in results)
                        {
                            // JToken.ToObject is a helper method that uses JsonSerializer internally
                            GifUrls searchResult = result.ToObject<GifUrls>();
                            searchResults.Add(searchResult);
                            
                        
                         
                        }
                        await ReplyAsync(searchResults[random.Next(0, searchResults.Count - 1)].Url);
                        //Log your pokeItem's name to the Console.


                    }
                }
            }
            
           
            
            
        }
        
    }
}
