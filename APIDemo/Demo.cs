using APIDemo.DTO;
using Newtonsoft.Json;
using RestSharp;


namespace APIDemo
{
    public class Demo
    {
        public ListAllUsersDTO GetUsers()
        {
            Request restRequest = new Request();
            var client = restRequest.SetUrl("users?page=2");
            var request = restRequest.CreateGetRequest();
            var response = restRequest.GetResponse(client, request);
            ListAllUsersDTO content = restRequest.GetContent<ListAllUsersDTO>(response);
            return content;
        }
        public string CreateUser()
        {
            Request restRequest = new Request();
            var client = restRequest.SetUrl("users");
            string payload = @"{ ""name"": ""morpheus"",
                                    ""job"": ""leader""
                               }";
            var request = restRequest.CreatePostRequest(payload);
            var response = restRequest.GetResponse(client, request);
            return response.StatusCode.ToString();
        }
    }
}

