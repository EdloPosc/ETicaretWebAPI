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
    public class SubCategoryBrandService : ISubCategoryBrandService
    {

        private readonly ISubCategoryBrandDal _subCategoryBrandDal;

        public SubCategoryBrandService(ISubCategoryBrandDal subCategoryBrandDal)
        {
            _subCategoryBrandDal = subCategoryBrandDal;
        }

        public async Task<SubCategoryBrand> AddAsync(SubCategoryBrand subCategoryBrand)
        {
            var addSubCategoryBrand = await _subCategoryBrandDal.AddAsync(subCategoryBrand);
            return addSubCategoryBrand;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            return await _subCategoryBrandDal.DeleteByIdAsync(id);
        }

        public async Task<List<SubCategoryBrand>> Get3SubCategoryBrandAsync()
        {
            return await _subCategoryBrandDal.Get3SubCategoryBrand();
        }

        public async Task<SubCategoryBrand> GetAsync(Expression<Func<SubCategoryBrand, bool>> filter)
        {
            return await _subCategoryBrandDal.GetAsync(filter);
        }

        public async Task<List<SubCategoryBrand>> GetListAsync(Expression<Func<SubCategoryBrand, bool>> filter = null)
        {
            return await _subCategoryBrandDal.GetListAsync(filter);
        }

        public async Task<SubCategoryBrand> GetModelByIdAsync(int id)
        {
            return await _subCategoryBrandDal.GetModelByIdAsync(id);
        }

        public async Task<SubCategoryBrand> UpdateAsync(SubCategoryBrand subCategoryBrand)
        {
            return await _subCategoryBrandDal.UpdateAsync(subCategoryBrand);
        }
    }
}
