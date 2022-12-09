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
    public class EfSubCategoryBrandRepository : EfRepositoyBase<SubCategoryBrand>, ISubCategoryBrandDal
    {

        public async Task<List<SubCategoryBrand>> Get3SubCategoryBrand()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                return await context.Set<SubCategoryBrand>().Take(3).ToListAsync();
            }
        }
    }

}
