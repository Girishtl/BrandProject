using System.ComponentModel.DataAnnotations;

namespace EasyTaskMangmentDomain.Models.Request
{
    public class UserLoginRequest
    {

        [Required]
        [EmailAddress]
        public required string userName { get; set; }



        [Required]
        public required string password { get; set; }
    }
}
