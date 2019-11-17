using Autofac;
using JetBrains.Annotations;
using Lykke.Service.TestService.DomainServices.RabbitSubscribers;
using Lykke.Service.TestService.Settings;
using Lykke.RabbitMqBroker.Subscriber;
using Lykke.SettingsReader;

namespace Lykke.Service.TestService.Modules
{
    [UsedImplicitly]
    public class RabbitMqModule : Module
    {
        private const string SubExchangeName = "REPLACE THIS WITH PROPER EXCHANGE NAME"; // TODO pass proper exchange name

        private readonly RabbitMqSettings _settings;

        public RabbitMqModule(IReloadingManager<AppSettings> settingsManager)
        {
            _settings = settingsManager.CurrentValue.TestServiceService.Rabbit;
        }

        protected override void Load(ContainerBuilder builder)
        {
            // NOTE: Do not register entire settings in container, pass necessary settings to services which requires them

            RegisterRabbitMqSubscribers(builder);
        }

        private void RegisterRabbitMqSubscribers(ContainerBuilder builder)
        {
            builder.RegisterJsonRabbitSubscriber<RabbitSubscriber, object>( // TODO replace object with proper message type
                _settings.Subscribers.ConnectionString,
                SubExchangeName,
                nameof(TestService).ToLower()); // this could be changed if needed
        }
    }
}
