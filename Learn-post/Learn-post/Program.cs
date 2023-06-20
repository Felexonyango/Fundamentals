// See https://aka.ms/new-console-template for more information


using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClientSample
{
    public class UserRegistration
    {
        private readonly HttpClient httpClient;

        public UserRegistration()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> RegisterUserAsync(string name, string email, string password)
        {
            var apiUrl = "https://helpdeskapi.sibasi.ltd/user/signupWithEmail"; // Replace with your API endpoint

            var requestData = new
            {
                Name = name,
                Email = email,
                Password = password
            };

            var content = new StringContent(
                JsonSerializer.Serialize(requestData),
                Encoding.UTF8,
                "application/json"
            );

            var response = await httpClient.PostAsync(apiUrl, content);

            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();

            return responseContent;
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            UserRegistration userRegistration = new UserRegistration();

            string name = "John Doe";
            string email = "john.doe@example.com";
            string password = "pa55w0rd";

            var result = await userRegistration.RegisterUserAsync(name, email, password);

            Console.WriteLine(result);
        }
    }
}

