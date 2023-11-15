var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorApp1>("blazorapp1");

builder.AddProject<Projects.BlazorApp2>("blazorapp2");

builder.Build().Run();
