using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.TestService.Client 
{
    /// <summary>
    /// TestService client settings.
    /// </summary>
    public class TestServiceServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
        
        
    }
}
