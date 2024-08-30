using Acme.StoreManagementDemo.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.StoreManagementDemo.Contracts.Categories
{
    public interface ICategoriesAppService : ICrudAppService<CategoryDTO ,int ,PagedAndSortedResultRequestDto , CreateUpdateCategoryDTO>
    {

    }
}
