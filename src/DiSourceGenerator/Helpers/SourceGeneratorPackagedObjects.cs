namespace DiSourceGenerator.Helpers;

internal static class SourceGeneratorPackagedObjects
{
    internal static class Namespaces
    {
        public const string AutoDiRoot = "AutoDi";

        public const string AutoDiRegistrationAttributes = AutoDiRoot + ".Registration";

        public const string AutoDiRegistrationInterfaces = AutoDiRegistrationAttributes + ".Interfaces";
    }

    internal static class ClassNames
    {
        public const string GeneratedServiceCollectionAttribute = "GeneratedServiceCollectionAttribute";
    }


    internal static class Attributes
    {
        public const string GeneratedServiceCollectionAttribute = $@"
using System;

namespace {Namespaces.AutoDiRegistrationAttributes};

[AttributeUsage(AttributeTargets.Class)]
public class {ClassNames.GeneratedServiceCollectionAttribute} : Attribute;
";
    }
}