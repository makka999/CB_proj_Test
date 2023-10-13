//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace CB_proj_Test.Models
{
    public class UserModel : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
