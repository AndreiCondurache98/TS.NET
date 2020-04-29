using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using GrpcService;
using GrpcService.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
             /*var input = new HelloRequest { Name = "Andrei" };

             var channel = GrpcChannel.ForAddress("https://localhost:5001");
             var client = new Greeter.GreeterClient(channel);

             var reply = await client.SayHelloAsync(input);

             Console.WriteLine(reply.Message);*/

              var channel = GrpcChannel.ForAddress("https://localhost:5001");
              var postClient = new RemotePost.RemotePostClient(channel);

              PostModel newPost = new PostModel()
              {
                  Description = "Description1",
                  Domain = "Domain1",
                  Date = Timestamp.FromDateTime(new DateTime(2016, 12, 12, 10, 10, 10, DateTimeKind.Utc))

              };
              await postClient.AddPostAsync(newPost);




            /* var postClient = new RemotePost.RemotePostClient(channel);
             var input = new PostLookupModel { PostId = 1 };
             var reply = await postClient.GetPostByIdAsync(input);
             Console.WriteLine($"{reply.Description} {reply.Domain}");*/

        }
    }
}
