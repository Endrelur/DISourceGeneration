using DiSourceGenerator.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DiSourceGenerator.Generators;

[Generator]
public class ServiceCollectionGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var serviceCollectionsToGenerate = context.SyntaxProvider
            .ForAttributeWithMetadataName(
                SourceGeneratorPackagedObjects.Namespaces.AutoDiRegistrationAttributes + "." + SourceGeneratorPackagedObjects.ClassNames.GeneratedServiceCollectionAttribute,
                // Only static partial classes
                predicate: (node, _) => node is ClassDeclarationSyntax classDeclaration
                                        && classDeclaration.Modifiers.Any(Microsoft.CodeAnalysis.CSharp.SyntaxKind.PartialKeyword)
                                        && classDeclaration.Modifiers.Any(Microsoft.CodeAnalysis.CSharp.SyntaxKind.StaticKeyword),
                transform: static (context, _) =>
                {
                    // The symbol gives us easy access to the namespace and name
                    var symbol = (INamedTypeSymbol)context.TargetSymbol;

                    return new ClassModel(
                        Name: symbol.Name,
                        Namespace: symbol.ContainingNamespace.ToDisplayString()
                    );
                });
    }


}

file record struct ClassModel(
    string Name,
    string Namespace
);