using AutoDi.Registration;

namespace DISourceGeneration.Test.Tests;

[RegisterIn<TestServiceCollection, ITestTransientServiceWithInterface1>]
[RegisterIn<TestServiceCollection2>]
public class TestTransientServiceWithInterface1 : ITestTransientServiceWithInterface1
{
}

[Decorator]
[RegisterIn<TestServiceCollection, ITestTransientServiceWithInterface1>]
public class TestTransientServiceWithInterface1Decorator : ITestTransientServiceWithInterface1
{
}

public interface ITestTransientServiceWithInterface1
{
}