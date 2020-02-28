using System.ComponentModel.DataAnnotations.Schema;

namespace HotOccasionApp.DB.Entities
{
    public class OccasionCategory
    {
        #region Properties
        public long OccasionId { get; set; }
        public long CategoryId { get; set; }
        #endregion

        #region Eager loading properties
        [ForeignKey("OccasionId")]
        public Occasion Occasion { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        #endregion
    }
}
