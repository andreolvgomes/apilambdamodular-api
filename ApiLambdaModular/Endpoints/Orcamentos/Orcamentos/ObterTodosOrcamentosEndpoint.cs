using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpGet("orcamentos")]
public class ObterTodosOrcamentosEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
