using ProjetoContaBancaria.Domain;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using ProjetoContaBancaria.Repository.Repositories;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace ProjetoContaBancaria.API.App_Start
{
    public static class SimpleInjectorContainer
    {
        private static readonly Container container = new Container();

        public static Container Build()
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            //container.Register<INotification, Notification>(Lifestyle.Scoped);

            RegisterRepositories();
            RegisterServices();

            container.Verify();
            return container;
        }

        private static void RegisterRepositories()
        {
            container.Register<IClienteRepository, ClienteRepository>();
            container.Register<IClienteService, ClienteService>();
            container.Register<IContaRepository, ContaRepository>();
            container.Register<IContaService, ContaService>();
            container.Register<IOperacaoRepository, OperacaoRepository>();
            container.Register<IOperacaoService, OperacaoService>();
        }

        private static void RegisterServices()
        {
        }
    }
}