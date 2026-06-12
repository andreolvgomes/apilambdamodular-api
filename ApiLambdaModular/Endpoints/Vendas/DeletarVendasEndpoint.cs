using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpDelete("vendas/{venda_id}")]
public class DeletarVendasEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
