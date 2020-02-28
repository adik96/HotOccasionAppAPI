using HotOccasionApp.DB.Entities;

namespace HotOccasionApp.DB.Interfaces
{
    public interface ITestRepository
    {
        Occasion GetOccasionByID(long id);
    }
}
