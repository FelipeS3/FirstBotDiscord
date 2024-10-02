
//https://discord.com/oauth2/authorize?client_id=1290695277853937706&permissions=8&integration_type=0&scope=bot

using Discord;
using Discord.WebSocket;
using OpenAI;

DotNetEnv.Env.Load();

var discordToken = Environment.GetEnvironmentVariable("DiscordToken");
var openAiToken = Environment.GetEnvironmentVariable("OpenAIToken");

async Task RunBotAsync()
{
    var client = new DiscordSocketClient();

    await client.LoginAsync(Discord.TokenType.Bot, discordToken);

    Console.WriteLine(client.LoginState);

    await client.StartAsync();

    client.Ready += async () =>
    {
        var guild = client.GetGuild(1290661649547788359);
        var channel = guild.GetTextChannel(1290661649547788362);

        await channel.SendMessageAsync("Bem-vindo ao nosso servidor!!");

        var embed = new EmbedBuilder();
        embed.WithImageUrl("https://th.bing.com/th/id/R.c5d6bceffe8493c40050907b38aff751?rik=Rfrp9w2AW7Y0qg&pid=ImgRaw&r=0");
        await channel.SendMessageAsync(embed: embed.Build());
        await channel.SendMessageAsync(" ");
        //
        var openAIAPI = new OpenAIClient(openAiToken);

        var completionRequest = new OpenAIClient
        {
            await channel.SendMessageAsync(openAIAPI;)
        };
        await channel.SendMessageAsync(completionRequest.Prompt);




        await client.DisposeAsync();

    };



}


await RunBotAsync();

Console.ReadKey();
//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