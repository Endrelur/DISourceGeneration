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

        public const string RegisterInAttribute = "RegisterInAttribute";
    }


    internal static class Attributes
    {
        public const string RegisterInAttribute = $@"
using Microsoft.Extensions.DependencyInjection;
using System;

namespace {Namespaces.AutoDiRegistrationAttributes};

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class {ClassNames.RegisterInAttribute}<TServiceCollection> : Attribute where TServiceCollection : class, new()
{{
    public ServiceLifetime Lifetime {{ get; set; }}
}}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class {ClassNames.RegisterInAttribute}<TServiceCollection, TInterface> : Attribute where TServiceCollection : class, new()
{{
    public ServiceLifetime Lifetime {{ get; set; }}
}}
";

        public const string GeneratedServiceCollectionAttribute = $@"
using System;

namespace {Namespaces.AutoDiRegistrationAttributes};

[AttributeUsage(AttributeTargets.Class)]
public class {ClassNames.GeneratedServiceCollectionAttribute} : Attribute;
";
    }
}