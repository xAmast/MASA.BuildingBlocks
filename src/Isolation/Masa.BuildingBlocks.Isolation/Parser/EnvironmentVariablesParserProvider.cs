﻿namespace Masa.BuildingBlocks.Isolation.Parser;

public class EnvironmentVariablesParserProvider : IParserProvider
{
    public string Name { get; } = "EnvironmentVariables";

    public Task<bool> ResolveAsync(IServiceProvider serviceProvider, string key, Action<string> action)
    {
        string? value = System.Environment.GetEnvironmentVariable(key);
        if (!string.IsNullOrEmpty(value))
        {
            action.Invoke(value);
            return Task.FromResult(true);
        }
        return Task.FromResult(false);
    }
}
