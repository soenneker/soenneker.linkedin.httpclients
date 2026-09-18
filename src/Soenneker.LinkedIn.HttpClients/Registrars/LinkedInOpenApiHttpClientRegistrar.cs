using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.LinkedIn.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.LinkedIn.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class LinkedInOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="LinkedInOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddLinkedInOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ILinkedInOpenApiHttpClient, LinkedInOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="LinkedInOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddLinkedInOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ILinkedInOpenApiHttpClient, LinkedInOpenApiHttpClient>();

        return services;
    }
}
