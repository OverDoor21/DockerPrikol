using Client.Console;
using Spectre.Console;

namespace Client {
    
    class Program {
        public static Senter senter = new();
        static HttpClientHandler clientHandler = new();
        static readonly HttpClient client = new HttpClient(clientHandler);
        public static void Main(string[] args)
        {
            //senter.Start();
        }
    }
}