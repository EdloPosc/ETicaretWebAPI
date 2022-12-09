﻿using ETicaret.EntityLayer.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETicaret.EntityLayer.Concretes
{
    public class SubCategoryBrand : IEntity
    {
        public int SubCategoryBrandId { get; set; }

        public int BrandId { get; set; }

        public int SubCategoryId { get; set; }


        public bool SubCategoryBrandStatu { get; set; }

        public Brand Brand { get; set; }
        
        public SubCategory SubCategory { get; set; }
       
    }

}
