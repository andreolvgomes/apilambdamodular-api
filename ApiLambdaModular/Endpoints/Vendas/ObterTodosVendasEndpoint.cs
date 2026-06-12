using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpGet("vendas")]
public class ObterTodosVendasEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
