using backend_website.Models;
using System.Collections.Generic;
using System.Linq;

namespace backend_website.Data.Repositories
{
    public class MediaRepo : IMediaRepo
    {
        private readonly DummyData _ctx;

        public MediaRepo()
        {
            _ctx = new DummyData();
        }

        public IEnumerable<Media> GetAllMedia()
        {
            return _ctx.GetMediaContent();
        }

        public Media GetImageById(int id)
        {
            return _ctx.GetMediaContent().Where(m => m.Id == id).FirstOrDefault();
        }
    }
}
