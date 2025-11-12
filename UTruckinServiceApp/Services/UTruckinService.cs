using System.Text.Json;
using UTruckinServiceApp.Models;
namespace UTruckinServiceApp.Services
{
    public class UTruckinService : IUTruckinService
    {
        private readonly HttpClient httpClient;

        public UTruckinService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Content>> GetVehiclesWithPositionAsync()
        {
            string apiKey = "27a9a6fa4b491c600dff04417931369763355bb3cfe65c5825528079da44dd77";

            httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);

            var url = "https://api.utruckin.com/logger/third-part-user/vehicles/present?page=0&size=10";
            var response = await httpClient.GetAsync(url);


            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var data = JsonSerializer.Deserialize<VehicleResponse>(json, options);

            return data.Content;
        }
    }
}