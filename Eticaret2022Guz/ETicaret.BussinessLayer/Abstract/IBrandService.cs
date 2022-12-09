using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Abstract
{
    public interface IBrandService
    {
        Task<Brand> AddAsync(Brand brand);
        Task<Brand> UpdateAsync(Brand brand);
        Task<bool> DeleteByIdAsync(int id);

        Task<List<Brand>> GetListAsync(Expression<Func<Brand, bool>> filter = null);

        Task<Brand> GetAsync(Expression<Func<Brand, bool>> filter);

        Task<Brand> GetModelByIdAsync(int id);

        Task<List<Brand>> Get3BrandAsync();
    }
}
