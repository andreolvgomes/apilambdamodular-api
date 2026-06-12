using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos.Itens;

[HttpPost("orcamentos/{orcamento_id}/itens")]
public class CriarItensEndpoint : Endpoint<ItemOrcamentos>
{
    public async override Task<object?> ExecuteAsync(ItemOrcamentos req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
