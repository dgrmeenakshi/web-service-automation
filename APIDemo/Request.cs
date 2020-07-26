using Newtonsoft.Json;
using RestSharp;
using System.IO;

namespace APIDemo
{
    public class Request
    {
        IRestClient restClient;
        IRestRequest restRequest;
        IRestResponse restResponse;
        string baseUrl = @"https://reqres.in/api/";

        public IRestClient SetUrl(string endpoint)
        {
            var url = string.Concat(baseUrl,endpoint);
            restClient = new RestClient(url);
            return restClient;
        }
        public IRestRequest CreateGetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public IRestRequest POST(string payload)
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;

        }
        public IRestRequest PUT(string payload)
        {
            restRequest = new RestRequest(Method.PUT);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;

        }
        public IRestRequest PATCH(string payload)
        {
            restRequest = new RestRequest(Method.PATCH);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return restRequest;

        }
        public IRestRequest DELETE(string payload)
        {
            restRequest = new RestRequest(Method.DELETE);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;

        }
        public IRestResponse GetResponse(IRestClient restClient, IRestRequest restRequest)
        {
            return restClient.Execute(restRequest);
        }

        public DTO GetContent<DTO>(IRestResponse restResponse)
        {
            var content = restResponse.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }
    }
}
