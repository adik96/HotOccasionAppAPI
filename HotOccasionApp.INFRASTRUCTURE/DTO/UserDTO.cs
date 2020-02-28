using System.Collections.Generic;

namespace HotOccasionApp.INFRASTRUCTURE.DTO
{
    public class UserDTO
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<OccasionDTO> Occasions { get; set; }
        #endregion
    }
}
