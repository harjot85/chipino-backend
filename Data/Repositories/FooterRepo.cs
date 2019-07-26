using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_website.Models;

namespace backend_website.Data.Repositories
{
    public class FooterRepo : IFooterRepo
    {
        private readonly DummyData _ctx;
        public FooterRepo()
        {
            _ctx = new DummyData();
        }
        public async Task<IEnumerable<Footer>> GetFooter()
        {
            return await _ctx.GetFooterContent();
        }
    }
}
