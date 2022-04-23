// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

namespace MessengerStepikCSharp
{
    class Program
    {
        private static int MessageID;
        private static string UserName;
        private static MessangerClientAPI API = new MessangerClientAPI();

        private static void GetNewMessages()
        {
            Message msg = API.GetMessage(MessageID);
            while (msg != null)
            {
                Console.WriteLine(msg);
                MessageID++;
                msg = API.GetMessage(MessageID);
            }
        }
        static void Main(string[] args)
        {
            MessageID = 1;
            Console.WriteLine("Введите Ваше имя:");
            //UserName = "Frozek";
            UserName = Console.ReadLine();
            Console.WriteLine("Введите ваше сообщение:");
            string MessageText = "";
            while (MessageText != "exit")
            {
                GetNewMessages();
                MessageText = Console.ReadLine();
                if (MessageText.Length > 1)
                {
                    Message Sendmsg = new Message(UserName, MessageText, DateTime.Now);
                    API.SendMessage(Sendmsg);
                }
            }
        }
    }
}




//Console.WriteLine("Начало!");
//Console.WriteLine(msg.ToString());
// {"UserName":"Frozek","MessageText":"Привет","TimeStamp":"2022-04-22T23:10:31.2754892Z"}
// [22.04.2022 23:10:31] | Frozek: Привет