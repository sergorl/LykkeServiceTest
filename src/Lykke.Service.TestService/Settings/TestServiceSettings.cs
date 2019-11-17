using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.TestService.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class TestServiceSettings
    {
        public string Name { get; set; }
        public DbSettings Db { get; set; }

        public RabbitMqSettings Rabbit { get; set; }
    }
}
