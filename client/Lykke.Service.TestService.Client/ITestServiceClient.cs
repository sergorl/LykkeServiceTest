using JetBrains.Annotations;

namespace Lykke.Service.TestService.Client
{
    /// <summary>
    /// TestService client interface.
    /// </summary>
    [PublicAPI]
    public interface ITestServiceClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - ITestServiceApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        ITestServiceApi TestServiceApi { get; }
    }
}
