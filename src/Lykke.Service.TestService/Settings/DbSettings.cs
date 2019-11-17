using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.TestService.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }

        [SqlCheck]
        public string SqlDbConnString { get; set; }
    }
}
