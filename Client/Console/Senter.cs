using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;


namespace Client.Console
{
    public class Senter
    {
        private bool IsRun;
        public int? input { get; set;}
        public Senter()
        {
            IsRun = true;
        }

        public void Start(){
            AnsiConsole.WriteLine("[orange]Welcome to the [green]client side application[/]![/]");
            while(IsRun){
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
            }
            }
    }
}