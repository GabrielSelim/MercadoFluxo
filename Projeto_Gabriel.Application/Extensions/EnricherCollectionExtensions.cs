using Projeto_Gabriel.Application.Hypermedia.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Projeto_Gabriel.Application.Extensions
{
    public static class EnricherCollectionExtensions
    {
        public static IServiceCollection AddEnrichers(this IServiceCollection services, HyperMediaFilterOptions filterOptions)
        {
            //Adicionando Contato
            //filterOptions.ContentResponseEnricherList.Add(new ContatoEnricher());

            return services;
        }
    }
}