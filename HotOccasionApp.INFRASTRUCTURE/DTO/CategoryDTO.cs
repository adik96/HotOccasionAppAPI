using System.Collections.Generic;

namespace HotOccasionApp.INFRASTRUCTURE.DTO
{
    public class CategoryDTO
    {
        #region Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<OccasionCategoryDTO> Occasions { get; set; }
        #endregion
    }
}
