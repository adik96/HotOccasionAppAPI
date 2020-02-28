using System.ComponentModel.DataAnnotations.Schema;

namespace HotOccasionApp.INFRASTRUCTURE.DTO
{
    public class OcassionPricesDTO
    {
        #region Properties
        public long Id { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }

        public OccasionDTO Occasion { get; set; }
        #endregion
    }
}
