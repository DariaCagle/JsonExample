using Newtonsoft.Json;
using System;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { Login = "SomeLogin", PassWord = "SomeComplicatedPassword" };
            string json = JsonConvert.SerializeObject(user, Formatting.Indented);
            Console.WriteLine(json);
            User restoredUser = JsonConvert.DeserializeObject<User>(json);
        }
    }
}
