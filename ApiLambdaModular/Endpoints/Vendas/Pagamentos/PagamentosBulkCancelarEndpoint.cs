using ApiLambdaModular.Endpoints.Vendas.Dtos;
using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpPost("vendas/{venda_id}/pagamentos/bulk-cancelar")]
public class PagamentosBulkCancelarEndpoint : Endpoint<BulkCancelarPagamentosVenda>
{
    public async override Task<object?> ExecuteAsync(BulkCancelarPagamentosVenda req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}