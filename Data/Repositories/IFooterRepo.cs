using backend_website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend_website.Data.Repositories
{
    public interface IFooterRepo
    {
        Task<IEnumerable<Footer>> GetFooter();
    }
}
