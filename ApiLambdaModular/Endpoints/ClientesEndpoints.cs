using FastEndpoints;

namespace ApiLambdaModular.Endpoints
{
    [HttpGet("clientes")]
    [Tags("teste")]
    public class GetAllClientesEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }

    [HttpGet("clientes/status")]
    [Tags("teste")]
    public class StatusClientesEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }
}
