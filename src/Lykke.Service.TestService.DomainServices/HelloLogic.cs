using System;
using System.Threading.Tasks;
using Lykke.Service.TestService.Domain.Services;

namespace Lykke.Service.TestService.DomainServices
{
    public class HelloLogic : IHelloLogic
    {
        public async Task<string> SayHello()
        {
            Console.WriteLine("I'm first!!!");
            await Task.Delay(1000);
            return "Hello, World :)";
        }
    }
}
