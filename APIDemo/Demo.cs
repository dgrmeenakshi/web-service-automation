using APIDemo.DTO;
using Newtonsoft.Json;
using RestSharp;


namespace APIDemo
{
    public class Demo
    {
        public ListAllUsersDTO GetUsers()
        {
            Request request = new Request();
            var client = request.SetUrl("users?page=2");
            var getRequest = request.CreateGetRequest();
            var getResponse = request.GetResponse(client, getRequest);
            ListAllUsersDTO content=  request.GetContent<ListAllUsersDTO>(getResponse);
            return content;
        }
    }
}

