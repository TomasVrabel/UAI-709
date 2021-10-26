using System;
using Google.Protobuf;
using System.Text;
using System.IO;

namespace SerializationExamples
{
    class ProtoSerializationExample
    {
        public void RunExample()
        {

            ProtoExamples.Generated.Address addr = new ProtoExamples.Generated.Address();
            addr.Street = "Benkova";
            addr.City = "Brno";

            ProtoExamples.Generated.Person father = new ProtoExamples.Generated.Person();
            father.GivenName = "Jan";
            father.Surname = "Novak";
            father.Age = 50;

            ProtoExamples.Generated.Person person = new ProtoExamples.Generated.Person();
            person.GivenName = "Petr";
            person.Surname = "Novak";
            person.Age = 25;
            person.Addr = addr;
            person.Father = father;


            byte[] serializedBytes;
            using (MemoryStream stream = new MemoryStream())
            {
                person.WriteTo(stream);
                serializedBytes = stream.ToArray();
            }

            Console.WriteLine("serialized: {0}", Encoding.ASCII.GetString(serializedBytes));

            var deserialized = ProtoExamples.Generated.Person.Parser.ParseFrom(serializedBytes);
            Console.WriteLine("givenName: {0}", deserialized.GivenName);
            Console.WriteLine("surname: {0}", deserialized.Surname);
            Console.WriteLine("age: {0}", deserialized.Age);


        }
    }
}
