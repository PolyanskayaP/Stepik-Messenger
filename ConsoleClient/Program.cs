using System;
using Newtonsoft.Json;

namespace Stepik_Messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Polyanskaya", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"Polyanskaya","MessageText":"Privet","TimeStamp":"2021-07-17T19:14:03.4957608Z"}
            //Polyanskaya < 17.07.2021 19:14:03 >: Privet
            

        }
    }
}
