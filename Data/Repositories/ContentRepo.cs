﻿using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Content> GetAllText()
        {
            return _ctx.TextContent;
        }

        public Content GetTextById(int id)
        {
            return (from c in _ctx.TextContent
                   where c.Id == id
                   select c).FirstOrDefault();
        }
    }
}