using HS.Learning.FastEndpoints.Endpoints.TestParameter.Models;
namespace HS.Learning.FastEndpoints.Endpoints.TestParameter
{
    public class TestParameterEndpoint : Endpoint<Request, Response>
    {
        public override void Configure()
        {
            base.Get("/api/v1/test-parameter/{Parameter}");
            base.AllowAnonymous();
        }
        public override async Task HandleAsync(Request req, CancellationToken ct)
        {
            await base.SendAsync(new Response { Value = req.Parameter });
        }
    }
}
