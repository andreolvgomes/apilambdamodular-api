using ApiLambdaModular.Endpoints.Vendas.Dtos;
using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpPost("vendas/{venda_id}/pagamentos")]
public class CriarPagamentosEndpoint : Endpoint<PagamentoVendaRequest>
{
    public async override Task<object?> ExecuteAsync(PagamentoVendaRequest req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
