using ApiLambdaModular.Endpoints.Vendas.Dtos;
using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpPost("vendas/{venda_id}/itens")]
public class CriarItensEndpoint : Endpoint<ItemVendas>
{
    public async override Task<object?> ExecuteAsync(ItemVendas req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
