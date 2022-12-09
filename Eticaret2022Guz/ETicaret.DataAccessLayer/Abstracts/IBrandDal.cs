using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Abstracts
{
    public interface IBrandDal : IGenericDal<Brand>
    {
        Task<List<Brand>> Get3Brand();
    }
}
