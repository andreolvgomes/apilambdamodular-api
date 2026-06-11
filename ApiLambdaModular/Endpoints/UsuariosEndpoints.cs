using FastEndpoints;

namespace ApiLambdaModular.Endpoints
{
    [HttpGet("usuarios")]
    [Tags("teste")]
    public class GetAllUsuariosEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }

    [HttpGet("usuarios/status")]
    [Tags("teste")]
    public class StatusUsuariosEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }
}
