using Discord;
using Discord.Commands;
using Discord.Audio;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Discord.WebSocket;
using System.Diagnostics;
using System.IO;

namespace DiscordBotNo1.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {

        private readonly ConcurrentDictionary<ulong, IAudioClient> ConnectedChannels = new ConcurrentDictionary<ulong, IAudioClient>();

        [Command("Hello")]
        public async Task HelloWorld()
        {
            await Context.Channel.SendMessageAsync("Hello " + Context.User.Mention);
            

        }
        [Command("Help")]
        public async Task Help()
        {
            await Context.Channel.SendMessageAsync("``` HELP!" + "\n\n" + " ..* ½Hello returns hello world"+ "\n\n" + " ..* ½Jonny1 returns a TTS Heeere is Jonny" + "\n\n" + " ..* ½rndJonnyQuote returns a random Quote from Johnny Bravo!" + "```");

        }

        [Command("Jonny1")]
        public async Task HeresJonny1()
        {
            await Context.Channel.SendMessageAsync("Heeere is Jonny!", isTTS:true);
            

        }

        [Command("rndJonnyQuote")]
        public async Task RandomQuote()
        {
            string[] quote = new string[69];
            quote[0] = "Yeah, whatever.";
            quote[1] = "Enough about you, let's talk about me, Johnny Bravo.";
            quote[2] = "I am Johnny Bravo, the one-man army!";
            quote[3] = "Wanna see me comb my hair, really fast?";
            quote[4] = "You look pretty...I look pretty...why don't we go home and stare at each other?";
            quote[5] = "Hey there smart momma, typin' recipes?";
            quote[6] = "I bet your name's Mickey, 'cause you're so fine. You're so fine you...";
            quote[7] = "But these letters! If Santa doesn't get these letters by tonight, I might not get all those free presents I asked for. And who ever heard of a Christmas without free stuff?";
            quote[8] = "Great Scott. My pizza-sense is tingling.";
            quote[9] = "Do the Monkey with me";
            quote[10] = "Mmm. Frosted Sugar Bits. The great taste of frosted sugar in bits.";
            quote[11] = "Sweet. Bring on the Danish chicks and cream soda.";
            quote[12] = "Now remember, I do my best work when I'm being worshiped as a god.";
            quote[13] = "Mama mia. That's a spicy meatball!.";
            quote[14] = "Hey, Santa, it's me, Johnny. Remember I'm the one that beat you up last year 'cause I thought you were a burglar?";
            quote[15] = "But enough about me... Let's talk about me. What do you think of me?";
            quote[16] = "Hey! How come he gets a banana?";
            quote[17] = "Hey Foxy Mama, You smell kinda pretty. Wanna smell me? Hoohah!";
            quote[18] = "I am investigating the disappearance of all the cats in the city... my living room is full of cats... that means... I'm hungry!";
            quote[19] = "Pops? It's me, Johnny! I couldn't find any donuts so I brought some tile grout!";
            quote[20] = "You know, you'd think a person with that much hate in her heart wouldn't gravitate towards the service industry.";
            quote[21] = "Dog... donkey... Well, they both start with the letter N...";
            quote[22] = "Check the pects. hoo ha hooah!";
            quote[23] = "Whoa! A castle in the sky! Just like in that fairy tale of Little Red Rumplestiltskin and the Three Bears and Gretel!";
            quote[24] = "Thank you, thank you very much.";
            quote[25] = "Whaddaya mean? I got the hamster wheel and the hamster food dispenser. (looks in the mirror) Oh no! She's turnin' me into a beautiful butterfly!";
            quote[26] = "Mister, I don't think you realize who you're talking to. I'm Johnny Bravo, the one-man army!";
            quote[27] = "Wanna watch my chest hair move in slow motion?";
            quote[28] = "Man, I'm pretty.";
            quote[29] = "Whoa, Mama!";
            quote[30] = "This won't end well.";
            quote[31] = "That's it, kid! I've had enough! I'm really sick of all this stuff! I don't want cookies, can't ya see? Now get your stuff away from me! I will not buy them, not one box. I will not eat them with a fox. I will not buy a peanut swirl. I will not buy it, little girl. I will not eat them on a boat, with a goat, or in a coat. You drive me nuts! It's really true! I've really had enough of you. You've got until the count of 3 to go away and let me be. 1--";
            quote[32] = "You know, that just might be crazy enough to work.";
            quote[33] = "If loving me is wrong, you don't wanna be right!";
            quote[34] = "Wait, who's that handsome guy? Hello, 911 emergency? There's a handsome guy in my house Oh, wait, cancel that. It's only me.";
            quote[35] = "Hey baby, can I be your natural selection?";
            quote[36] = "This is not good... for my hair!";
            quote[37] = "Right, what did I say?";
            quote[38] = "Aaaah. The great smell of pig!";
            quote[39] = "No Mama! I'm too old for the tiny pants!!";
            quote[40] = "Work?! (Screams in horror)";
            quote[41] = "(After a random story) And then my pants fell down.";
            quote[42] = "I came, I saw, I broke a hip.";
            quote[43] = "I may be late honey, but I'm looking good.";
            quote[44] = "He did it!";
            quote[45] = "Wiggy!";
            quote[46] = "4%? That's almost 5%";
            quote[47] = "20,000$? That`s almost 20,000$!";
            quote[48] = "Space. It's really, really, really, really big.";
            quote[49] = "If all you boys and girls will clap real hard, Johnny can make bail! Get me the Lawyer Fairy!";
            quote[50] = "Oh yeah! Who's the fairy, who's the fairy?! (Dances then quickly stops) You didn't see that, did you?";
            quote[51] = "Bad baby! Stop defying the laws of physics!";
            quote[52] = "Neighbor kid help! Witch's curse shrank me! Cops chasing me! I live with my mom! NO MOTIVATING GOALS!!!";
            quote[53] = "Some people look at Jerky an say, Why ? Me, I look at Jerky and I say Mmmmmmmm!Jerky!";
            quote[54] = "Jinkies? Isn't that a breakfast cereal?";
            quote[55] = "You know, that reminds me of a funny story. I was washing my head in the toilet the other day, when-- (After some time) So when the battery ran out, I realized I had my underwear over my head, the whole time! (Laughs) ";
            quote[56] = "Guess Carl didn't make it. I'll miss the little fella. (short pause) Oh, well. Can't mourn forever!";
            quote[57] = "Four feet good! Two feet bad!";
            quote[58] = "It's a beautiful day. But not as beautiful as me.";
            quote[59] = "(to Talky Tabitha) Now listen Raggedy Evil! You better stop..(Talky Tabitha throws Johnny against the wall)";
            quote[60] = "The Beach is that way.";
            quote[61] = "This is gettin' really old really fast.";
            quote[62] = "Hey babearilla, that a pretty eensie-weensie, teeny-weenie polka-dot thingy you got going there.";
            quote[63] = "Chomp, chomp, chomp, AAAAAAAAAAAHHHH!!!!!!!!!!!!! MY TOOTH! THE PAIN! THE HORRIBLE PAIN! Mmmmmmmm, creamy! Chomp, Chomp, Chomp, AAAAAAAAAAAHHHHH!!!!!!!! THE STABBING KNIVES OF PAIN! Hey! It's got nuts in it!";
            quote[64] = "AAAAAAAAAAHHHHH!!!!!!!!! MONSTERS FROM THE ID!!!!!!!!!!!!!!!!!!!!";
            quote[65] = "Oh, you will pay for this!";
            quote[66] = "Aw, man! That does it! This is my favorite shirt! I gotta go wash up!";
            quote[67] = "I am sickened... but curious.";
            quote[68] = "(When he doesn't understand someone) Now listen mister I ain't got no time for you to be talking Greek.";

            Random rnd = new Random();
            int rndQuote = rnd.Next(0, 68);
            await Context.Channel.SendMessageAsync(quote[rndQuote], isTTS: true);
        }


