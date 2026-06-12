using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpGet("vendas/{venda_id}/itens")]
public class ObterItensTodosEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
