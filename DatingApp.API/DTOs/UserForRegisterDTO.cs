using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDTO
    {
        public UserForRegisterDTO(string username, string password, string genderIdentity, string knownAs, DateTime dateOfBirth)
        {
            this.Username = username;
            this.Password = password;
            this.GenderIdentity = genderIdentity;
            this.KnownAs = knownAs;
            this.DateOfBirth = dateOfBirth;

        }
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage =
        "You must specify password between 4 and 8 characters.")]
        public string Password { get; set; }
        [Required]
        public string GenderIdentity { get; set; }
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public UserForRegisterDTO()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}