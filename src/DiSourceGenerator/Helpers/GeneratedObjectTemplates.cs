namespace DiSourceGenerator.Helpers;

internal static class GeneratedObjectTemplates
{
    public static string ServiceCollection(string name, string? @namespace)
    {
        var actualNamespace = string.IsNullOrWhiteSpace(@namespace) ? string.Empty : $"namespace {@namespace};";

    return $@"
using Microsoft.Extensions.DependencyInjection;

{actualNamespace}

static partial class {name}
{{
    public static IServiceCollection Register{name}Services(this IServiceCollection services)
    {{
        // Your generation logic for service registration goes here
        return services;
    }}
}}
";
}
    }
