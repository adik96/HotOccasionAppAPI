using HotOccasionApp.INFRASTRUCTURE.Common.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotOccasionApp.DB.Entities
{
    public class Occasion
    {
        #region Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OccasionCode { get; set; }
        public OccasionTypeDiscriminators TypeDiscriminator { get; set; }
        public long OcassionPricesId { get; set; }
        public string AuthorId { get; set; }
        #endregion

        #region Eager loading properties
        [ForeignKey("AuthorId")]
        public User Author { get; set; }

        [ForeignKey("OcassionPricesId")]
        public OcassionPrices OcassionPrices { get; set; }
        public ICollection<OccasionCategory> Categories { get; set; }
        public ICollection<Comment> Comments { get; set; }
        #endregion
    }
}
