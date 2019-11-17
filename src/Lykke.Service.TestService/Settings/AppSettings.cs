using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.TestService.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public TestServiceSettings TestServiceService { get; set; }
    }
}
