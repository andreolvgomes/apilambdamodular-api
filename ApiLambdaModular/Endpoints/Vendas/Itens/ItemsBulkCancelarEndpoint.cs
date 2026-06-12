using ApiLambdaModular.Endpoints.Vendas.Dtos;
using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpPost("vendas/{venda_id}/itens/bulk-cancelar")]
public class ItemsBulkCancelarEndpoint : Endpoint<BulkCancelarItensVenda>
{
    public async override Task<object?> ExecuteAsync(BulkCancelarItensVenda req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
