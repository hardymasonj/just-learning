namespace HS.Learning.MinimalAPIs.Endpoints.TestParameter
{
    public class Endpoint
    {
        public Models.Response Run(Models.Request request)
        {
            return new Models.Response { Value = request.Parameter };
        }
    }
}
