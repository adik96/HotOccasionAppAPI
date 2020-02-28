using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotOccasionApp.DB.Entities
{
    public class Comment
    {
        #region Properties
        [Key]
        public long Id { get; set; }
        public string Text { get; set; }
        public string AuthorId { get; set; }
        public long OccasionId { get; set; }
        #endregion

        #region Eager loading properties
        [ForeignKey("AuthorId")]
        public User Author { get; set; }
        [ForeignKey("OccasionId")]
        public Occasion Occasion { get; set; }
        #endregion
    }
}
