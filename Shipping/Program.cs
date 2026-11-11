var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder
    .AddGraphQL("Shipping")
    .AddTypes();

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGraphQL();
app.RunWithGraphQLCommands(args);