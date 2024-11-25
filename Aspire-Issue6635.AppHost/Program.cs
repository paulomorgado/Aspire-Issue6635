var builder = DistributedApplication.CreateBuilder(args);

//var apiService = builder.AddProject<Projects.Aspire_Issue6635_ApiService>("apiservice");

var apiService = builder.AddContainer("apiservice", "aspireissue6635apiservice")
    .WithHttpEndpoint(targetPort: 8080)
    .WithOtlpExporter();

builder.AddProject<Projects.Aspire_Issue6635_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService.GetEndpoint("http"))
    .WaitFor(apiService);

builder.Build().Run();
