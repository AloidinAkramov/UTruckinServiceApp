using System.Text.Json;
using UTruckinServiceApp.Models;
namespace UTruckinServiceApp.Services
{
    public class UtruckinService : IUtruckinService
    {
        private readonly HttpClient httpClient;
        private readonly IConfiguration configuration;

        public UtruckinService(HttpClient httpClient, IConfiguration configuration)
        {
            this.httpClient = httpClient;
            this.configuration = configuration;
        }

        public async Task<List<Content>> GetVehiclesWithPositionAsync(int page, int size)
        {
            string baseUrl = configuration["ApiSettings:BaseUrl"];
            string apiKey = configuration["ApiSettings:ApiKey"];

            string fullUrl = $"{baseUrl}?page={page}&size={size}";


            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var response = await httpClient.GetAsync(fullUrl);
            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var data = JsonSerializer.Deserialize<VehicleResponse>(json, options);
         
            return data.Content;
        }
    }
}