using backend_website.Data;
using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Services
{
    public class DummyDataService
    {
        private readonly DummyData _ctx;
        

        public DummyDataService()
        {
            _ctx = new DummyData();
        }

        public IEnumerable<Content> GetAllTextContent()
        {
            return _ctx.TextContent;
        }

        public Content GetTextContentById(int id)
        {
            return _ctx.TextContent.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Media> GetAllMediaContent()
        {
            return _ctx.MediaContent;
        }

        public Media GetMediaContentById(int id)
        {
            return _ctx.MediaContent.Where(m=>m.Id==id).FirstOrDefault();
        }

        public IEnumerable<Footer> GetFooterContent()
        {
            return _ctx.FooterContent;
        }
    }
}
