using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpGet("orcamentos/{orcamento_id}/pagamentos")]
public class ObterPagamentosTodosEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
