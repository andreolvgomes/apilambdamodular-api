using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpGet("vendas/{venda_id}/itens/{item_id}")]
public class ObterItensPorIdEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
