﻿namespace Masa.BuildingBlocks.Dispatcher.Events;
public interface IDispatcherOptions
{
    IServiceCollection Services { get; }

    Assembly[] Assemblies { get; }
}
