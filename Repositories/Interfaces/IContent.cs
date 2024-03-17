using Kumustagram_API.Models;

namespace Kumustagram_API.Repositories.Interfaces
{
    public interface IContent
    {
        IEnumerable<Content> GetAllContents();
        Content GetContentById(int id);
        void CreateContent(Content content);
        void UpdateContent(Content content);
        void DeleteContent(int id);
    }
}
