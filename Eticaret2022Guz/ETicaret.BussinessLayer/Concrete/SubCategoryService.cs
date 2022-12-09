using ETicaret.BussinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstracts;
using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryDal _subCategoryDal;

        public SubCategoryService(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public async Task<SubCategory> AddAsync(SubCategory subCategory)
        {
            var addSubCategory = await _subCategoryDal.AddAsync(subCategory);
            return addSubCategory;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            return await _subCategoryDal.DeleteByIdAsync(id);
        }

        public async Task<List<SubCategory>> Get3SubCategoryAsync()
        {
            return await _subCategoryDal.Get3SubCategory();
        }

        public async Task<SubCategory> GetAsync(Expression<Func<SubCategory, bool>> filter)
        {
            return await _subCategoryDal.GetAsync(filter);
        }

        public async Task<List<SubCategory>> GetListAsync(Expression<Func<SubCategory, bool>> filter = null)
        {
            return await _subCategoryDal.GetListAsync(filter);
        }

        public async Task<SubCategory> GetModelByIdAsync(int id)
        {
            return await _subCategoryDal.GetModelByIdAsync(id);
        }

        public async Task<SubCategory> UpdateAsync(SubCategory subCategory)
        {
            return await _subCategoryDal.UpdateAsync(subCategory);
        }
    }
}
