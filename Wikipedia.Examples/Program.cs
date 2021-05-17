using System;
using System.Threading.Tasks;
using Genbox.Wikipedia.Enums;
using Genbox.Wikipedia.Objects;

namespace Genbox.Wikipedia.Examples
{
    internal class Program
    {
        private static async Task Main()
        {
            //Default language is English
            WikipediaClient client = new WikipediaClient();

            //Use HTTPS instead of HTTP
            client.UseTls = true;

            //We would like 5 results
            client.Limit = 5;

            //We would like to search inside the articles
            client.What = What.Text;


            const string searchText = "Elon_Musk";
            PageResult results = await client.GetPageAsync(searchText);

            Console.WriteLine("Searching for {0}:{1}", searchText, Environment.NewLine);
            Console.WriteLine("Found " + results.Pages.Count+ " English results:");
            Console.WriteLine(results.Normalized.From);
            Console.WriteLine(results.Normalized.To);

            foreach (Page s in results.Pages)
            {
                Console.WriteLine(s.Title);
                Console.WriteLine(s.PageID);
                Console.WriteLine(s.NS);
                Console.WriteLine(s.Extract);
            }

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
