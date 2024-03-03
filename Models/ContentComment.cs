using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kumustagram_API.Models
{
    public class ContentComment
    {
        public int ContentCommentId { get; set; }
        public string CommentStr { get; set; }



        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }


        [ForeignKey("Content")]
        public int ContentId { get; set; } // foreign key
        public Content Content { get; set; } // reference to Content

    }
}
