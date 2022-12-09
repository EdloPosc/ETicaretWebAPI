using ETicaret.DataAccessLayer.Abstracts;
using ETicaret.DataAccessLayer.Concretes.Contexts;
using ETicaret.DataAccessLayer.Repositories;
using ETicaret.EntityLayer.Abstracts;
using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.EntityFrameWorks
{
    public class EfBrandRepository : EfRepositoyBase<Brand>, IBrandDal
    {

        public async Task<List<Brand>> Get3Brand()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                return await context.Set<Brand>().Take(3).ToListAsync();
            }
        }
    }

}
