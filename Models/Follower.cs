using System.ComponentModel.DataAnnotations.Schema;

namespace Kumustagram_API.Models
{
    public class Follower
    {
        public int FollowerId { get; set; }


        [ForeignKey("UserId")]
        public int UserId { get; set; } // User who is being followed by the User below
        public User User { get; set; }


        public int FollowingUserId { get; set; } // User is following the User above
    }
}
