using HotOccasionApp.INFRASTRUCTURE.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotOccasionApp.INFRASTRUCTURE.DTO
{
    public class OccasionDTO
    {
        #region Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OccasionCode { get; set; }
        public OccasionTypeDiscriminators TypeDiscriminator { get; set; }
        public long OcassionPricesId { get; set; }
        public string AuthorId { get; set; }

        public UserDTO Author { get; set; }
        public OcassionPricesDTO OcassionPrices { get; set; }
        public ICollection<OccasionCategoryDTO> Categories { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
        #endregion
    }
}
