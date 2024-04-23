using Client.Console;
using Spectre.Console;

namespace Client {
    
    class Program {
        public static Menu menu = new();
        static HttpClientHandler clientHandler = new();
        static readonly HttpClient client = new HttpClient(clientHandler);
        public static void Main(string[] args)
        {
            menu.Start();
        }
    }
}