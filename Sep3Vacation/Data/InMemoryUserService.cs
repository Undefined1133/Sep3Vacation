using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Sep3Vacation.Models;
namespace Sep3Vacation.Data
{
    public class InMemoryUserService : IUserService
    {
        private readonly HttpClient client;
        private string uri = "http://localhost:5001";
        public InMemoryUserService() {
            client = new HttpClient();
        }
       
        public async Task<User> ValidateRegister(string username, string password, string email)
        {

            // HttpClient client = new HttpClient();
            User user = new User(username, password, email);
            string usernameAndPassword = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(usernameAndPassword, Encoding.UTF8, "application/json");
            
            HttpResponseMessage response = await client.PostAsync($"http://localhost:5001/api/Users/Register", content);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                // string userAsJson = await response.Content.ReadAsStringAsync();
                string userAsJson =  response.Content.ReadAsStringAsync().Result;
                int pFrom = userAsJson.IndexOf("result\":") + "result\":".Length;
                int pTo = userAsJson.LastIndexOf(",\"id\"");

                String result = userAsJson.Substring(pFrom, pTo - pFrom);
                User resultUser = JsonSerializer.Deserialize<User>(result);
                return resultUser;
            }

            throw new Exception("User not found");
        }
        public async Task<User> ValidateLogin(string username, string password)
        {
            
            User user = new User(username, password);
            string usernameAndPassword = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(usernameAndPassword, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync($"http://localhost:5001/api/Users", content);
            
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string userAsJson = await response.Content.ReadAsStringAsync();
                int pFrom = userAsJson.IndexOf("result\":") + "result\":".Length;
                int pTo = userAsJson.LastIndexOf(",\"id\"");

                String result = userAsJson.Substring(pFrom, pTo - pFrom);
                User resultUser = JsonSerializer.Deserialize<User>(result);
                // Console.Write(resultUser.username + " " + resultUser.password + " " + resultUser.role);
                // string userDeserealized = JsonSerializer.Serialize(resultUser);
                // Console.Write(JsonSerializer.Deserialize<User>(userAsJson));
                return resultUser;
            }

            throw new Exception("User not found");
        }

        public async Task<User> GetUserByUserName(string username)
        {
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:5001/api/Users/GetUserByUserName?username={username}");
            string response = await stringAsync;
            int pFrom = response.IndexOf("result\":") + "result\":".Length;
            int pTo = response.LastIndexOf(",\"id\"");

            String resultedString = response.Substring(pFrom, pTo - pFrom);
            Console.Write("ddd");
            User result = JsonSerializer.Deserialize<User>(resultedString);
            return result;
        }

        public async Task<IList<User>> GetAllUsers()
        {
            Task<string> stringAsync = client.GetStringAsync("http://localhost:5001/api/Users");
            string message =  await stringAsync;
            List<User> result = JsonSerializer.Deserialize<List<User>>(message);
            return result;
        }

        public async Task<User> GetUserById(int id)
        {
            Task<string> stringAsync = client.GetStringAsync($"http://localhost:5001/api/Users/GetUserById?id={id}");
            string message =  await stringAsync;
            int pFrom = message.IndexOf("result\":") + "result\":".Length;
            int pTo = message.LastIndexOf(",\"id\"");

            String resultedString = message.Substring(pFrom, pTo - pFrom);
            User result = JsonSerializer.Deserialize<User>(resultedString);
            return result;
            
        }

        public async Task<User> UpdateUsersRole(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PatchAsync($"http://localhost:5001/api/Users/{user.id}", content);
            return await GetUserById(user.id);
        }

        public async Task<User> UpdateUsersInfo(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync($"http://localhost:5001/api/Users/UpdateUsersInfo",content);
            return await GetUserById(user.id);
        }
    }
}