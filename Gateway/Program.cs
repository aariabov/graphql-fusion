var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services
    .AddHttpClient("fusion");

builder
    .AddGraphQLGateway()
    .AddFileSystemConfiguration("./gateway.far")
    .ModifyRequestOptions(o =>
    {
        o.CollectOperationPlanTelemetry = true;
        o.AllowOperationPlanRequests = true;
    });

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGraphQL();
app.Run();
