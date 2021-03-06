﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Discord.Commands;
using HeadNonSub.Extensions;

namespace HeadNonSub.Clients.Discord.Commands {

    public class FakeChat : ModuleBase<SocketCommandContext> {

        // https://discordapp.com/developers/docs/resources/channel#embed-limits

        [Command("you suck")]
        [Alias("i hate you", "fuck you", "fuck off", "die")]
        [RequireContext(ContextType.Guild)]
        public Task YouSuckAsync() {

            List<string> responses = new List<string> {
                "i am poor :cry:",
                ":open_mouth: y tho",
                "I wonder how many racist things I can say before the mods ban me.",
                "I was being purposefully retarded",
                "listen here fucko",
                "oof",
                "PLS unban me from discord I am sorry for sending that stupid word art, also this song was spammed a lot in 2009",
                "1024 warned me i am leving this place",
                $"Alright, {Context.Guild.CurrentUser.Mention} has been warned for '**Being a useless person**'... wait, what?",
                "but its F E E D I N G T I M E",
                "Nani the FUCK?",
                "ok?"
            };

            ulong reply = ReplyAsync(responses.PickRandom()).Result.Id;

            UndoTracker.Track(Context.Guild.Id, Context.Channel.Id, Context.User.Id, Context.Message.Id, reply);
            return Task.CompletedTask;
        }

        [Command("you are great")]
        [Alias("i love you", "how are you", "nice to see you", "i like you")]
        [RequireContext(ContextType.Guild)]
        public Task YouAreGreatAsync() {

            List<string> responses = new List<string> {
                "awww",
                ":heart:",
                "I hope all subs are as nice as you!",
                "camryn might be 14, but she is 18 in my heart",
                "thats so sweet",
                "Thats really nice but please give me a sub",
                "d'awww",
                "people are much nicer here than the ninja discord",
                "do you think wubby could still love me as a non-sub?"
            };
            
            ulong reply = ReplyAsync(responses.PickRandom()).Result.Id;

            UndoTracker.Track(Context.Guild.Id, Context.Channel.Id, Context.User.Id, Context.Message.Id, reply);
            return Task.CompletedTask;
        }

    }

}
