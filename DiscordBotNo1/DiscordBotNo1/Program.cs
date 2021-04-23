using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using Discord.Net;
using Discord.Rest;
using Discord.Rpc;
using Discord.Webhook;

namespace DiscordBotNo1
{
    class Program
    {
        static void Main(string[] args) =>
           new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandHandler _handler;

        public async Task StartAsync()
        {
            
            _client = new DiscordSocketClient();
            new CommandHandler();

            var token = "MzU4Mzc1OTgwNzI2ODc4MjA4.DJ9_jQ.PWOU1DvDGrn52zAcm5l2AgJed_M";

            //Login and Connect
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            if(_handler == null)
            _handler = new CommandHandler();

            await _handler.InitializeAsync(_client);








            await Task.Delay(-1);
        }  


    }
}
