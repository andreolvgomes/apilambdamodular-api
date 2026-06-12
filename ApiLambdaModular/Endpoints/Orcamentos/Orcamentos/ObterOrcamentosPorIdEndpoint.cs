using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpGet("orcamentos/{orcamento_id}")]
public class ObterOrcamentosPorIdEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
