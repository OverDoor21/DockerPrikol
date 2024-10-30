using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;

namespace Client.Console
{
    public class Commands
    {
        public static void SendMessageToServer()
        {
                var message = AnsiConsole.Ask<string>("Enter your message: ");
                // send message to server
        }

        public static void Settings()
        {

        }

        public static void Exit()
        {

        }
    }


}