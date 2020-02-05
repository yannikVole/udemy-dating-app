using System;
using System.ComponentModel.DataAnnotations;
namespace DatingApp.API.DTOs {
    public class UserForRegisterDTO {

        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength (30, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 30 characters")]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }
        public DateTime Created { get; set; }

        [Required]
        public string KnownAs { get; set; }
        public DateTime LastActive { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
    }
}