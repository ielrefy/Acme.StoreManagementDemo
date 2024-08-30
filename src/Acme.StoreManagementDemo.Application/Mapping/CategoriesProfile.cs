using Acme.StoreManagementDemo.Categories;
using Acme.StoreManagementDemo.DTOs.Categories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.StoreManagementDemo.Mapping
{
    public class CategoriesProfile : Profile
    {
        public CategoriesProfile() 
        {
        CreateMap<Category,CategoryDTO>();
        CreateMap<CreateUpdateCategoryDTO ,Category>().ReverseMap();
        }
    }
}
