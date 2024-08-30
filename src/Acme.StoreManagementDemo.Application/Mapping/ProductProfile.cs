using Acme.StoreManagementDemo.Categories;
using Acme.StoreManagementDemo.DTOs.Categories;
using Acme.StoreManagementDemo.DTOs.Products;
using Acme.StoreManagementDemo.Products;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.StoreManagementDemo.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile() 
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, CreateUpdateProductDTO>().ReverseMap();
        }
    }
}
