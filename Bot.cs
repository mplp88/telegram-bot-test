using System;
using Telegram.Bot;

namespace TelegramBot
{
    public class Bot
    {
        const string API_KEY = "810243861:AAEN9uEFpCJ5wIDItawTObF_w5yR5De76nQ";

        private TelegramBotClient _client;

        public Bot()
        {
            _client = new TelegramBotClient(API_KEY);
        }

        public async void SendMessage(string message) 
        {
            try
            {
                Telegram.Bot.Types.Message r = await _client.SendTextMessageAsync("@TehPon", message);
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