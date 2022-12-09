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
    public class BrandService : IBrandService
    {

        private readonly IBrandDal _brandDal;

        public BrandService(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public async Task<Brand> AddAsync(Brand brand)
        {

            var addBrand = await _brandDal.AddAsync(brand);
            return addBrand;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            return await _brandDal.DeleteByIdAsync(id);
        }

        public async Task<List<Brand>> Get3BrandAsync()
        {
            return await _brandDal.Get3Brand();
        }

        public async Task<Brand> GetAsync(Expression<Func<Brand, bool>> filter)
        {
            return await _brandDal.GetAsync(filter);
        }

        public async Task<List<Brand>> GetListAsync(Expression<Func<Brand, bool>> filter = null)
        {
            return await _brandDal.GetListAsync(filter);
        }

        public async Task<Brand> GetModelByIdAsync(int id)
        {
            return await _brandDal.GetModelByIdAsync(id);
        }

        public async Task<Brand> UpdateAsync(Brand brand)
        {
            return await _brandDal.UpdateAsync(brand);
        }
    }
}
