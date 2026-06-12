using ApiLambdaModular.Endpoints.Vendas.Dtos;
using FastEndpoints;

namespace ApiLambdaModular.Endpoints;

[HttpPut("vendas/{venda_id}/itens/{item_id}")]
public class EditarItensEndpoint : Endpoint<ItemVendas>
{
    public async override Task<object?> ExecuteAsync(ItemVendas req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
