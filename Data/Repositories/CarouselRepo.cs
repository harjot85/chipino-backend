using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Carousel>> GetCarousel()
        {
            return await _ctx.GetCarouselContent();
        }
    }
}
