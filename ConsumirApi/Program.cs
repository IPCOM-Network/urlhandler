using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumirApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length == 0)
            {
                EscribirLog("Por favor digite la dirección url");
                Console.WriteLine("Por favor digite la dirección url");
            }
            else
            {
                string argumentoContieneUrl = args[0];
                HttpClient client = await CallApi(argumentoContieneUrl);
            }
        }

        private static async Task<HttpClient> CallApi(string argumentoContieneUrl)
        {
            var client = new HttpClient();
            var urlConsumir = argumentoContieneUrl.Split(":")[1];
            //abc.exe  foo://example.com?id=12312312&xyz=21312
            urlConsumir = $"https:{urlConsumir}";
            Console.WriteLine($"Url a consumir: {urlConsumir}");
            var result = await client.GetStringAsync(urlConsumir);
            Console.WriteLine($"Response: {result}");
            EscribirLog(result);

            return client;
        }

        private static void EscribirLog(string result)
        {
            System.IO.Directory.CreateDirectory(@$"{AppDomain.CurrentDomain.BaseDirectory}\Logs");
            string fileName = @$"{AppDomain.CurrentDomain.BaseDirectory}\Logs\{DateTime.Now.Year}{DateTime.Now.Month.ToString().PadLeft(2, '0')}{DateTime.Now.Day.ToString().PadLeft(2, '0')}.txt";

            try
            {
                // Write the text to a new file named "WriteFile.txt".
                File.AppendAllText(fileName, DateTime.Now.ToString() + " --> " + result + Environment.NewLine);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }
    }
}
