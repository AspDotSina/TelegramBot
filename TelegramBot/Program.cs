// See https://aka.ms/new-console-template for more information
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static TelegramBotClient bot;

        static void Main(string[] args)
        {
            bot = new TelegramBotClient("6263680249:AAHeXf5Kn_TaHzDTWIRd_JqvDV58vBy-QKw");

            bot.OnMessage += Bot_OnMessage;

            bot.StartReceiving();

            Console.ReadLine();

            bot.StopReceiving();


            Console.ReadKey();

        }

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == MessageType.Text)
            {
                var message = e.Message.Text;
                if (e.Message.Text != "/start")
                {

                    var s = e.Message.Text.Contains("https://www.instagram.com");
                    if (s)
                    {
                        await bot.SendTextMessageAsync(
 chatId: e.Message.Chat.Id,
 text: "این اپشنو هنوز ندارم برات دانلود کنم انشاللله بعدا تا همینجا بسه ");
                    }
                    else
                    {
                        await bot.SendTextMessageAsync(
             chatId: e.Message.Chat.Id,
             text: "کیره مگه من مسخره توام لینک اینستاگرام درست بفرست");
                    }

                }
                else
                {
                    await bot.SendTextMessageAsync(
               chatId: e.Message.Chat.Id,
               text: "لطفا لینک فایل اینستاگرام ارسال کنید .");
                }

            }
        }
    }
}

public class TelegramEvent
{

}