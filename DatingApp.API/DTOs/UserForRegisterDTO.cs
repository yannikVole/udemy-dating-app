using System.ComponentModel.DataAnnotations;
namespace DatingApp.API.DTOs
{
    public class UserForRegisterDTO
    {

        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 30 characters")]
        public string Password { get; set; }
        public string Gender { get; set; }
        public int MyProperty { get; set; }
    }
}