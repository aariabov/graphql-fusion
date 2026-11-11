var builder = WebApplication.CreateBuilder(args);

builder
    .AddGraphQL("Shipping")
    .AddTypes();

var app = builder.Build();

app.MapGraphQL();
app.RunWithGraphQLCommands(args);