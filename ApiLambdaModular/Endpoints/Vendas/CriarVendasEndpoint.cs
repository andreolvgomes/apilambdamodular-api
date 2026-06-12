using ApiLambdaModular.Endpoints.Vendas.Dtos;
using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpPost("vendas")]
public class CriarVendasEndpoint : Endpoint<CriarVendaRequest>
{
    public async override Task<object?> ExecuteAsync(CriarVendaRequest req, CancellationToken ct)
    {
        return await Send.OkAsync(ct);
    }
}
