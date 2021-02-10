using System;

namespace SerializationExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("JSON serialization example");
            var jsonExample = new JsonSerializationExample();
            jsonExample.RunExample();
            */
            
            Console.WriteLine("ProtoBuf serialization example");
            var protoExample = new ProtoSerializationExample();
            protoExample.RunExample();
            
        }
    }
}
