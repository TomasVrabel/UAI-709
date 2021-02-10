using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace SerializationExamples
{
    class User
    {
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public User Mother { get; set; }
        public User Father { get; set; }
    }

    class JsonSerializationExample
    {
        public void RunExample()
        {

            var peter = new User
            {
                GivenName = "Petr",
                Surname = "Novak",
                Age = 19,
                Mother = new User
                {
                    GivenName = "Jana",
                    Surname = "Novakova",
                    Age = 45,
                },
                Father = new User
                {
                    GivenName = "Michal",
                    Surname = "Novak",
                    Age = 45,
                }
            };

            var options = new JsonSerializerOptions {
                WriteIndented = true,
            };

            string serializedUser = JsonSerializer.Serialize(peter, options);

            Console.WriteLine(serializedUser);

            var deserialized = JsonSerializer.Deserialize<User>(serializedUser);

            Console.WriteLine("---------------------");
            Console.WriteLine("Deserialized:");
            Console.WriteLine("givenName: " + deserialized.GivenName);
            Console.WriteLine("surname: " + deserialized.Surname);
            Console.WriteLine("mother.givenName: " + deserialized.Mother.GivenName);
            Console.WriteLine("mother.surname: " + deserialized.Mother.Surname);
            Console.WriteLine("father.givenName: " + deserialized.Father.GivenName);
            Console.WriteLine("father.surname: " + deserialized.Father.Surname);

        }
    }
}
