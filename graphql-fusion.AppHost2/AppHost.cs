var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Gateway>("gateway");

builder.AddProject<Projects.Products>("products");

builder.AddProject<Projects.Reviews>("reviews");

builder.AddProject<Projects.Shipping>("shipping");

builder.AddProject<Projects.UsersGraphQLAdapter>("usersgraphqladapter");

builder.AddProject<Projects.UsersREST>("usersrest");

builder.Build().Run();
