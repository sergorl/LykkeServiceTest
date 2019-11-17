using System.Threading.Tasks;

namespace Lykke.Service.TestService.Domain.Services
{
    public interface IHelloLogic
    {
        Task<string> SayHello();
    }
}
