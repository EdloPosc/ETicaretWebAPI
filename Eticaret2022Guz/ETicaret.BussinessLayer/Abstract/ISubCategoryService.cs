using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Abstract
{
    public interface ISubCategoryService
    {
        Task<SubCategory> AddAsync(SubCategory subCategory);
        Task<SubCategory> UpdateAsync(SubCategory subCategory);
        Task<bool> DeleteByIdAsync(int id);

        Task<List<SubCategory>> GetListAsync(Expression<Func<SubCategory, bool>> filter = null);

        Task<SubCategory> GetAsync(Expression<Func<SubCategory, bool>> filter);

        Task<SubCategory> GetModelByIdAsync(int id);

        Task<List<SubCategory>> Get3SubCategoryAsync();
    }
}
