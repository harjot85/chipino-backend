using backend_website.Models;
using System.Collections.Generic;

namespace backend_website.Data
{
    public interface IRepositoryData
    {
        IEnumerable<Content> GetTextContent();
        IEnumerable<Media> GetMediaContent();
        IEnumerable<Footer> GetFooterContent();
        IEnumerable<Carousel> GetCarouselContent();
    }
}