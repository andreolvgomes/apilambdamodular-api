using FastEndpoints;

namespace ApiLambdaModular.Endpoints
{
    [HttpGet("produtos")]
    [Tags("teste")]
    public class GetAllProdutosEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }

    [HttpGet("produtos/status")]
    [Tags("teste")]
    public class StatusProdutosEndpoint : EndpointWithoutRequest
    {
        public async override Task<object?> ExecuteAsync(CancellationToken ct)
        {
            return Send.OkAsync(new { Status = true }, ct);
        }
    }
}
