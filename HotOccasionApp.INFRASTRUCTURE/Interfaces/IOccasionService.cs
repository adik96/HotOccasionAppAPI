using HotOccasionApp.INFRASTRUCTURE.DTO;

namespace HotOccasionApp.INFRASTRUCTURE.Interfaces
{
    public interface IOccasionService : IService
    {
        OccasionDTO GetOccasionByID(long id);
    }
}
