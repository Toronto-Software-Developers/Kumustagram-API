using System.Collections.Generic
using System
using System.ComponentModel.DataAnnotations;

namespace Kumustagram_API.Models
{
    public class User
    {
        private int Id { get; set; }

        [Required]
        private string Name { get; set; }
        private string Avatar { get; set; }

        [Required]
        private string Email { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Password cannot be longer than 30 characters!")]
        private string Password { get; set; }
        private List<Post> Posts { get; set; } = new List<Post>();
        private List<int> Followers { get; set; } = new List<int>();
        private List<int> Following { get; set; } = new List<int>();
        private string ResetPasswordToken { get; set; }
        private DateTime ResetPasswordExpire { get; set; }
}
