namespace HS.Learning.MinimalAPIs.Extensions
{
    public static class EndpointExtensions
    {
        public static void RegisterMinimalEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/v1/parameter-test/{parameter}", (string parameter) =>
            {
                return parameter;
            });
            app.MapPost("/api/v1/parameter-test", (Endpoints.TestParameter.Models.Request request) =>
            {
                return new Endpoints.TestParameter.Endpoint().Run(request);
            });
        }
    }
}
