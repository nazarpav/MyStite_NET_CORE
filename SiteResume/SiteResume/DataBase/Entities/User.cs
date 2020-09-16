using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
namespace SiteResume.DataBase.Entities
{
    public class User : IdentityUser<int>
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
