namespace DiSourceGenerator.Helper;

internal static class SourceGeneratorPackagedInterfaces
{
    public const string IServiceInterface = $@"
using Microsoft.Extensions.DependencyInjection;

{SourceGeneratorPackagedNamespaces.AutoDiRegistrationAttributes};

public interface IServiceModule
{{     
    public IServiceCollection AddServicesToServiceCollection(IServiceCollection serviceCollection);
}} 
";
}