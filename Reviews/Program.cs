var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder
    .AddGraphQL("Reviews")
    .AddTypes();

var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGraphQL();
app.RunWithGraphQLCommands(args);