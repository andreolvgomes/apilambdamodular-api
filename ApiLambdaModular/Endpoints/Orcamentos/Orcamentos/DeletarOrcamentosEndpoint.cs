using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpDelete("orcamentos/{orcamento_id}")]
public class DeletarOrcamentosEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
