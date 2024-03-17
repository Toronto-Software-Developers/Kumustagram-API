using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kumustagram_API.Models
{
    public class Content
    {
        public int ContentId { get; set; }
        public string? Caption { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<ContentLike> Likes { get; set; } = new List<ContentLike>();
        public List<ContentComment> ContentComments { get; set; } = new List<ContentComment>();  // reference to Comment

        [ForeignKey("User")]
        public int UserId { get; set; } // foreign key
        public User User { get; set; } // reference to User


    }
}
