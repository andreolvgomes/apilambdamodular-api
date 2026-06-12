using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos.Itens;

[HttpPut("orcamentos/{orcamento_id}/itens/{item_id}")]
public class EditarItensEndpoint : Endpoint<ItemOrcamentos>
{
    public async override Task<object?> ExecuteAsync(ItemOrcamentos req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
