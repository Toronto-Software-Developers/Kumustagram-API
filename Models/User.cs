using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kumustagram_API.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Avatar { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Password cannot be longer than 30 characters!")]
        public string Password { get; set; }
        
        public string ResetPasswordToken { get; set; }
        public DateTime ResetPasswordExpire { get; set; }


        public List<Content> Contents { get; set; } = new List<Content>();
        public List<ContentLike> LikedContents { get; set; } = new List<ContentLike>();
        public List<ContentComment> CommentedContents { get; set; } = new List<ContentComment>();

        [InverseProperty("FollowerUser")]
        public List<Follower> FollowerUsers { get; set; } = new List<Follower>();

        [InverseProperty("FollowedUser")]
        public List<Follower> FollowedUsers { get; set; } = new List<Follower>();
    }
}
