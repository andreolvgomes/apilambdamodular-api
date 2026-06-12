using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpPost("orcamentos")]
public class CriarOrcamentosEndpoint : Endpoint<CriarOrcamentosRequest>
{
    public async override Task<object?> ExecuteAsync(CriarOrcamentosRequest req, CancellationToken ct)
    {
        return await Send.OkAsync(ct);
    }
}
