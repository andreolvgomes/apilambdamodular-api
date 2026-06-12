using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpGet("vendas/{venda_id}/pagamentos")]
public class ObterPagamentosTodosEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
