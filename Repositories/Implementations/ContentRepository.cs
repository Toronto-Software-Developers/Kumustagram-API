using Kumustagram_API.DatabaseContext;
using Kumustagram_API.Models;
using Kumustagram_API.Repositories.Interfaces;

namespace Kumustagram_API.Repositories.Implementations
{
    public class ContentRepository : IContent
    {
        private readonly KumustagramDbContext _context;

        public ContentRepository(KumustagramDbContext context)
        {
            _context = context;
        }

        public void CreateContent(Content content)
        {
            _context.Contents.Add(content);
            _context.SaveChanges();
        }

        public void DeleteContent(int id)
        {
            Content content = _context.Contents.Find(id);
            if (content == null) { throw new Exception("Content not found!"); }

            _context.Contents.Remove(content);
            _context.SaveChanges();
        }

        public IEnumerable<Content> GetAllContents()
        {
            return _context.Contents.ToList();
        }

        public Content GetContentById(int id)
        {
            Content content = _context.Contents.Find(id);
            if (content == null)
            {
                throw new Exception("Content not found!");
            }

            return content;
        }

        public void UpdateContent(Content content)
        {
            Content _content = _context.Contents.Where(x => x.ContentId == content.ContentId).FirstOrDefault();
            if (_content == null)
            {
                throw new Exception("Content not found!");
            }

            else
            {
                if (content.Caption != null) { _content.Caption = content.Caption; }

                _context.SaveChanges();
            }
        }
    }
}
