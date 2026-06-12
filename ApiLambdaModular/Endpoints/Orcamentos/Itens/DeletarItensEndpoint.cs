using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos.Itens;

[HttpDelete("orcamentos/{orcamento_id}/itens/{item_id}")]
public class DeletarItensEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
