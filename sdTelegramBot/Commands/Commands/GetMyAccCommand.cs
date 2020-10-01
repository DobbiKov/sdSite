using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace sdTelegramBot.Commands.Commands
{
    public class GetMyAccCommand : Command
    {
        public override string[] Names { get; set; } = new string[] { "getmyacc", "get_my_acc" };

        public async override void Execute(Message message, TelegramBotClient client)
        {
            HttpClient http = new HttpClient();
            string host = @"https://localhost:44369";
            string url = $"{host}/api/Users/ByTelegramId/{message.From.Id}";
            var request = await http.GetAsync(url);
            if(request.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                await client.SendTextMessageAsync(message.Chat.Id, $"Мы не смогли найти ваш аккаунт.", replyToMessageId: message.MessageId);
                return;
            }
            var req = await http.GetStringAsync(url);
            var response = JsonConvert.DeserializeObject<Models.User>(req);

            if (response != null)
            {
                await client.SendTextMessageAsync(message.Chat.Id, 
                    $"Имя: {response.firstName}.\n" +
                    $"Фамилия: {response.lastName}.\n" +
                    $"Лесное имя: {response.forestName}.\n" +
                    $"Почта: {response.userName}", 
                    replyToMessageId: message.MessageId);
                return;
            }
            await client.SendTextMessageAsync(message.Chat.Id, $"Мы не смогли найти ваш аккаунт.", replyToMessageId: message.MessageId);
        }
    }
}
