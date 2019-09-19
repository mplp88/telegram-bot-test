using System;

namespace TelegramBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            string mensaje = string.Empty;
            Console.Write("Mensaje: ");
            mensaje = Console.ReadLine();

            bot.SendMessage(mensaje);

            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}
