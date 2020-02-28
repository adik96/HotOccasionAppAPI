using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace HotOccasionApp.DB.Entities
{
    public class User : IdentityUser
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        #endregion

        #region Eager loading properties
        public ICollection<Occasion> Occasions { get; set; }
        #endregion
    }
}
