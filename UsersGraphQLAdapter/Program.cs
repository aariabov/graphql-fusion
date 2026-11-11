var builder = WebApplication.CreateBuilder(args);

var usersRestBaseUrl = builder.Configuration["UsersREST:BaseUrl"]
    ?? throw new InvalidOperationException("UsersREST:BaseUrl is not configured.");

builder.Services.AddHttpClient("UsersREST", client =>
    client.BaseAddress = new Uri(usersRestBaseUrl));

builder
    .AddGraphQL("UsersGraphQLAdapter")
    .AddQueryType<UserQueries>(type => type.Name("Query"));

var app = builder.Build();

app.MapGraphQL();
app.RunWithGraphQLCommands(args);