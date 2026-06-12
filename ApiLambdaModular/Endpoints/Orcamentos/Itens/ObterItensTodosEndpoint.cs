using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos.Itens;

[HttpGet("orcamentos/{orcamento_id}/itens")]
public class ObterItensTodosEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
