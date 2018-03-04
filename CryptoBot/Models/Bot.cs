using CryptoBot.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Telegram.Bot;

namespace CryptoBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient _client { get; set; }

        private static List<Command> _commands { get; set; }

        public static IReadOnlyList<Command> Commands { get => _commands.AsReadOnly(); }

        public static async Task<TelegramBotClient> GetClient()
        {
            if (_client != null)
            {
                return _client;
            }
            else
            {
                _commands = new List<Command>();
                _commands.Add(new HelloCommand());


                _client = new TelegramBotClient(AppSettings.Key);
                var hook = String.Format(AppSettings.Url, "api/message/update");
                await _client.SetWebhookAsync(hook);

                return _client;
            }
        }
    }
}