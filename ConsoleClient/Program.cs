// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;

namespace MessengerStepikCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Frozek", "Привет", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message disMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(disMsg);

            //Console.WriteLine("Начало!");
            //Console.WriteLine(msg.ToString());
            // {"UserName":"Frozek","MessageText":"Привет","TimeStamp":"2022-04-22T23:10:31.2754892Z"}
            // [22.04.2022 23:10:31] | Frozek: Привет
        }
    }
}