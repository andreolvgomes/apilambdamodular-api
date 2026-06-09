using FastEndpoints;

namespace ApiLambdaModular.Endpoints
{
    [HttpGet("produtos")]
    public class GetAllProdutosEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }

    [HttpGet("produtos/status")]
    public class StatusProdutosEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }
}
