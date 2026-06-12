using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos.Itens;

[HttpPost("orcamentos/{orcamento_id}/itens/bulk-cancelar")]
public class ItemsBulkCancelarEndpoint : Endpoint<BulkCancelarItens>
{
    public async override Task<object?> ExecuteAsync(BulkCancelarItens req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
