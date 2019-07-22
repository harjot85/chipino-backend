using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_website.Models;

namespace backend_website.Data.Repositories
{
    public class ContentRepo : IContentRepo
    {
        private readonly DummyData _ctx;
        public ContentRepo()
        {
            _ctx = new DummyData();     
        }
        public async Task<IEnumerable<Content>> GetAllText()
        {
            return await _ctx.GetTextContent();
        }

        public async Task<Content> GetTextById(int id)
        {
            return (from c in await _ctx.GetTextContent()
                   where c.Id == id
                   select c).FirstOrDefault();
        }
    }
}
