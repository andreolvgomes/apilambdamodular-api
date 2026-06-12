using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpPost("orcamentos/{orcamento_id}/pagamentos")]
public class CriarPagamentosEndpoint : Endpoint<CriarPagamentoOrcamentosRequest>
{
    public async override Task<object?> ExecuteAsync(CriarPagamentoOrcamentosRequest req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
