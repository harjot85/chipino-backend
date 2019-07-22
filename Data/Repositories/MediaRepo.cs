using backend_website.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Data.Repositories
{
    public class MediaRepo : IMediaRepo
    {
        private readonly DummyData _ctx;

        public MediaRepo()
        {
            _ctx = new DummyData();
        }

        public async Task<IEnumerable<Media>> GetAllMedia()
        {
            return await _ctx.GetMediaContent();
        }

        public async Task<Media> GetImageById(int id)
        {
            var result = await _ctx.GetMediaContent();
            return result.Where(m => m.Id == id).FirstOrDefault();
        }
    }
}
