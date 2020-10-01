using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using sdTelegramBot.Commands;
using sdTelegramBot.Commands.Commands;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace sdTelegramBot
{
    public class Program
    {
        private static TelegramBotClient client;
        private static List<Command> commands;
        public static void Main(string[] args)
        {
            client = new TelegramBotClient(BotSettings.Token) { Timeout = TimeSpan.FromSeconds(5) };
            commands = new List<Command>();

            commands.Add(new GetEventsCommand());
            commands.Add(new GetMyIdCommand());
            commands.Add(new GetMyAccCommand());

            client.OnMessage += OnMessageReceived;
            client.StartReceiving();
            CreateHostBuilder(args).Build().Run();
        }

        private static void OnMessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                var message = e.Message;
                foreach (var command in commands)
                {
                    if (command.Contains(message.Text))
                    {
                        command.Execute(message, client);
                    }
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
