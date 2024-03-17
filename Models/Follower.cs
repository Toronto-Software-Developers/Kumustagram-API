using System.ComponentModel.DataAnnotations.Schema;

namespace Kumustagram_API.Models
{
    public class Follower
    {
        public int FollowerId { get; set; }


        [ForeignKey("FollowedUser")]
        public int FollowedUserId { get; set; }
        public User FollowedUser { get; set; } // Represents the user being followed by the follower



        [ForeignKey("FollowerUser")]
        public int FollowerUserId { get; set; } 
        public User FollowerUser { get; set; } // Represents the user who is following the followed user
    }
}
