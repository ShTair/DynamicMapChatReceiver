using DynamicMapChatReceiver.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using JintEngine = Jint.Engine;

namespace DynamicMapChatReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Run(args[0]).Wait();
            }
            catch
            {
                Console.WriteLine("接続できませんでした");
                Task.Delay(TimeSpan.FromSeconds(10)).Wait();
            }
        }

        private static async Task Run(string url)
        {
            var baseUrl = new Uri(url);
            var configUrl = new Uri(baseUrl, "standalone/config.js");

            var configJs = await LoadStringAsync(configUrl.ToString());
            var engine = new JintEngine();
            engine.Execute(configJs);

            var urlObj = engine.Global.GetObject("config").url;
            var configurationUrl = new Uri(baseUrl, urlObj.configuration);
            var configurationJson = await LoadStringAsync(configurationUrl.ToString());
            var configuration = JsonConvert.DeserializeObject<ConfigurationModel>(configurationJson);

            string updateUrlFormat = ((string)urlObj.update).Replace("{world}", "{0}").Replace("{timestamp}", "{1}");

            var update = new UpdateModel { timestamp = 0 };
            while (true)
            {
                var updateUrl = new Uri(baseUrl, string.Format(updateUrlFormat, "Main", update.timestamp));
                var updateJson = await LoadStringAsync(updateUrl.ToString());
                update = JsonConvert.DeserializeObject<UpdateModel>(updateJson);

                foreach (var updateData in update.updates)
                {
                    switch (updateData.type)
                    {
                        case "tile": continue;
                        case "playerjoin":
                        case "playerquit":
                            Console.WriteLine($"[{DateTime.Now:dd HH:mm:ss}] {updateData.type} {updateData.playerName}");
                            break;
                        case "chat":
                            Console.WriteLine($"[{DateTime.Now:dd HH:mm:ss}] {updateData.playerName}({updateData.source}): {updateData.message}");
                            break;
                        default:
                            Console.WriteLine($"[{DateTime.Now:dd HH:mm:ss}] {updateData.type}");
                            break;
                    }
                }

                await Task.Delay(TimeSpan.FromMilliseconds(configuration.updaterate));
            }
        }

        private static async Task<string> LoadStringAsync(string url)
        {
            using (var hc = new HttpClient())
            {
                return await hc.GetStringAsync(url);
            }
        }
    }
}
