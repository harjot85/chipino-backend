using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_website.Models;

namespace backend_website.Data.Repositories
{
    public class ContentRepo : IContentRepo
    {
        public IEnumerable<Content> GetAllText()
        {
            throw new NotImplementedException();
        }

        public Content GetTextById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
