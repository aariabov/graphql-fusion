var builder = WebApplication.CreateBuilder(args);

builder
    .AddGraphQL("Products")
    .AddTypes();

var app = builder.Build();

app.MapGraphQL();
app.RunWithGraphQLCommands(args);