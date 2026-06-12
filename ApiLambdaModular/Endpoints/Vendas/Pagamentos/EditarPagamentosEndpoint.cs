using ApiLambdaModular.Endpoints.Vendas.Dtos;
using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpPut("vendas/{venda_id}/pagamentos/{pagamento_id}")]
public class EditarPagamentosEndpoint : Endpoint<PagamentoVendaRequest>
{
    public async override Task<object?> ExecuteAsync(PagamentoVendaRequest req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
