using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpDelete("orcamentos/{orcamento_id}/pagamentos/{pagamento_id}")]
public class DeletarPagamentosEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
