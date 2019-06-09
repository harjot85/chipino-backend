using System.Collections.Generic;
using backend_website.Models;

namespace backend_website.Data.Repositories
{
    public class CarouselRepo : ICarouselRepo
    {
        private readonly DummyData _ctx;
        public CarouselRepo()
        {
            _ctx = new DummyData();
        }

        public IEnumerable<Carousel> GetCarousel()
        {
            return _ctx.GetCarouselContent();
        }
    }
}
