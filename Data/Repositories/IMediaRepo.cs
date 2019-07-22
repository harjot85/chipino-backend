using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Data.Repositories
{
    interface IMediaRepo
    {
        Task<Media> GetImageById(int id);
        Task<IEnumerable<Media>> GetAllMedia();
    }
}
