using System.Collections.Generic;

namespace HotOccasionApp.DB.Entities
{
    public class Category
    {
        #region Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region Eager loading properties
        public ICollection<OccasionCategory> Occasions { get; set; }
        #endregion
    }
}
