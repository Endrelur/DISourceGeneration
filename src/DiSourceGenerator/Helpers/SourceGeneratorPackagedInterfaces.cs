namespace DiSourceGenerator.Helpers;

internal static class SourceGeneratorPackagedInterfaces
{
    public const string IServiceInterface = $@"
using Microsoft.Extensions.DependencyInjection;

{SourceGeneratorPackagedNamespaces.AutoDiRegistrationAttributes};

public interface IGeneratedServiceCollection
{{     
    public IServiceCollection AddServicesToServiceCollection(IServiceCollection serviceCollection);
}} 
";
}