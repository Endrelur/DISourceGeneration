using System.Text;
using DiSourceGenerator.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace DiSourceGenerator.Generators;

[Generator]
public class PackagedObjectsGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // GeneratedServiceCollectionAttribute
        AddSourceWithNameAndTemplate(context,
            SourceGeneratorPackagedObjects.ClassNames.GeneratedServiceCollectionAttribute,
            SourceGeneratorPackagedObjects.Attributes.GeneratedServiceCollectionAttribute
        );

        // RegisterInAttribute
        AddSourceWithNameAndTemplate(context,
            SourceGeneratorPackagedObjects.ClassNames.RegisterInAttribute,
            SourceGeneratorPackagedObjects.Attributes.RegisterInAttribute
        );

        // DecoratorAttribute
        AddSourceWithNameAndTemplate(context,
            SourceGeneratorPackagedObjects.ClassNames.DecoratorAttribute,
            SourceGeneratorPackagedObjects.Attributes.DecoratorAttribute
        );
    }

    private static void AddSourceWithNameAndTemplate(IncrementalGeneratorInitializationContext context, string className, string template) =>
        context.RegisterPostInitializationOutput(ctx => ctx.AddSource($"{className}.g.cs", SourceText.From(template, Encoding.UTF8)));
}