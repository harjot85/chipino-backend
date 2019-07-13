using System.Linq;
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
        public Footer GetFooter()
        {
            return _ctx.GetFooterContent().FirstOrDefault();
        }
    }
}
