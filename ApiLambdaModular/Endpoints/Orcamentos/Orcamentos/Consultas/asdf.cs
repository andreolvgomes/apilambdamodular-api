using FastEndpoints;

namespace ApiLambdaModular.Endpoints.Orcamentos.Orcamentos.Consultas;

[HttpGet("orcamentos/consultar-cancelados")]
public class OrcamentosCanceladosEndpoint : EndpointWithoutRequest
{
    public async override Task<object?> ExecuteAsync(CancellationToken ct)
    {
        return await Send.OkAsync();
    }
}
