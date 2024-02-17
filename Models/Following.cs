using System.ComponentModel.DataAnnotations.Schema;

namespace Kumustagram_API.Models
{
    public class Following
    {
        public int FollowingId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; } // User who is following the user below
        public User User { get; set; }


        [ForeignKey("User")]
        public int FollowedUserId { get; set; } // User who is being followed by the user above
        public User FollowedUser { get; set; }
    }
}
