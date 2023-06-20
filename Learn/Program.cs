// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitSample
{
    public class Employee
    {

        public async Task<string> GetDataAsync()
        {
            HttpClient client = new HttpClient();
            Uri apiaddress = new Uri("https://jsonplaceholder.typicode.com/posts");

            try
            {
                var response = await client.GetAsync(apiaddress);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                return data;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"An HTTP request error occurred: {ex.Message}");
                throw;
            }
        }

    }
    class Program
    {
        static async Task Main(string[] args)
        {
          Employee employee = new Employee();

            var result = await employee.GetDataAsync();
            Console.WriteLine(result);
        }
    }
}