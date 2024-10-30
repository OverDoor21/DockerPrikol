using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;

namespace Client.Console
{
    abstract public class Menu
    {
        protected Commands commands = new();
    }

    public class MainMenu : Menu
    {
        public void Start(){
            AnsiConsole.WriteLine("[orange]Welcome to the [green]client side application[/]![/]");
            while(true){
                var input = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("What do you want to do?")
                        .PageSize(3)
                        .AddChoices(new[] {
                            "Send a message",
                            "Settings",
                            "Exit"
                        })
                );
                switch(input){
                    case "Send a message":
                        Commands.SendMessageToServer();
                        break;
                    case "Settings":
                        Commands.Settings();
                        break;
                    case "Exit":
                        Commands.Exit();
                        break;
                }
            }
        }
    }

    public class SettingsMenu : Menu
    {
        
    }
}