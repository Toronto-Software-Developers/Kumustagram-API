using System
using System.Collections.Generic

namespace Kumustagram_API.Models
{
    public class Post
    {
        private int Id { get; set; }
        private string Caption { get; set; }
        private string Image { get; set; }
        private string Owner { get; set; }
        private DateTime CreatedAt { get; set; } = DateTime.Now;
        private List<int> Likes { get; set; } = new List<int>();
        private List<Comment> Comments { get; set; } = new List<Comment>();
        

    }
