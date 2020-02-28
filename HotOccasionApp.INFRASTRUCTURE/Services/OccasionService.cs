using HotOccasionApp.DB.Interfaces;
using HotOccasionApp.INFRASTRUCTURE.DTO;
using HotOccasionApp.INFRASTRUCTURE.Interfaces;

namespace HotOccasionApp.INFRASTRUCTURE.Services
{
    public class OccasionService : IOccasionService
    {
        private readonly IDapperOccasionRepository _occasionRepository;

        public OccasionService(IDapperOccasionRepository occasionRepository)
        {
            _occasionRepository = occasionRepository;
        }
        public OccasionDTO GetOccasionByID(long id)
        {
            var test = _occasionRepository.GetOccasionByID(2);
            return new OccasionDTO();
        }
    }
}
