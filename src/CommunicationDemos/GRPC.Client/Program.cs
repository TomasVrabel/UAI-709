using Grpc.Net.Client;
using GrpcGreeterClient;
using System;
using System.Threading.Tasks;

namespace GRPC.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var client = new Greeter.GreeterClient(channel);
            
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "Jana" }
                              );

            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
