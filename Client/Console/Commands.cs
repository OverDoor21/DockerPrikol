using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;

namespace Client.Console
{
    abstract public class Commands
    {      
        public abstract void Execute();
    }

    public class SendMessage : Commands
    {
        public void SendMessageToServer()
        {
            var message = AnsiConsole.Ask<string>("Enter your message: ");
            // send message to server
        }
        public override void Execute()
        {
            
        }
    }

    public class Settings : Commands
    {
        public override void Execute()
        {
            
        }
    }

    public class Exit : Commands
    {
        public override void Execute()
        {
            
        }
    }
}