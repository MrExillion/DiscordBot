using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using DiscordBotNo1;
using Discord.WebSocket;

namespace DiscordBotNo1.Modules
{
    class VoiceEvents : ModuleBase<SocketCommandContext>
    {
        /*private DiscordSocketClient _client;
        
        private void OnJoin()
        {
            _client.UserJoined += async (s, e) =>
            {
                var channel = e.Server.FindChannels("general").FirstOrDefault();
                var user = e.User.Name;
                await channel.SendMessage(string.Format("@" + user + " has joined!"));
            };
        }
       
        private  voiceChannel = _client.FindServers("Music Bot Server").FirstOrDefault().VoiceChannels.FirstOrDefault(); // Finds the first VoiceChannel on the server 'Music Bot Server'

        var _vClient = await _client.GetService<AudioService>() // We use GetService to find the AudioService that we installed earlier. In previous versions, this was equivelent to _client.Audio()
                .Join(voiceChannel); // Join the Voice Channel, and return the IAudioClient.
 */


    }
}
