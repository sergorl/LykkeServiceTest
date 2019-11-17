using Lykke.HttpClientGenerator;

namespace Lykke.Service.TestService.Client
{
    /// <summary>
    /// TestService API aggregating interface.
    /// </summary>
    public class TestServiceClient : ITestServiceClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to TestService Api.</summary>
        public ITestServiceApi TestServiceApi { get; private set; }

        /// <summary>C-tor</summary>
        public TestServiceClient(IHttpClientGenerator httpClientGenerator)
        {
            TestServiceApi = httpClientGenerator.Generate<ITestServiceApi>();
        }
    }
}
