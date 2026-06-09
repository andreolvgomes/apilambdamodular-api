using FastEndpoints;

namespace ApiLambdaModular.Endpoints
{
    [HttpGet("usuarios")]
    public class GetAllUsuariosEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }

    [HttpGet("usuarios/status")]
    public class StatusUsuariosEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }
}
