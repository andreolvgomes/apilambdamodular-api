using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpGet("vendas/{venda_id}")]
public class ObterVendasPorIdEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
