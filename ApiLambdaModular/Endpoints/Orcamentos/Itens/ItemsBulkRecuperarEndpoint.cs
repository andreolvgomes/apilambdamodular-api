using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos.Itens;

[HttpPost("orcamentos/{orcamento_id}/itens/bulk-recuperar")]
public class ItemsBulkRecuperarEndpoint : Endpoint<BulkRecuperarItens>
{
    public async override Task<object?> ExecuteAsync(BulkRecuperarItens req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
