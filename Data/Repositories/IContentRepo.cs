using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Data.Repositories
{
    interface IContentRepo
    {
        Task<Content> GetTextById(int id);
        Task<IEnumerable<Content>> GetAllText();
    }
}
