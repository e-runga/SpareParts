using System.ComponentModel.DataAnnotations;

namespace SpareParts.Dto
{
    public class UserDto : BaseDto
    {
        [Required(ErrorMessage = "User name is required")]
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        public string Mobile { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, ErrorMessage = "Must be between 6 and 20 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Profile is required")]
        public ProfileDto Profile { get; set; }
    }
}