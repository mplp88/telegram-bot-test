using System;
using Telegram.Bot;

namespace TelegramBot
{
    public class Bot
    {
        const string API_KEY = "YOUR_API_KEY_HERE";

        private TelegramBotClient _client;

        public Bot()
        {
            _client = new TelegramBotClient(API_KEY);
        }

        public async void SendMessage(string message) 
        {
            try
            {
                //-347954659 ChatId del grupo Prueba d�nde est� el bot.
                Telegram.Bot.Types.Message r = await _client.SendTextMessageAsync(-347954659, message);
                Console.WriteLine(r);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}