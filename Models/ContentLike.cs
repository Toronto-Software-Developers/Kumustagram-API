using System.ComponentModel.DataAnnotations.Schema;

namespace Kumustagram_API.Models
{
    public class ContentLike
    {
        public int ContentLikeId { get; set; }

        [ForeignKey("Content")]
        public int ContentId { get; set; }
        public Content Content { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
