using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Services
{
    public interface IService
    {
        Task<IEnumerable<Content>> GetAllTextContent();
        Task<Content> GetTextContentById(int id);
        Task<IEnumerable<Media>> GetAllMediaContent();
        Task<Media> GetMediaContentById(int id);
        Task<IEnumerable<Footer>> GetFooterContent();
        Task<IEnumerable<Carousel>> GetCarouselContent();
        Task<List<Navbar>> GetNavbarItems();
        Task<bool> AddGitRepository(GitHubRepo repository);
        Task<bool> RemoveGitRepository(int repositoryId);
        Task<IEnumerable<GitHubRepo>> GetAllRepositories();
        Task<IEnumerable<GitHubRepo>> GetFilteredRepositories(FilterModel fm);
        Task<IEnumerable<Configuration>> GetConfiguration();
    }
}
