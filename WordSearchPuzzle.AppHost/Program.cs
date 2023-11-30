var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.WordSearchPuzzle_ApiService>("WordSearchPuzzle.API");

builder.AddProject<Projects.WordSearchPuzzle_Web>("WordSearchPuzzle.WebApp")
    .WithReference(apiservice);

builder.Build().Run();
