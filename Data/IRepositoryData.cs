using backend_website.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend_website.Data
{
    public interface IRepositoryData
    {
        IEnumerable<Content> GetTextContent();
        IEnumerable<Media> GetMediaContent();
        IEnumerable<Footer> GetFooterContent();
        IEnumerable<Carousel> GetCarouselContent();
        Task<bool> AddRepository(Models.GitHubRepository repository);
        Task<bool> RemoveRepository(int repositoryId);
    }
}