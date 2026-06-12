using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos;

[HttpPut("orcamentos/{orcamento_id}/pagamentos/{pagamento_id}")]
public class EditarPagamentosEndpoint : Endpoint<CriarPagamentoOrcamentosRequest>
{
    public async override Task<object?> ExecuteAsync(CriarPagamentoOrcamentosRequest req, CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