        [Command("join")]
        public async Task JoinChannel(IVoiceChannel channel = null)
        {
            var msg = Context.Message;
            // Get the audio channel
            channel = channel ?? (msg.Author as IGuildUser)?.VoiceChannel;
            if (channel == null) { await msg.Channel.SendMessageAsync("User must be in a voice channel, or a voice channel must be passed as an argument."); return; }

            // For the next step with transmitting audio, you would want to pass this Audio Client in to a service.
            var audioClient = await channel.ConnectAsync();
            Debug.Write("Joined and awaits the SendAsync");
            await SendAsync(audioClient, "C:/Users/MrExillion/Documents/Visual Studio 2015/Projects/DiscordBotNo1/DiscordBotNo1/bin/Release/05 New Dalaran.m4a");
            Debug.Write("Joined and awaited the SendAsync");
            //CreateStream("C:/Users/MrExillion/Documents/Visual Studio 2015/Projects/DiscordBotNo1/DiscordBotNo1/bin/Release/05 New Dalaran.m4a");
        }
        public async Task SendAudioAsync(IGuild guild, IMessageChannel channel, string path)
        {
            // Your task: Get a full path to the file if the value of 'path' is only a filename.
            if (!File.Exists(path))
            {
                await channel.SendMessageAsync("File does not exist.");
                return;
            }
            IAudioClient client;

            if (ConnectedChannels.TryGetValue(guild.Id, out client))
            {
                //await Log(LogSeverity.Debug, $"Starting playback of {path} in {guild.Name}");
                using (var output = CreateStream(path).StandardOutput.BaseStream)
                using (var stream = client.CreatePCMStream(AudioApplication.Music))
                {
                    try { await output.CopyToAsync(stream); }
                    finally { await stream.FlushAsync(); }
                }
            }
        }
            private Process CreateStream(string path)
            {
                var ffmpeg = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = $"-i {path} -ac 2 -f s16le -ar 48000 pipe:1",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                };
                return Process.Start(ffmpeg);
            }
            private async Task SendAsync(IAudioClient client, string path)
            {
                // Create FFmpeg using the previous example
                var ffmpeg = CreateStream(path);
                var output = ffmpeg.StandardOutput.BaseStream;
                var discord = client.CreatePCMStream(AudioApplication.Mixed);
                Debug.Write(ffmpeg);
                await output.CopyToAsync(discord);
                await discord.FlushAsync();
            }

    }

}
