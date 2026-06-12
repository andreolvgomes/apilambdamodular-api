using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpPost("orcamentos/{orcamento_id}/pagamentos/bulk-cancelar")]
public class PagamentosBulkCancelarEndpoint : Endpoint<BulkCancelarPagamentos>
{
    public async override Task<object?> ExecuteAsync(BulkCancelarPagamentos req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}