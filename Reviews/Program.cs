var builder = WebApplication.CreateBuilder(args);

builder
    .AddGraphQL("Reviews")
    .AddTypes();

var app = builder.Build();

app.MapGraphQL();
app.RunWithGraphQLCommands(args);