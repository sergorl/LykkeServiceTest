using System.Threading.Tasks;
using JetBrains.Annotations;
using Refit;

namespace Lykke.Service.TestService.Client
{
    // This is an example of service controller interfaces.
    // Actual interface methods must be placed here (not in ITestServiceClient interface).

    /// <summary>
    /// TestService client API interface.
    /// </summary>
    [PublicAPI]
    public interface ITestServiceApi
    {
        /// <summary>
        /// Get some text
        /// </summary>
        /// <returns>Hello, World!!!</returns>
        [Get("api/TestService/Hello")]
        Task<string> Get();
    }
}
