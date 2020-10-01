using Newtonsoft.Json;
using sdTelegramBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace sdTelegramBot.Commands.Commands
{
    public class GetEventsCommand : Command
    {
        public override string[] Names { get; set; } = new string[] { "getevents", "get_events" };

        public async override void Execute(Message message, TelegramBotClient client)
        {
            HttpClient http = new HttpClient();
            var request = await http.GetStringAsync("https://localhost:44369/api/NowEvents");
            var response = JsonConvert.DeserializeObject<Events[]>(request);

            await client.SendTextMessageAsync(message.Chat.Id, $"Ближайшие мероприятия: ");

            foreach (var i in response)
            {
                await client.SendTextMessageAsync(message.Chat.Id, $" Название: {i.name}.\n Дата проведения: {i.date}.\n Доп. информация: {i.text}.");
            }
            
        }
    }
}
