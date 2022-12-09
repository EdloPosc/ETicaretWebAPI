using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Abstracts
{
    public interface ISubCategoryBrandDal : IGenericDal<SubCategoryBrand>
    {   
        Task<List<SubCategoryBrand>> Get3SubCategoryBrand();
    }
}
