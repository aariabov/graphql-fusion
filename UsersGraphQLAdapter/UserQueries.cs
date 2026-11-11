using HotChocolate;
using HotChocolate.CostAnalysis.Types;

namespace UsersGraphQLAdapter;

public class UserQueries
{
    [ListSize(AssumedSize = 3)]
    public async Task<List<User>> GetUsers(
        [Service] IHttpClientFactory httpClientFactory,
        CancellationToken cancellationToken)
    {
        var client = httpClientFactory.CreateClient("UsersREST");
        return await client.GetFromJsonAsync<List<User>>("api/users", cancellationToken)
            ?? [];
    }

    public async Task<User?> GetUserById(
        int id,
        [Service] IHttpClientFactory httpClientFactory,
        CancellationToken cancellationToken)
    {
        var client = httpClientFactory.CreateClient("UsersREST");
        return await client.GetFromJsonAsync<User>($"api/users/{id}", cancellationToken);
    }
}