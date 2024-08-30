using Acme.StoreManagementDemo.Categories;
using Acme.StoreManagementDemo.Contracts.Categories;
using Acme.StoreManagementDemo.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.StoreManagementDemo.Services.Categories
{
    public class CategoriesAppService : CrudAppService<Category, CategoryDTO, int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDTO>, ICategoriesAppService
    {
        public CategoriesAppService(IRepository<Category, int> repository) : base(repository)
        {

        }
    }
}
