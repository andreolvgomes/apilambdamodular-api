using FastEndpoints;

namespace ApiLambdaModular.Endpoints
{
    [HttpGet("clientes")]
    public class GetAllClientesEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }

    [HttpGet("clientes/status")]
    public class StatusClientesEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }
}