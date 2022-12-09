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
    public class EfSubCategoryRepository : EfRepositoyBase<SubCategory>, ISubCategoryDal
    {

        public async Task<List<SubCategory>> Get3SubCategory()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                return await context.Set<SubCategory>().Take(3).ToListAsync();
            }
        }
    }

}
