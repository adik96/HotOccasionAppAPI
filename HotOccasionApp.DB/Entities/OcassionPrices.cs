using System.ComponentModel.DataAnnotations.Schema;

namespace HotOccasionApp.DB.Entities
{
    public class OcassionPrices
    {
        #region Properties
        public long Id { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        #endregion

        #region Eager loading properties
        public Occasion Occasion { get; set; }
        #endregion
    }
}
