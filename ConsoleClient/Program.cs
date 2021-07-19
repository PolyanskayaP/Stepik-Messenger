using System;
using Newtonsoft.Json;

namespace Stepik_Messenger
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
            //Message msg = new Message("Polyanskaya", "Privet", DateTime.UtcNow);
            //string output = JsonConvert.SerializeObject(msg);
            //Console.WriteLine(output);
            //Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            //Console.WriteLine(deserializedMsg);
            //{ "UserName":"Polyanskaya","MessageText":"Privet","TimeStamp":"2021-07-17T19:14:03.4957608Z"}
            //Polyanskaya < 17.07.2021 19:14:03 >: Privet

            MessageID = 1;
            Console.WriteLine("Введите Ваше имя:");
            //UserName = "Polyanskaya";
            UserName = Console.ReadLine();
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
