using Dictionary.Business.Repositories;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Dictionary.Business.Initialization
{
    public class DictionaryRepositoryInitModule : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {         
            context.Services.AddHttpContextOrThreadScoped<IDictionaryRepository>(x => x.GetInstance<DictionaryRepository>());
        }

        public void Initialize(InitializationEngine context) { }

        public void Uninitialize(InitializationEngine context) { }
    }
}