using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Abstract
{
    public interface ISubCategoryBrandService
    {
        Task<SubCategoryBrand> AddAsync(SubCategoryBrand subCategoryBrand);
        Task<SubCategoryBrand> UpdateAsync(SubCategoryBrand subCategoryBrand);
        Task<bool> DeleteByIdAsync(int id);

        Task<List<SubCategoryBrand>> GetListAsync(Expression<Func<SubCategoryBrand, bool>> filter = null);

        Task<SubCategoryBrand> GetAsync(Expression<Func<SubCategoryBrand, bool>> filter);

        Task<SubCategoryBrand> GetModelByIdAsync(int id);

        Task<List<SubCategoryBrand>> Get3SubCategoryBrandAsync();
    }
}
