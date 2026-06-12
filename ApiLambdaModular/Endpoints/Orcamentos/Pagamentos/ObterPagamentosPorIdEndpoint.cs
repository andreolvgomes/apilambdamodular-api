using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpGet("orcamentos/{orcamento_id}/pagamentos/{pagamento_id}")]
public class ObterPagamentosPorIdEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
