using backend_website.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace backend_website.Data
{
    public class DummyData : IRepositoryData
    {
        
        public async Task<IEnumerable<Content>> GetTextContent()
        {
            var textContent =  new List<Content>()
            {
                new Content(){ Id=0,PageData="Home Page Text", Description="This test is located on Home Page."},
                new Content(){ Id=1,PageData="Portfolio Page Text", Description="This text is location on Portfolio Page."},
                new Content(){ Id=2,PageData="Contact Us Page Text", Description="This text is located on Contact Us page."},
                new Content(){ Id=3,PageData="About Chipino Page Text", Description="This text in on About Chipino page."},
                new Content(){ Id=4,PageData="Support text Text", Description="This text is locaged here and tere."},
                new Content(){ Id=5,PageData="Some other text on a Page", Description="This text will be on some other part of the page."},
            };
            return await Task.Run(() => textContent);
        }

        public async Task<IEnumerable<Media>> GetMediaContent()
        {
            byte[] imgOne = File.ReadAllBytes("./wwwroot/Images/1.png");
            byte[] imgTwo = File.ReadAllBytes("./wwwroot/Images/2.png");

            var mediaContent = new List<Media>()
            {
                new Media(){ Id=10, FileContent=Convert.ToBase64String(imgOne), FileType="data:image/png;base64", FileDescription="This is Picture One with NO undelying text."  },
                new Media(){ Id=11, FileContent=Convert.ToBase64String(imgTwo), FileType="data:image/png;base64", FileDescription="This is Picture Two with undelying text."  },
            };
            return await Task.Run(() => mediaContent);
        }

        public async Task<IEnumerable<Footer>> GetFooterContent()
        {
            var footerContent = new List<Footer>()
            {
                new Footer(){ Id=501, IconClass="fab fa-github", Height="36px",Width="36px", LinkTo="github.com", HoverColor="#289CCB"  },
                new Footer(){ Id=502, IconClass="fab fa-medium-m", Height="36px",Width="36px", LinkTo="medium.com", HoverColor="#A9EAD2"  },
                new Footer(){ Id=503, IconClass="fab fa-reddit-alien", Height="36px",Width="36px", LinkTo="reddit.com", HoverColor="#FF8B94"  },
            };
            return await Task.Run(() => footerContent);
        }

        public async Task<IEnumerable<Carousel>> GetCarouselContent()
        {
            byte[] imgTwo = File.ReadAllBytes("./wwwroot/Images/2.png");

            var carouselContent = new List<Carousel>()
            {
                new Carousel(){ Id=801, Image=Convert.ToBase64String(imgTwo), Heading="Dummy Heading", Description= "Dummy description", HeadingTextColor="yellow", DescTextColor="blue" },
            };
            return await Task.Run(()=>carouselContent);

        }

        public Task<bool> AddRepository(GitHubRepo repository)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRepository(int repositoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Navbar>> GetNavbarItems()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GitHubRepo>> GetAllRepositories()
        {
            var res = new GitHubRepository();
            return await res.GetAllRepos();
        }

        public async Task<IEnumerable<GitHubRepo>> GetFilteredRepositories(FilterModel fm)
        {
            var res = await new GitHubRepository().GetAllRepos();
            return res.Where(x=>x.Name.Equals(fm.Language));
        }
    }
}
