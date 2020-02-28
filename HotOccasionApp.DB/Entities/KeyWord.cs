using System.ComponentModel.DataAnnotations.Schema;

namespace HotOccasionApp.DB.Entities
{
    public class KeyWord
    {
        #region Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public long CategoryId { get; set; }
        #endregion

        #region Eager loading properties
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        #endregion
    }
}
