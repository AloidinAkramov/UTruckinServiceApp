using UTruckinServiceApp.Models;
namespace UTruckinServiceApp.Services
{
    public interface IUTruckinService
    {
        Task<List<Content>> GetVehiclesWithPositionAsync();
    }
}