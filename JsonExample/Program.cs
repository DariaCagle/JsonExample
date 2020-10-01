using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Login = "SomeLogin",
                PassWord = "SomeComplicatedPassword",
                FirstName = "John",
                LastName = "Snow",
                Age = 20
            };
            var listOFProperties = user.GetType().GetProperties();

            string serializedUser = null;
            try
            {
                serializedUser = JsonSerialiser(user);
            }
            catch (MyCustomException ex) when (serializedUser == null)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine(serializedUser);
            }
        }

        public static string JsonSerialiser(User user)
        {
            var listOFProperties = user.GetType().GetProperties();
            var props = new List<string>();
            foreach (var prop in listOFProperties)
            {
                if (prop.GetCustomAttribute<MyIgnoreAttribute>() == null)
                {
                    string property = prop.Name + ": " + prop.GetValue(user);
                    props.Add(property);
                }
            }
            string result = JsonConvert.SerializeObject(props, Formatting.Indented);
            if (props?.Any() == false) return null;
            return result;
        }
    }
}
