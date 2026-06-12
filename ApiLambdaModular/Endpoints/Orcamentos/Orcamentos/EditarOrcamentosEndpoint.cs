using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpPut("orcamentos/{orcamento_id}")]
public class EditarOrcamentosEndpoint : Endpoint<CriarOrcamentosRequest>
{
    public async override Task<object?> ExecuteAsync(CriarOrcamentosRequest req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
