﻿namespace Masa.BuildingBlocks.Isolation.Parser;

public class RouteParserProvider : IParserProvider
{
    public string Name => "Route";

    public Task<bool> ResolveAsync(IServiceProvider serviceProvider, string key, Action<string> action)
    {
        var httpContext = serviceProvider.GetRequiredService<IHttpContextAccessor>().HttpContext;
        var value = httpContext?.GetRouteValue(key)?.ToString() ?? string.Empty;
        if (!string.IsNullOrEmpty(value))
        {
            action.Invoke(value);
            return Task.FromResult(true);
        }

        return Task.FromResult(false);
    }
}
