using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Data.Repositories
{
    interface IContentRepo
    {
        Content GetTextById(int id);
        IEnumerable<Content> GetAllText();
    }
}
