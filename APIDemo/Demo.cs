using System;
using APIDemo;
using APIDemo.DTO;
using Newtonsoft.Json;
using RestSharp;


namespace APIDemo
{
    public class Demo
    {
        public ListAllUsersDTO GetUsers()
        {
            IRestClient restClient = new RestClient("https://reqres.in/api/users?page=2");
            IRestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            var response = restClient.Execute(request);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<ListAllUsersDTO>(content);
            return users;

        }
    }
}

