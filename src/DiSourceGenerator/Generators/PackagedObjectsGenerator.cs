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
        context.RegisterPostInitializationOutput(ctx => ctx.AddSource(
            $"{SourceGeneratorPackaged.ClassNames.GeneratedServiceCollectionAttribute}.g.cs",
            SourceText.From(SourceGeneratorPackaged.Attributes.GeneratedServiceCollectionAttribute, Encoding.UTF8)));
    }
}