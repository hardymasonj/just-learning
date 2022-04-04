using HS.Learning.FastEndpoints.Endpoints.TestParameter.Models;

namespace HS.Learning.FastEndpoints.Endpoints.TestParameter
{
    public class TestParameterEndpointPost : Endpoint<Models.Request, Models.Response>
    {
        public override void Configure()
        {
            base.Post("/api/v1/test-parameter");
            base.AllowAnonymous();
        }
        public override async Task HandleAsync(Request req, CancellationToken ct)
        {
            await base.SendAsync(new Response { Value = req.Parameter });
        }
    }
}
