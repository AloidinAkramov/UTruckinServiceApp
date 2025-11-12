using UTruckinServiceApp.Models;
namespace UTruckinServiceApp.Services
{
    public interface IUtruckinService
    {
        Task<List<Content>> GetVehiclesWithPositionAsync(int page, int size);
    }
}