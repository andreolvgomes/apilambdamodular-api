using ApiLambdaModular.Endpoints.Vendas.Dtos;
using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpPut("vendas/{venda_id}")]
public class EditarVendasEndpoint : Endpoint<CriarVendaRequest>
{
    public async override Task<object?> ExecuteAsync(CriarVendaRequest req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
