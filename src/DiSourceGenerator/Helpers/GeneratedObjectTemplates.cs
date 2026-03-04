namespace DiSourceGenerator.Helpers;

internal static class GeneratedObjectTemplates
{
    public static string GeneratedServiceCollection(string name, string? @namespace)
    {
        var actualNamespace = string.IsNullOrWhiteSpace(@namespace) ? string.Empty : $"namespace {@namespace};";

        return $@"
using Microsoft.Extensions.DependencyInjection;

{actualNamespace}

partial class {name}
{{
    public IServiceCollection RegisterServices(IServiceCollection services)
    {{
        // Your generation logic for service registration goes here
        return services;
    }}
}}

public static class {name}Extensions
{{
    public static IServiceCollection Register{name}Services(this IServiceCollection services) => new {name}().RegisterServices(services);
}}
";
    }
}