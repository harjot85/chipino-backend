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
        private readonly IEnumerable<Content> _localTextContent;
        private readonly IEnumerable<Media> _localMediaContent;

        public DummyDataService()
        {
            DummyData.Initialize();
            _localTextContent = DummyData.TextContent;
            _localMediaContent = DummyData.MediaContent;
        }

        public IEnumerable<Content> GetAllTextContent()
        {
            return _localTextContent;
        }

        public Content GetTextContentById(int id)
        {
            return (_localTextContent.Where(c=> c.Id == id)).FirstOrDefault();
        }

        public IEnumerable<Media> GetAllMediaContent()
        {
            return _localMediaContent;
        }

        public Media GetMediaContentById(int id)
        {
            return (_localMediaContent.Where(m => m.Id == id)).FirstOrDefault();
        }

    }
}
