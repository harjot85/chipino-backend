using backend_website.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend_website.Data
{
    public interface IRepositoryData
    {
        Task<IEnumerable<Content>> GetTextContent();
        Task<IEnumerable<Media>> GetMediaContent();
        Task<IEnumerable<Footer>> GetFooterContent();
        Task<IEnumerable<Carousel>> GetCarouselContent();
        Task<List<Navbar>> GetNavbarItems();
        Task<bool> AddRepository(Models.GitHubRepository repository);
        Task<bool> RemoveRepository(int repositoryId);
    }
}