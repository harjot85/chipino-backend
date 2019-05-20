using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Services
{
    public interface IService
    {
        IEnumerable<Content> GetAllTextContent();
        Content GetTextContentById(int id);
        IEnumerable<Media> GetAllMediaContent();
        Media GetMediaContentById(int id);
        IEnumerable<Footer> GetFooterContent();
    }
}
