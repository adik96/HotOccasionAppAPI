

namespace HotOccasionApp.INFRASTRUCTURE.DTO
{
    public class OccasionCategoryDTO
    {
        #region Properties
        public long OccasionId { get; set; }
        public long CategoryId { get; set; }

        public OccasionDTO Occasion { get; set; }
        public CategoryDTO Category { get; set; }
        #endregion
    }
}
