using System.ComponentModel.DataAnnotations.Schema;

namespace HotOccasionApp.INFRASTRUCTURE.DTO
{
    public class KeyWordDTO
    {
        #region Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CategoryId { get; set; }

        public CategoryDTO Category { get; set; }
        #endregion

    }
}
