using Discord;
using Discord.Net;
using Discord.WebSocket;
using Discord.Commands;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.IO;

namespace HoltBot.Modules
{
    // for commands to be available, and have the Context passed to them, we must inherit ModuleBase
    public class Commands : ModuleBase
    {
        
        [Command("Captain Holt")]
        [Alias("hello", "Holt")]
        public async Task HoltTalk()
        {
            // initialize empty string builder for reply
            var sb = new StringBuilder();

            // get user info from the Context
            var user = Context.User;

            string[] quotes = System.IO.File.ReadAllLines("C:\\Users\\chyha\\HoltBot\\Modules\\Quotes.txt");

            Random rand = new Random();
            int randomIndex = rand.Next(0, quotes.Length);
            
            // build out the reply
            sb.AppendLine(quotes[randomIndex]);

            // send simple string reply
            await ReplyAsync(sb.ToString());
        }
    }
}